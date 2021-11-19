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
    public partial class GVQLUI : Form
    {
        string Route;
        string MSCB;
        string MMH;
        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-HK69CUKA\SQL1;Initial Catalog=Ass2;Persist Security Info=True;User ID=MyLogin;Password=123");
        public GVQLUI()
        {
            Route = "";
            InitializeComponent();
            Con.Open();
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GVQL_FormClosed);
        }
        public void setGVQL(string MSCB, string Maso)
        {
            this.MSCB = MSCB;
            this.MMH = Maso;
            Masocanbo.Text = "MSCB: " + MSCB;
            Mamonhoc.Text = "MMH: " + MMH;
        }

        private void GVQL_FormClosed(object sender, FormClosedEventArgs e)
        {
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
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            this.Route = "Login";
            Con.Close();
            this.Close();
        }

        private void DDTpopulate()
        {
            string query = "SELECT Ma_de_thi, Ngay_xac_nhan_ra_de, Ngay_duyet_de, Ngay_thi FROM DE_THI WHERE Trich_Mon_hoc = '" + MMH + "';";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ViewDDT.DataSource = ds.Tables[0];
        }

        private void PWpopulate()
        {
            string query = "SELECT dbo.PassGVQL('" + MSCB + "');";
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

        private void NDTpopulate()
        {
            string query = "SELECT Ma_de_thi, Note FROM DE_THI WHERE Trich_Mon_hoc = '" + MMH + "';";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ViewNote.DataSource = ds.Tables[0];
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            switch (GVQLControl.SelectedTab.Name)
            {
                case "PW":
                {
                    PWpopulate();
                    break;
                }
                case "DDT":
                {
                    DDTpopulate();
                    break;
                }
                case "NDT":
                {
                    NDTpopulate();
                    break;
                }
                
            }
        }

        private void PW_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "UPDATE GIANG_VIEN_QUAN_LY SET Pass = '" + Password.Text + "' WHERE MSCB = '" + MSCB + "';";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                PWpopulate();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void DDT_B_Click(object sender, EventArgs e)
        {
            if (DDT_MDT.Text == "" || DDT_NT.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string query = "UPDATE DE_THI SET Ngay_duyet_de = '" + DDT_NT.Text + "', MSCB_duyet = '" + MSCB +"' WHERE Ma_de_thi = '" + DDT_MDT.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    DDTpopulate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void NDT_EB_Click(object sender, EventArgs e)
        {
            if (NDT_MDT.Text == "" || NDT_ND.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string query = "UPDATE DE_THI SET Note = '" + NDT_ND.Text + "' WHERE Ma_de_thi = '" + NDT_MDT.Text + "';";
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
    }
}
