using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Assignment2
{
    public partial class SV : Form
    {
        string Route;
        string MSSV;
        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-HK69CUKA\SQL1;Initial Catalog=Ass2;Persist Security Info=True;User ID=SVLogin;Password=123");

        public SV()
        {
            Route = "";
            InitializeComponent();
            Con.Open();
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SV_FormClosed);
        }

        public void setSV(string MSSV)
        {
            this.MSSV = MSSV;
            Masosinhvien.Text = MSSV;
        }

        private void SV_FormClosed(object sender, FormClosedEventArgs e)
        {
            Con.Close();
            if (this.Route == "")
            {
                Application.Exit();
                return;
            }
            if (this.Route == "Login")
            {
                Login UI = new Login();
                UI.Show();
            }
            if (this.Route == "XDT")
            {
                XDT UI = new XDT();
                UI.setDTSV(XMDT.Text, MSSV);
                UI.Show();
            }
            if (this.Route == "LDT")
            {
                LDT UI = new LDT();
                UI.setLDT(LDT.Text, MSSV);
                UI.Show();
            }
        }

        private void SVControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (SVControl.SelectedTab.Name)
            {
                case "XDT":
                {
                    XDTpopulate();
                    break;
                }
                case "GC":
                {
                    NDTpopulate();
                    break;
                }
                case "LB":
                {
                    DTpopulate();
                    break;
                }
                case "PW":
                {
                    PWpopulate();
                    break;
                }
            }
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            this.Route = "Login";
            this.Close();
        }

        private void NDTpopulate()
        {
            string query = "SELECT * FROM NOTE WHERE MSSV = '" + MSSV + "';";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ViewNote.DataSource = ds.Tables[0];
        }

        private void DTpopulate()
        {
            string query = "SELECT * FROM viewDT();";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ViewDT.DataSource = ds.Tables[0];
        }

        private void XDTpopulate()
        {
            string query = "SELECT * FROM viewDT();";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            VXDT.DataSource = ds.Tables[0];
        }

        private void DiemThipopulate()
        {
            string query = "SELECT DISTINCT MSSV, Ma_de_thi, GRADE FROM iii6 ("+LT_DT.Text+", '"+MSSV+"');";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ViewDiemThi.DataSource = ds.Tables[0];
        }

        private void PWpopulate()
        {
            string query = "SELECT dbo.PassSV('" + MSSV + "');";
            using (var cmd = new SqlCommand(query, Con))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Password.Text = reader.GetString(0);
                    reader.Close();
                    return;
                }
                reader.Close();
            }
        }

        private void N_EB_Click(object sender, EventArgs e)
        {
            if (N_MDT.Text == "" || N_N.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string query = "UPDATE NOTE SET Note = '" + N_N.Text + "' WHERE Ma_de_thi = '" + N_MDT.Text + "' AND MSSV = '" + MSSV + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    NDTpopulate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void XD_Click(object sender, EventArgs e)
        {
            if (XMDT.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                this.Route = "XDT";
                this.Close();
            }
        }

        private void LD_Click(object sender, EventArgs e)
        {
            if (LDT.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    int DT = -1;
                    string query = "SELECT dbo.checkLamBai('" + MSSV + "', '" + LDT.Text + "') AS DT;";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    SqlDataReader dr = null;
                    using (dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            DT = (int)dr["DT"];
                        };
                    };
                    if (DT != 0)
                    {
                        MessageBox.Show("Bạn không thể làm đề có cùng môn học và lần thi với đề bạn đã làm !");
                    }
                    else
                    {
                        string query1 = "INSERT INTO NOTE(MSSV, Ma_de_thi, Note) VALUES ('"+ MSSV +"', '"+ LDT.Text + "', ''); ";
                        string query2 = "EXEC setUpLamBai @DT = '"+ LDT.Text + "', @MSSV = '"+MSSV+"';";
                        SqlCommand cmd1 = new SqlCommand(query1, Con);
                        SqlCommand cmd2 = new SqlCommand(query2, Con);
                        cmd1.ExecuteNonQuery();
                        cmd2.ExecuteNonQuery();
                        this.Route = "LDT";
                        this.Close();
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
                //this.Route = "LDT";
                //Con.Close();
                //this.Close();
            }
        }

        private void LT_B_Click(object sender, EventArgs e)
        {
            DiemThipopulate();
        }

        private void PW_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "UPDATE SINH_VIEN SET Pass = '" + Password.Text + "' WHERE MSSV = '" + MSSV + "';";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                PWpopulate();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
    }
}
