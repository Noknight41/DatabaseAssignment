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
    public partial class AdminUI : Form
    {
        string Route;
        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-HK69CUKA\SQL1;Initial Catalog=Ass2;User ID=MyLogin;Password=123");
        public AdminUI()
        {
            Route = "";
            InitializeComponent();
            Con.Open();
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Admin_FormClosed);
        }

        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(this.Route == "")
            {
                Application.Exit();
                return;
            }
            if(this.Route == "Login")
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

        private void tabPage1_Click(object sender, EventArgs e)
        {
            switch (AdminControl.SelectedIndex)
            {
                case 0:
                {
                    MHpopulate();
                    break;
                }
                case 1:
                {
                    GVPTpopulate();
                    break;
                }
                case 2:
                {
                    GVQLpopulate();
                    break;
                }
                case 3:
                {
                    CDRpopulate();
                    break;
                }
                case 4:
                {
                    LTpopulate();
                    break;
                }
                case 5:
                {
                    SVpopulate();
                    break;
                }
            }
            
        }

        private void MHpopulate()
        {
            string query = "SELECT * FROM MON_HOC";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ViewMonHoc.DataSource = ds.Tables[0];
        }

        private void GVPTpopulate()
        {
            string query = "SELECT * FROM GIANG_VIEN_PHU_TRACH";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ViewGVPT.DataSource = ds.Tables[0];
        }

        private void GVQLpopulate()
        {
            string query = "SELECT * FROM GIANG_VIEN_QUAN_LY";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ViewGVQL.DataSource = ds.Tables[0];
        }

        private void CDRpopulate()
        {
            string query = "SELECT * FROM CHUAN_DAU_RA";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ViewCDR.DataSource = ds.Tables[0];
        }

        private void LTpopulate()
        {
            string query = "SELECT * FROM LAN_THI";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ViewLT.DataSource = ds.Tables[0];
        }

        private void SVpopulate()
        {
            string query = "SELECT * FROM SINH_VIEN";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ViewSV.DataSource = ds.Tables[0];
        }

        private void MHAddButton_Click(object sender, EventArgs e)
        {
            if (MH_MMH.Text == "" || MH_MHN.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string query = "INSERT INTO MON_HOC values('" + MH_MMH.Text + "', '" + MH_MHN.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MHpopulate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void MHEditButton_Click(object sender, EventArgs e)
        {
            if (MH_MMH.Text == "" || MH_MHN.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string query = "UPDATE MON_HOC SET Ten = '" + MH_MHN.Text + "' WHERE Ma_mon_hoc = '" + MH_MMH.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MHpopulate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void MHDeleteButton_Click(object sender, EventArgs e)
        {
            if (MH_MMH.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string query = "DELETE FROM MON_HOC WHERE Ma_mon_hoc = '" + MH_MMH.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MHpopulate();
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
            DataGridViewRow row = ViewMonHoc.Rows[indexRow];
            MH_MMH.Text = row.Cells[0].Value.ToString();
            MH_MHN.Text = row.Cells[1].Value.ToString();
        }

        private void GVPT_AddButton_Click(object sender, EventArgs e)
        {
            if (GVPT_MMH.Text == "" || GVPT_MSCB.Text == "" || pwGVPT.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string query = "INSERT INTO GIANG_VIEN_PHU_TRACH values('" + GVPT_MSCB.Text + "', '" + GVPT_MMH.Text + "', '" + pwGVPT.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    GVPTpopulate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void GVPT_DeleteButton_Click(object sender, EventArgs e)
        {
            if (GVPT_MSCB.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string query = "DELETE FROM GIANG_VIEN_PHU_TRACH WHERE MSCB = '" + GVPT_MSCB.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    GVPTpopulate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void GVPT_EditButton_Click(object sender, EventArgs e)
        {
            if (GVPT_MMH.Text == "" || GVPT_MSCB.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string query = "UPDATE GIANG_VIEN_PHU_TRACH SET Mon_hoc_phu_trach = '" + GVPT_MMH.Text + "', Pass = '" + pwGVPT.Text + "' WHERE MSCB = '" + GVPT_MSCB.Text + "';";
                    MessageBox.Show(query);
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    GVPTpopulate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void ViewGVPT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex; // get the selected Row Index
            DataGridViewRow row = ViewGVPT.Rows[indexRow];
            GVPT_MMH.Text = row.Cells[1].Value.ToString();
            GVPT_MSCB.Text = row.Cells[0].Value.ToString();
            pwGVPT.Text = row.Cells[2].Value.ToString();
        }

        private void GVQL_AB_Click(object sender, EventArgs e)
        {
            if (GVQL_MMH.Text == "" || GVQL_MSCB.Text == "" || pwGVQL.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string query = "INSERT INTO GIANG_VIEN_QUAN_LY values('" + GVQL_MSCB.Text + "', '" + GVQL_MMH.Text + "', '" + pwGVQL.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    GVQLpopulate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void GVQL_EB_Click(object sender, EventArgs e)
        {
            if (GVQL_MMH.Text == "" || GVQL_MSCB.Text == "" || pwGVQL.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string query = "UPDATE GIANG_VIEN_QUAN_LY SET Mon_hoc_quan_ly = '" + GVQL_MMH.Text + "', Pass = '" + pwGVQL.Text + "' WHERE MSCB = '" + GVQL_MSCB.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    GVQLpopulate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void GVQL_DB_Click(object sender, EventArgs e)
        {
            if (GVQL_MSCB.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string query = "DELETE FROM GIANG_VIEN_QUAN_LY WHERE MSCB = '" + GVQL_MSCB.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    GVQLpopulate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void ViewGVQL_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex; // get the selected Row Index
            DataGridViewRow row = ViewGVQL.Rows[indexRow];
            GVQL_MSCB.Text = row.Cells[0].Value.ToString();
            GVQL_MMH.Text = row.Cells[1].Value.ToString();
            pwGVQL.Text = row.Cells[2].Value.ToString();
        }

        //Chuan dau ra
        private void CDR_AB_Click(object sender, EventArgs e)
        {
            if (CDR_MMH.Text == "" || CDR_STT.Text == "" || CDRName.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string query = "INSERT INTO CHUAN_DAU_RA values(" + CDR_STT.Text + ",'" + CDRName.Text + "', '" + CDR_MMH.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    CDRpopulate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void CDR_EB_Click(object sender, EventArgs e)
        {
            if (CDR_MMH.Text == "" || CDR_STT.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string query = "UPDATE CHUAN_DAU_RA SET Ten = '" + CDRName.Text + "' WHERE Ma_mon_hoc_thuoc = '" + CDR_MMH.Text + "' AND STT = '" + CDR_STT.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    CDRpopulate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void CDR_DB_Click(object sender, EventArgs e)
        {
            if (CDR_MMH.Text == "" || CDR_STT.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string query = "DELETE FROM CHUAN_DAU_RA WHERE STT = " + CDR_STT.Text + " AND Ma_mon_hoc = '" + CDR_MMH.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    CDRpopulate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void ViewCDR_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex; // get the selected Row Index
            DataGridViewRow row = ViewCDR.Rows[indexRow];
            CDR_STT.Text = row.Cells[0].Value.ToString();
            CDR_MMH.Text = row.Cells[2].Value.ToString();
            CDRName.Text = row.Cells[1].Value.ToString();
        }


        //Lan thi
        private void LT_AB_Click(object sender, EventArgs e)
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
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    LTpopulate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void LT_EB_Click(object sender, EventArgs e)
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
                    LTpopulate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void LT_DB_Click(object sender, EventArgs e)
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
                    LTpopulate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void ViewLT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex; // get the selected Row Index
            DataGridViewRow row = ViewLT.Rows[indexRow];
            LT.Text = row.Cells[0].Value.ToString();
            HK.Text = row.Cells[1].Value.ToString();
            NH.Text = row.Cells[2].Value.ToString();
        }


        //Sinh vien
        private void SV_AB_Click(object sender, EventArgs e)
        {
            if (SV_MSSV.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string query = "INSERT INTO SINH_VIEN values('" + SV_MSSV.Text + "', '" + pwSV.Text + "');";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    SVpopulate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void SV_EB_Click(object sender, EventArgs e)
        {
            if (SV_MSSV.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string query = "UPDATE SINH_VIEN SET Pass = '" + pwSV.Text + "' WHERE MSSV = '" + SV_MSSV.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    SVpopulate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void SV_DB_Click(object sender, EventArgs e)
        {
            if (SV_MSSV.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string query = "DELETE FROM SINH_VIEN WHERE MSSV = '" + SV_MSSV.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    SVpopulate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void ViewSV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex; // get the selected Row Index
            DataGridViewRow row = ViewSV.Rows[indexRow];
            SV_MSSV.Text = row.Cells[0].Value.ToString();
            pwSV.Text = row.Cells[1].Value.ToString();
        }

        
    }
}
