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
    public partial class XDT : Form
    {
        string MDT;
        string MSCB;
        string MMH;
        string User;
        string Route = "";
        List<int> STT = new List<int>();
        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-HK69CUKA\SQL1;Initial Catalog=Ass2;Persist Security Info=True;User ID=MyLogin;Password=123");
        

        public XDT()
        {
            InitializeComponent();
            Con.Open();
        }

        public void setDTGVPT(string MDT, string MSCB, string MMH)
        {
            this.MDT = MDT;
            MDTLabel.Text = MDT;
            User = "GVPT";
            this.MSCB = MSCB;
            this.MMH = MMH;
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

        private void XCH_B_Click(object sender, EventArgs e)
        {
            string STTCH = STTCB.SelectedItem.ToString();
            string MCH = "";
            string query = "SELECT * FROM DE_THI_BAO_GOM_CAU_HOI WHERE Ma_de_thi = '"+MDT+"' AND STTCH = "+STTCH+"";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader dr = null;
            using (dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    MCH = (string)dr["Ma_cau_hoi"];
                };
            };
            dr.Close();
            CHTextArea.Text = getCH(MCH);
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

        private void XDT_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.Route == "")
            {
                Application.Exit();
                return;
            }
            if (this.Route == "GVPT")
            {
                ViewXDT UI = new ViewXDT();
                UI.setGVPT(MSCB, MMH);
                UI.Show();
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            if(this.User == "GVPT")
            {
                this.Route = "GVPT";
                Con.Close();
                this.Close();
            }
        }

        
    }
}
