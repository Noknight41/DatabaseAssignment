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
    public partial class SVUI : Form
    {
        string Route;
        string MSSV;
        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-HK69CUKA\SQL1;Initial Catalog=Ass2;User ID=SVLogin;Password=123");

        public SVUI()
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
    }
}
