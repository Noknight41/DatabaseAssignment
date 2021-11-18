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
        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-HK69CUKA\SQL1;Initial Catalog=Ass2;Persist Security Info=True;User ID=MyLogin;Password=123");
       
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
            Masocanbo.Text = "MSCB: " + MSCB;
            Mamonhoc.Text = "MMH: " + MMH;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            switch (GVPTControl.SelectedTab.Name)
            {
                case "FMT":
                {
                   FMTpopulate();
                   break;
                }
                case "PMTC":
                {
                    PMTCpopulate();
                    break;
                }
                case "PCH":
                {
                   PCHpopulate();
                   break;
                }
                case "PTL":
                {
                    PTLpopulate();
                    break;
                }
                case "CH":
                {
                    CHpopulate();
                    break;
                }
                case "TDT":
                {
                    TDTpopulate();
                    break;
                }
                case "DT":
                {
                    DTpopulate();
                    break;
                }
                case "NDTDT":
                {
                    NDTDTpopulate();
                    break;
                }
                case "NDDT":
                {
                    NDDTpopulate();
                    break;
                }
                case "PMTCFMT":
                {
                    PMTCFMTpopulate();
                    break;
                }
                case "PCHFMT":
                {
                    PCHFMTpopulate();
                    break;
                }
                case "PTLFMT":
                {
                    PTLFMTpopulate();
                    break;
                }
                case "Password":
                {
                    PWpopulate();
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

        // Populate
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
            ViewFMTPCH.DataSource = ds.Tables[0];
        }

        private void PTLFMTpopulate()
        {
            string query = "SELECT * FROM PTL_CHUA_FMT";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ViewFMTPTL.DataSource = ds.Tables[0];
        }

        private void PMTCFMTpopulate()
        {
            string query = "SELECT * FROM PMTC_CHUA_FMT";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ViewFMTPMTC.DataSource = ds.Tables[0];
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

        private void PTLpopulate()
        {
            string query = "SELECT * FROM PHAN_TRA_LOI";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ViewPTL.DataSource = ds.Tables[0];
        }

        private void PMTCpopulate()
        {
            string query = "SELECT * FROM PHAN_MO_TA_CHUNG";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ViewPMTC.DataSource = ds.Tables[0];
        }

        private void CHpopulate()
        {
            string query = "SELECT * FROM CAU_HOI";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ViewCH.DataSource = ds.Tables[0];
        }

        private void TDTpopulate()
        {
            string query = "SELECT * FROM TAP_DE_THI";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ViewTDT.DataSource = ds.Tables[0];
        }

        private void DTpopulate()
        {
            string query = "SELECT * FROM DE_THI";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ViewDT.DataSource = ds.Tables[0];
        }

        private void NDTDTpopulate()
        {
            string query = "SELECT * FROM TAP_DE_THI_BAO_GOM_CAU_HOI";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ViewNDTDT.DataSource = ds.Tables[0];
        }

        private void NDDTpopulate()
        {
            string query = "SELECT * FROM DE_THI_BAO_GOM_CAU_HOI";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ViewNDDT.DataSource = ds.Tables[0];
        }

        private void PWpopulate()
        {
            string query = "SELECT dbo.PassGVPT('"+ MSCB + "');";
            using (var cmd = new SqlCommand(query, Con))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    PW.Text = reader.GetString(0);
                    reader.Close();
                    return;
                }
                reader.Close();
            }
        }

        // Each Tab
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

        // Phan mo ta chung
        private void PMTC_AB_Click(object sender, EventArgs e)
        {
            if (ID_PMTC.Text == "" || PMTC_ND.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string query = "INSERT INTO PHAN_MO_TA_CHUNG values('" + ID_PMTC.Text + "', '" + PMTC_ND.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    PMTCpopulate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void PMTC_EB_Click(object sender, EventArgs e)
        {
            if (ID_PMTC.Text == "" || PMTC_ND.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string query = "UPDATE PHAN_MO_TA_CHUNG SET Noi_dung = '" + PMTC_ND.Text + "' WHERE ID_phan_mo_ta = '" + ID_PMTC.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    PMTCpopulate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void PMTC_DB_Click(object sender, EventArgs e)
        {
            if (ID_PMTC.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string query = "DELETE FROM PHAN_MO_TA_CHUNG WHERE ID_FMT = '" + ID_PMTC.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    PMTCpopulate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        // Phan cau hoi
        private void PCH_AB_Click(object sender, EventArgs e)
        {
            if (PCHMCH.Text == "" || PCHND.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string query = "INSERT INTO PHAN_CAU_HOI values('" + PCHMCH.Text + "', '" + PCHND.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    PCHpopulate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void PCH_EB_Click(object sender, EventArgs e)
        {
            if (PCHMCH.Text == "" || PCHND.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string query = "UPDATE PHAN_CAU_HOI SET Noi_dung = '" + PCHND.Text + "' WHERE Ma_cau_hoi = '" + PCHMCH.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    PCHpopulate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void PCH_DB_Click(object sender, EventArgs e)
        {
            if (PCHMCH.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string query = "DELETE FROM PHAN_CAU_HOI WHERE Ma_cau_hoi = '" + PCHMCH.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    PCHpopulate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        // Phan tra loi
        private void PTL_AB_Click(object sender, EventArgs e)
        {
            if (PTLMCH.Text == "" || PTLND.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string query = "INSERT INTO PHAN_TRA_LOI values('" + PTLMCH.Text + "', " + PTLSTT.SelectedItem.ToString() + " ,'" + PTLND.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    PTLpopulate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void PTL_EB_Click(object sender, EventArgs e)
        {
            if (PTLMCH.Text == "" || PTLND.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string query = "UPDATE PHAN_TRA_LOI SET Noi_dung = '" + PTLND.Text + "' WHERE Ma_cau_hoi = '" + PTLMCH.Text + "' AND STT = " + PTLSTT.SelectedItem.ToString() + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    PTLpopulate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void PTL_DB_Click(object sender, EventArgs e)
        {
            if (PTLMCH.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string query = "DELETE FROM PHAN_TRA_LOI WHERE Ma_cau_hoi = '" + PTLMCH.Text + "' AND STT = " + PTLSTT.SelectedItem.ToString() + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    PTLpopulate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        // Cau hoi
        private void CH_AB_Click(object sender, EventArgs e)
        {
            if (CH_MCH.Text == "" || CH_CDR.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    DateTime thisDay = DateTime.Today;
                    string cdr;
                    if (CHIDPMTC.Text == "") cdr = "null";
                    else cdr = "'" + CHIDPMTC.Text + "'";
                    string query = "INSERT INTO CAU_HOI values('" + CH_MCH.Text + "', " + CHVTDA.SelectedItem.ToString() + " ,'" + MSCB + "', getdate(), '" + MMH + "', " + CHVTDA.SelectedItem.ToString() + ", " + cdr +")";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    CHpopulate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void CH_EB_Click(object sender, EventArgs e)
        {
            if (CH_MCH.Text == "" || CH_CDR.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string cdr;
                    if (CHIDPMTC.Text == "") cdr = "null";
                    else cdr = "'" + CHIDPMTC.Text + "'";
                    string query = "UPDATE CAU_HOI SET Vi_tri_dap_an_dung = " + CHVTDA.SelectedItem.ToString() + ", STTCDR = " + CH_CDR.Text +", ID_phan_mo_ta = " + cdr +"  WHERE Ma_cau_hoi = '" + CH_MCH.Text + "';";
                    Console.WriteLine(query);
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    CHpopulate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void CH_DB_Click(object sender, EventArgs e)
        {
            if (CH_MCH.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string query = "DELETE FROM CAU_HOI WHERE Ma_cau_hoi = '" + PTLMCH.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    CHpopulate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        // Tap de thi
        private void TDT_AB_Click(object sender, EventArgs e)
        {
            if (TDT_LT.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string query = "INSERT INTO TAP_DE_THI values('" + TDT_LT.Text + "', '" + MMH + "' ,'" + MSCB + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    TDTpopulate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void TDT_DB_Click(object sender, EventArgs e)
        {
            if (TDT_LT.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string query = "DELETE FROM TAP_DE_THI WHERE Ma_mon_hoc_TDT = '" + MMH + "' AND Lan_thi = '" + TDT_LT.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    TDTpopulate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        // De Thi
        private void DT_AB_Click(object sender, EventArgs e)
        {
            if (DT.Text == "" || NRD.Text == "" || DTLT.Text == "" || TLB.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string query = "INSERT INTO DE_THI(Ma_de_thi, Thoi_gian_lam_bai, Trich_Lan_thi, Trich_Mon_hoc, MSCB_ra_de, Ngay_xac_nhan_ra_de) values ('" + MDT.Text + "', " + TLB.Text + " , " + DTLT.Text + ", '" + MMH + "', '" + MSCB + "', '" + NRD.Text + "');";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    DTpopulate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void DT_EB_Click(object sender, EventArgs e)
        {
            if (DT.Text == "" || TLB.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string cdr;
                    if (CHIDPMTC.Text == "") cdr = "null";
                    else cdr = "'" + CHIDPMTC.Text + "'";
                    string query = "UPDATE DE_THI SET Thoi_gian_lam_bai = " + TLB.Text + " WHERE Ma_de_thi = '" + MDT.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    DTpopulate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void DT_DB_Click(object sender, EventArgs e)
        {
            if (MDT.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string query = "DELETE FROM DE_THI WHERE Ma_de_thi = '" + MDT.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    DTpopulate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        // Noi dung TDT
        private void TDTCH_AB_Click(object sender, EventArgs e)
        {
            if (NDTDTLT.Text == "" || TDT_MCH.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string query = "INSERT INTO TAP_DE_THI_BAO_GOM_CAU_HOI values(" + NDTDTLT.Text + ", '" + MMH + "' ,'" + TDT_MCH.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    Console.WriteLine(query);
                    cmd.ExecuteNonQuery();
                    NDTDTpopulate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void TDTCH_DB_Click(object sender, EventArgs e)
        {
            if (NDTDTLT.Text == "" || TDT_MCH.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string query = "DELETE FROM TAP_DE_THI_BAO_GOM_CAU_HOI WHERE Lan_thi = " + NDTDTLT.Text + " AND Ma_mon_hoc_TDT = '" + MMH + "' AND Ma_cau_hoi = '" + TDT_MCH.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    NDTDTpopulate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        // PMTC chua FMT
        private void PF_AB_Click(object sender, EventArgs e)
        {
            if (PMTC_ID.Text == "" || PMTCIDFMT.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string query = "INSERT INTO PMTC_CHUA_FMT values('" + PMTC_ID.Text + "', '" + PMTCIDFMT.Text + "')";
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

        private void PF_DB_Click(object sender, EventArgs e)
        {
            if (PMTC_ID.Text == "" || PMTCIDFMT.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string query = "DELETE FROM PMTC_CHUA_FMT WHERE ID_FMT = '" + PMTCIDFMT.Text + "' AND ID_phan_mo_ta = '" + PMTC_ID.Text + "';";
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

        // PCH chua FMT
        private void PCF_AB_Click(object sender, EventArgs e)
        {
            if (PCH_MCH.Text == "" || PCH_FMT.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string query = "INSERT INTO PCH_CHUA_FMT values('" + PCH_MCH.Text + "', '" + PCH_FMT.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    PCHFMTpopulate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void PCF_DB_Click(object sender, EventArgs e)
        {
            if (PCH_MCH.Text == "" || PCH_FMT.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string query = "DELETE FROM PCH_CHUA_FMT WHERE ID_FMT = '" + PCH_FMT.Text + "' AND Ma_cau_hoi = '" + PCH_MCH.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    PCHFMTpopulate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        // PTL chua FMT
        private void PTF_AB_Click(object sender, EventArgs e)
        {
            if (PTL_MCH.Text == "" || PTL_FMT.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string query = "INSERT INTO PTL_CHUA_FMT values('" + PTL_MCH.Text + "', " + PTL_STT.SelectedItem.ToString() + " ,'" + PTL_FMT.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    Console.WriteLine(query);
                    cmd.ExecuteNonQuery();
                    PTLFMTpopulate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void PTF_DB_Click(object sender, EventArgs e)
        {
            if (PTL_MCH.Text == "" || PTL_FMT.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string query = "DELETE FROM PTL_CHUA_FMT WHERE ID_FMT = '" + PTL_FMT.Text + "' AND STT = " + PTL_STT.SelectedItem.ToString() + " AND Ma_cau_hoi = '" + PTL_MCH.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    PTLFMTpopulate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        // Change password 
        private void PW_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "UPDATE GIANG_VIEN_PHU_TRACH SET Pass = '" + PW.Text + "' WHERE MSCB = '" + MSCB + "';";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                PWpopulate();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void DTCH_AB_Click(object sender, EventArgs e)
        {
            if (NDDTMDT.Text == "" || NDDTMCH.Text == "" || NDDTSTT.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string query = "INSERT INTO DE_THI_BAO_GOM_CAU_HOI values('" + NDDTMDT.Text + "', '" + NDDTMCH.Text + "' , " + NDDTSTT.Text + ")";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    NDDTpopulate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void DTCH_EB_Click(object sender, EventArgs e)
        {
            if (NDDTMDT.Text == "" || NDDTMCH.Text == "" || NDDTSTT.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string query = "UPDATE DE_THI_BAO_GOM_CAU_HOI SET Ma_cau_hoi = '" + NDDTMCH.Text + "' WHERE Ma_de_thi = '" + NDDTMDT.Text + "' AND STTCH = " + NDDTSTT.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    NDDTpopulate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void DTCH_DB_Click(object sender, EventArgs e)
        {
            if (NDDTMDT.Text == "" || NDDTSTT.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string query = "DELETE FROM DE_THI_BAO_GOM_CAU_HOI WHERE STTCH = " + NDDTSTT.Text + " AND Ma_de_thi = '" + NDDTMDT.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    NDDTpopulate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
    }
}
