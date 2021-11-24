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
    public partial class LDT : Form
    {
        string MDT;
        string MSSV;
        List<int> STT = new List<int>();
        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-HK69CUKA\SQL1;Initial Catalog=Ass2;Persist Security Info=True;User ID=SVLogin;Password=123");
        
        public LDT()
        {
            InitializeComponent();
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SV_FormClosed);
            Con.Open();
        }

        public void setLDT(string MDT, string MSSV)
        {
            this.MDT = MDT;
            this.MSSV = MSSV;
            MDTLabel.Text = MDT;
            string query = "SELECT * FROM socauhoiDT('" + MDT + "') ORDER BY STTCH;";
            SqlCommand cmd1 = new SqlCommand(query, Con);
            SqlDataReader dr = null;
            using (dr = cmd1.ExecuteReader())
            {
                while (dr.Read())
                {
                    STTCB.Items.Add((int)dr["STTCH"]);
                    STT.Add((int)dr["STTCH"]);
                };
            };
        }

        private void SV_FormClosed(object sender, FormClosedEventArgs e)
        {
            SV UI = new SV();
            UI.setSV(MSSV);
            UI.Show();
        }

        private string getCH(string MCH)
        {
            string result = "Error";
            try
            {
                string PCH = "Error";
                string PMTC = "";
                string CDR = "";
                List<int> DAP = new List<int>();
                string query1 = "SELECT * FROM CH1('" + MCH + "');";
                string query2 = "SELECT * FROM CHDA('" + MCH + "') ORDER BY STT;";
                SqlCommand cmd1 = new SqlCommand(query1, Con);
                SqlCommand cmd2 = new SqlCommand(query2, Con);
                SqlDataReader dr = null;
                string[] da = new string[5] { "A. ", "B. ", "C. ", "D. ", "E. " };
                using (dr = cmd1.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        if (!String.IsNullOrEmpty(dr["PMTC"].ToString()))
                        {
                            PMTC = "PMTC: " + (string)dr["PMTC"] + "\n";
                        }
                        result = PMTC;
                        CDR = "[" + (string)dr["MMH"] + "." + (int)dr["STTCDR"] + "]\n";
                        result = result + CDR;
                        PCH = "Question: " + (string)dr["PCH"] + "\n";
                        result = result + PCH;
                    };
                };
                string query3 = "SELECT * FROM FMTPCH('" + MCH + "');";
                SqlCommand cmd3 = new SqlCommand(query3, Con);
                using (dr = cmd3.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        result = result + "+ " + (string)dr["URL_hinh_anh"] + "\n";
                    };
                };
                using (dr = cmd2.ExecuteReader())
                {
                    int i = 0;
                    while (dr.Read())
                    {
                        string DA = (string)dr["Noi_dung"];
                        da[i] = "   " + da[i] + DA;
                        DAP.Add((int)dr["STT"]);
                        i++;
                    };
                };
                int j = 0;
                foreach (int d in DAP)
                {
                    string query4 = "SELECT * FROM FMTPTL('" + MCH + "', " + d + ");";
                    SqlCommand cmd4 = new SqlCommand(query4, Con);
                    result = result + da[j];
                    using (dr = cmd4.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            result = result + " (" + (string)dr["URL_hinh_anh"] + ")";
                        };
                    };
                    result = result + "\n";
                    j = j + 1;
                }
                dr.Close();
                return result;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                return result;
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void XCH_B_Click(object sender, EventArgs e)
        {
            string STTCH = STTCB.SelectedItem.ToString();
            string MCH = "";
            int DA = 0;
            string query = "SELECT * FROM DE_THI_BAO_GOM_CAU_HOI WHERE Ma_de_thi = '" + MDT + "' AND STTCH = " + STTCH + "";
            string query1 = "SELECT Tra_loi FROM LAM_BAI WHERE Ma_de_thi = '" + MDT + "' AND STTCH = " + STTCH + " AND MSSV = '"+MSSV+"'";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlCommand cmd1 = new SqlCommand(query1, Con);
            SqlDataReader dr = null;
            using (dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    MCH = (string)dr["Ma_cau_hoi"];
                };
            };
            using (dr = cmd1.ExecuteReader())
            {
                while (dr.Read())
                {
                    DA = (int)dr["Tra_loi"];
                };
            };
            dr.Close();
            CHTextArea.Text = getCH(MCH);
            NTL.Text = "" + DA + "";
        }

        private void NTL_B_Click(object sender, EventArgs e)
        {
            if (NTL.Text != "1" && NTL.Text != "2" && NTL.Text != "3" && NTL.Text != "4" && NTL.Text != "5")
            {
                MessageBox.Show("Answer is not in the format 1 2 3 4 5");
            }
            else
            {
                try
                {
                    string query = "UPDATE LAM_BAI SET Tra_loi = '" + NTL.Text + "' WHERE Ma_de_thi = '" + MDT + "' AND MSSV = '" + MSSV + "' AND STTCH = "+STTCB.SelectedItem.ToString()+";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
    }
}
