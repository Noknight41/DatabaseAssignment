using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class AdminUI : Form
    {
        string Route;
        public AdminUI()
        {
            Route = "";
            InitializeComponent();
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Admin_FormClosed);
        }

        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(this.Route == "")
            {
                return;
            }
            if(this.Route == "Login")
            {
                Login UI = new Login();
                UI.Show();
            }
            if (this.Route == "MonHoc")
            {
                MonHoc UI = new MonHoc();
                UI.Show();
            }
            if (this.Route == "CDR")
            {
                ChuanDauRa UI = new ChuanDauRa();
                UI.Show();
            }
            if (this.Route == "GVPT")
            {
                GVPT UI = new GVPT();
                UI.Show();
            }
            if (this.Route == "LT")
            {
                LanThi UI = new LanThi();
                UI.Show();
            }
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            this.Route = "Login";
            this.Close();
        }

        private void MHbutton_Click(object sender, EventArgs e)
        {
            this.Route = "MonHoc";
            this.Close();
        }

        private void CDRbutton_Click(object sender, EventArgs e)
        {
            this.Route = "CDR";
            this.Close();
        }

        private void GVPTbutton_Click(object sender, EventArgs e)
        {
            this.Route = "GVPT";
            this.Close();
        }

        private void LTbutton_Click(object sender, EventArgs e)
        {
            this.Route = "LT";
            this.Close();
        }
    }
}
