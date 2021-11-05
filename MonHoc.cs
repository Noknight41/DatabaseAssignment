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
    public partial class MonHoc : Form
    {
        string Route;
        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-HK69CUKA\SQL1;AttachDbFilename=D:\My_Stuff\Database\Ass2\Assignment2\Database\Test.mdf;Integrated Security=True");
        public MonHoc()
        {
            this.Route = "";
            InitializeComponent();
            Con.Open();
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MH_FormClosed);
        }

        private void MonHoc_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void MH_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(this.Route == "")
            {
                return;
            }
            else
            {
                AdminUI UI = new AdminUI();
                UI.Show();
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if(MHID.Text == "" || MHN.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string query = "INSERT INTO MON_HOC values('" + MMH.Text +"', '" + MHN.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Add Mon_Hoc successfully");
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        private void populate()
        {
            string query = "SELECT * FROM MON_HOC";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ViewMonHoc.DataSource = ds.Tables[0];
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Con.Close();
            this.Route = "Return";
            this.Close();
        }

        private void Edit_Click(object sender, EventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

        }

        private void ViewMonHoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
