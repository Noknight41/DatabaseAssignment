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
    public partial class Login : Form
    {
        SqlConnection Con;
        string MSCB;
        string MSSV;
        string MMH;
        public Login()
        {
            InitializeComponent();
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            Con = new SqlConnection(@"Data Source=LAPTOP-HK69CUKA\SQL1;Initial Catalog=Ass2;Persist Security Info=True;User ID=MyLogin;Password=123");
            Con.Open();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Con.Close();
            if (User.SelectedItem == null)
            {
                Application.Exit();
                return;
            }
            if (User.SelectedItem.ToString() == "Admin")
            {
                AdminUI UI = new AdminUI();
                UI.Show();
            }
            if(User.SelectedItem.ToString() == "GVPT")
            {
                ViewXDT UI = new ViewXDT();
                UI.setGVPT(MSCB, MMH);
                UI.Show();
            }
            if (User.SelectedItem.ToString() == "GVQL")
            {
                GVQLUI UI = new GVQLUI();
                UI.setGVQL(MSCB, MMH);
                UI.Show();
            }
            if (User.SelectedItem.ToString() == "SV")
            {
                SV UI = new SV();
                UI.setSV(MSSV);
                UI.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (User.SelectedItem == null)
            {
                return;
            }
            if(User.SelectedItem.ToString() == "GVPT")
            {
                SqlCommand check_GVPT = new SqlCommand("SELECT * FROM GIANG_VIEN_PHU_TRACH WHERE ([MSCB] = @mscb AND [Pass] = @pw)", Con);
                check_GVPT.Parameters.AddWithValue("@mscb", ID.Text);
                check_GVPT.Parameters.AddWithValue("@pw", pw.Text);
                SqlDataReader reader = check_GVPT.ExecuteReader();
                if (reader.HasRows)
                {
                    //User Exists
                    reader.Read();
                    MSCB = ID.Text;
                    MMH = reader.GetString(1);
                }
                else
                {
                    //User NOT Exists
                    MessageBox.Show("Not Found");
                    reader.Close();
                    reader.Dispose();
                    return;
                }
                reader.Close();
                reader.Dispose();
            }
            if (User.SelectedItem.ToString() == "GVQL")
            {
                SqlCommand check_GVQL = new SqlCommand("SELECT * FROM GIANG_VIEN_QUAN_LY WHERE ([MSCB] = @mscb AND [Pass] = @pw)", Con);
                check_GVQL.Parameters.AddWithValue("@mscb", ID.Text);
                check_GVQL.Parameters.AddWithValue("@pw", pw.Text);
                SqlDataReader reader = check_GVQL.ExecuteReader();
                if (reader.HasRows)
                {
                    //User Exists
                    reader.Read();
                    MSCB = ID.Text;
                    MMH = reader.GetString(1);
                }
                else
                {
                    //User NOT Exists
                    MessageBox.Show("Not Found");
                    reader.Close();
                    reader.Dispose();
                    return;
                }
                reader.Close();
                reader.Dispose();
            }
            if (User.SelectedItem.ToString() == "SV")
            {
                SqlCommand check_SV = new SqlCommand("SELECT * FROM SINH_VIEN WHERE ([MSSV] = @mssv AND [Pass] = @pw)", Con);
                check_SV.Parameters.AddWithValue("@mssv", ID.Text);
                check_SV.Parameters.AddWithValue("@pw", pw.Text);
                SqlDataReader reader = check_SV.ExecuteReader();
                if (reader.HasRows)
                {
                    //User Exists
                    reader.Read();
                    MSSV = ID.Text;
                }
                else
                {
                    //User NOT Exists
                    MessageBox.Show("Not Found");
                    reader.Close();
                    reader.Dispose();
                    return;
                }
                reader.Close();
                reader.Dispose();
            }
            this.Close();
        }
    }
}
