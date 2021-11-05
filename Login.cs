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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(User.SelectedItem == null)
            {
                Application.Exit();
                return;
            }
            if (User.SelectedItem.ToString() == "Admin")
            {
                AdminUI UI = new AdminUI();
                UI.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (User.SelectedItem == null)
            {
                return;
            }
            else this.Close();
        }
    }
}
