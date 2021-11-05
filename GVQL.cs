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
    public partial class GVQL : Form
    {
        string Route;
        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-HK69CUKA\SQL1;Initial Catalog=Assignment2;Integrated Security=True");
        public GVQL()
        {
            this.Route = "";
            InitializeComponent();
            Con.Open();
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GVQL_FormClosed);
        }

        private void GVQL_FormClosed(object sender, FormClosedEventArgs e)
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

        private void GVQL_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void populate()
        {
            string query = "SELECT * FROM GIANG_VIEN_QUAN_LY";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ViewGVQL.DataSource = ds.Tables[0];
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (MMH.Text == "" || MSCB.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string query = "INSERT INTO GIANG_VIEN_QUAN_LY values('" + MSCB.Text + "', '" + MMH.Text + "')";
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

        private void Edit_Click(object sender, EventArgs e)
        {
            if (MMH.Text == "" || MSCB.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string query = "UPDATE GIANG_VIEN_QUAN_LY SET Mon_hoc_quan_ly = '" + MMH.Text + "' WHERE MSCB = '" + MSCB.Text + "';";
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
            if (MSCB.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string query = "DELETE FROM GIANG_VIEN_QUAN_LY WHERE MSCB = '" + MSCB.Text + "';";
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

        private void ViewGVQL_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex; // get the selected Row Index
            DataGridViewRow row = ViewGVQL.Rows[indexRow];
            MSCB.Text = row.Cells[0].Value.ToString();
            MMH.Text = row.Cells[1].Value.ToString();
        }
    }
}
