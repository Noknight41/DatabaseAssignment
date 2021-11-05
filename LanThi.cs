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
    public partial class LanThi : Form
    {
        string Route;
        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-HK69CUKA\SQL1;Initial Catalog=Assignment2;Integrated Security=True");
        public LanThi()
        {
            this.Route = "";
            InitializeComponent();
            Con.Open();
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Lanthi_FormClosed);
        }

        private void Lanthi_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.Route == "")
            {
                Application.Exit();
                return;
            }
            else
            {
                AdminUI UI = new AdminUI();
                UI.Show();
            }
        }

        private void LanThi_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void populate()
        {
            string query = "SELECT * FROM LAN_THI";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ViewLT.DataSource = ds.Tables[0];
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (LT.Text == "" || HK.Text == "" || NH.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string query = "INSERT INTO LAN_THI values(" + LT.Text + ", '" + HK.Text + "', " + NH.Text + ")";
                    MessageBox.Show(query);
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (LT.Text == "" || HK.Text == "" || NH.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string query = "UPDATE LAN_THI SET Hoc_ky = '" + HK.Text + "', Nam_hoc = " + NH.Text + " WHERE Lan_thi = " + LT.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (LT.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string query = "DELETE FROM LAN_THI WHERE Lan_thi = " + LT.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Con.Close();
            this.Route = "Return";
            this.Close();
        }

        private void ViewLT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex; // get the selected Row Index
            DataGridViewRow row = ViewLT.Rows[indexRow];
            LT.Text = row.Cells[0].Value.ToString();
            HK.Text = row.Cells[1].Value.ToString();
            NH.Text = row.Cells[2].Value.ToString();
        }
    }
}
