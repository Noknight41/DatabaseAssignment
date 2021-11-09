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
        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-HK69CUKA\SQL1;Initial Catalog=Assignment2;Integrated Security=True");
       
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

        private void LT_AB_Click(object sender, EventArgs e)
        {

        }
    }
}
