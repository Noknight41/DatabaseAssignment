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
    public partial class ChuanDauRa : Form
    {
        string Route;
        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-HK69CUKA\SQL1;Initial Catalog=Assignment2;Integrated Security=True");
        public ChuanDauRa()
        {
            this.Route = "";
            InitializeComponent();
            Con.Open();
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CDR_FormClosed);
        }

        private void CDR_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void CDR_FormClosed(object sender, FormClosedEventArgs e)
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

        private void populate()
        {
            string query = "SELECT * FROM CHUAN_DAU_RA";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ViewCDR.DataSource = ds.Tables[0];
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (MMH.Text == "" || STT.Text == "" || CDRName.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string query = "INSERT INTO CHUAN_DAU_RA values(" + STT.Text + ",'" + CDRName.Text + "', '" + MMH.Text + "')";
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

        private void Edit_Click(object sender, EventArgs e)
        {
            if (MMH.Text == "" || STT.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string query = "UPDATE CHUAN_DAU_RA SET Ten = '" + CDRName.Text + "' WHERE Ma_mon_hoc_thuoc = '" + MMH.Text + "' AND STT = '" + STT.Text + "';";
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
            if (MMH.Text == "" || STT.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string query = "DELETE FROM CHUAN_DAU_RA WHERE STT = " + STT.Text +  " AND Ma_mon_hoc = '" + MMH.Text + "';";
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

        private void ViewMonHoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex; // get the selected Row Index
            DataGridViewRow row = ViewCDR.Rows[indexRow];
            STT.Text = row.Cells[0].Value.ToString();
            MMH.Text = row.Cells[2].Value.ToString();
            CDRName.Text = row.Cells[1].Value.ToString();
        }
    }
}
