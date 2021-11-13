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
        SqlConnection Con = new SqlConnection(@"Data Source=LEHOANGTHUYLINH\SQLEXPRESS;Initial Catalog=test3;Integrated Security=True");
       
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

        private void tabPage1_Click(object sender, EventArgs e)
        {
            switch (GVPTControl.SelectedIndex)
            {
                case 0:
                {
                   FMTpopulate();
                   break;
                }
                case 2:
                {
                   PCHpopulate();
                   break;
                }
            }
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

        private void FMTpopulate()
        {
            string query = "SELECT * FROM FILE_MO_TA";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ViewFMT.DataSource = ds.Tables[0];
        }

        private void PCHFMTpopulate()
        {
            string query = "SELECT * FROM PCH_CHUA_FMT";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ViewFMT.DataSource = ds.Tables[0];
        }

        private void PTLFMTpopulate()
        {
            string query = "SELECT * FROM PTL_CHUA_FMT";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ViewFMT.DataSource = ds.Tables[0];
        }

        private void PMTCFMTpopulate()
        {
            string query = "SELECT * FROM PMTC_CHUA_FMT";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ViewFMT.DataSource = ds.Tables[0];
        }

        private void PCHpopulate()
        {
            string query = "SELECT * FROM PHAN_CAU_HOI";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ViewPCH.DataSource = ds.Tables[0];
        }

        private void FMT_AB_Click(object sender, EventArgs e)
        {
            if (IDFMT.Text == "" || URL.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string query = "INSERT INTO FILE_MO_TA values('" + IDFMT.Text + "', '" + URL.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    FMTpopulate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void FMT_EB_Click(object sender, EventArgs e)
        {
            if (IDFMT.Text == "" || URL.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string query = "UPDATE FILE_MO_TA SET URL_hinh_anh = '" + URL.Text + "' WHERE ID_FMT = '" + IDFMT.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    FMTpopulate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void FMT_DB_Click(object sender, EventArgs e)
        {
            if (IDFMT.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string query = "DELETE FROM FILE_MO_TA WHERE ID_FMT = '" + IDFMT.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    FMTpopulate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void LKFMT_AB_Click(object sender, EventArgs e)
        {
            if (IDFMT.Text == "" || LKBox.SelectedItem == null || IDLK.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                if(LKBox.SelectedItem.ToString() == "PCH")
                {
                    try
                    {
                        string query = "INSERT INTO PCH_CHUA_FMT values('" + IDLK.Text + "', '" + IDFMT.Text + "')";
                        SqlCommand cmd = new SqlCommand(query, Con);
                        cmd.ExecuteNonQuery();
                        PCHFMTpopulate();
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message);
                    }
                }
                if (LKBox.SelectedItem.ToString() == "PTL")
                {
                    try
                    {
                        string query = "INSERT INTO PTL_CHUA_FMT values('" + IDLK.Text + "', " + STT.SelectedItem.ToString() + " ,'" + IDFMT.Text + "')";
                        SqlCommand cmd = new SqlCommand(query, Con);
                        cmd.ExecuteNonQuery();
                        PTLFMTpopulate();
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message);
                    }
                }
                if (LKBox.SelectedItem.ToString() == "PMTC")
                {
                    try
                    {
                        string query = "INSERT INTO PMTC_CHUA_FMT values('" + IDLK.Text + "', '" + IDFMT.Text + "')";
                        SqlCommand cmd = new SqlCommand(query, Con);
                        cmd.ExecuteNonQuery();
                        PMTCFMTpopulate();
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message);
                    }
                }

            }
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

        private void CH_Click(object sender, EventArgs e)
        {

        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {

        }

        private void DT_Click(object sender, EventArgs e)
        {

        }
    }
}
