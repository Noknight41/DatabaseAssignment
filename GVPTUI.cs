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
    public partial class GVPTUI : Form
    {
        string Route;
        string MSCB;
        string MMH;
        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-HK69CUKA\SQL1;Initial Catalog=Ass2;User ID=GVPTLogin;Password=123");
       
        public GVPTUI()
        {
            Route = "";
            InitializeComponent();
            Con.Open();
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GVPT_FormClosed);
        }

        public void setGVPT(string MSCB, string Maso)
        {
            this.MSCB = MSCB;
            this.MMH = Maso;
            Masocanbo.Text = MSCB;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            switch (GVPTControl.SelectedIndex)
            {
                case 0:
                    {
                        FMTpopulate();
                        break;
                    }
            }
        }

        private void GVPT_FormClosed(object sender, FormClosedEventArgs e)
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

        private void FMTpopulate()
        {
            string query = "SELECT * FROM FILE_MO_TA";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ViewLT.DataSource = ds.Tables[0];
        }

        private void FMT_AB_Click(object sender, EventArgs e)
        {
            if (IDFMT.Text == "" || URL.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string query = "INSERT INTO FILE_MO_TA values('" + IDFMT.Text + "', '" + URL.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    FMTpopulate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void FMT_EB_Click(object sender, EventArgs e)
        {
            if (IDFMT.Text == "" || URL.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string query = "UPDATE FILE_MO_TA SET URL_hinh_anh = '" + URL.Text + "' WHERE ID_FMT = '" + IDFMT.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    FMTpopulate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
    }
}
