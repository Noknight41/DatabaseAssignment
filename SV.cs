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
        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-HK69CUKA\SQL1;Initial Catalog=Ass2;Persist Security Info=True;User ID=MyLogin;Password=123");

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

        private void SVControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (SVControl.SelectedTab.Name)
            {
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
            }
        }

        private void LD_Click(object sender, EventArgs e)
        {

        }
    }
}
