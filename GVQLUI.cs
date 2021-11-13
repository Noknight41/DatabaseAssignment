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
        SqlConnection Con = new SqlConnection(@"Data Source=LEHOANGTHUYLINH\SQLEXPRESS;Initial Catalog=test3;Integrated Security=True");
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
            Masocanbo.Text = MSCB;
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

        private void LKFMT_AB_Click(object sender, EventArgs e)
        {

        }

        private void FMT_DB_Click(object sender, EventArgs e)
        {

        }

        private void FMT_EB_Click(object sender, EventArgs e)
        {

        }

        private void FMT_AB_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
