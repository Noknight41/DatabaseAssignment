
namespace Assignment2
{
    partial class AdminUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AdminText = new System.Windows.Forms.Label();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.AdminControl = new System.Windows.Forms.TabControl();
            this.MonHoc = new System.Windows.Forms.TabPage();
            this.MH_DB = new System.Windows.Forms.Button();
            this.MH_EB = new System.Windows.Forms.Button();
            this.MH_AB = new System.Windows.Forms.Button();
            this.ViewMonHoc = new System.Windows.Forms.DataGridView();
            this.MH_MHN = new System.Windows.Forms.TextBox();
            this.MHname = new System.Windows.Forms.Label();
            this.MH_MMH = new System.Windows.Forms.TextBox();
            this.MHID = new System.Windows.Forms.Label();
            this.GVPT = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.ViewGVPT = new System.Windows.Forms.DataGridView();
            this.GVPT_MSCB = new System.Windows.Forms.TextBox();
            this.Masocanbo = new System.Windows.Forms.Label();
            this.GVPT_MMH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GVQL = new System.Windows.Forms.TabPage();
            this.GVQL_DB = new System.Windows.Forms.Button();
            this.GVQL_EB = new System.Windows.Forms.Button();
            this.GVQL_AB = new System.Windows.Forms.Button();
            this.ViewGVQL = new System.Windows.Forms.DataGridView();
            this.GVQL_MSCB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.GVQL_MMH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CDR = new System.Windows.Forms.TabPage();
            this.ViewCDR = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.CDR_DB = new System.Windows.Forms.Button();
            this.CDR_MMH = new System.Windows.Forms.TextBox();
            this.CDR_EB = new System.Windows.Forms.Button();
            this.Sothutu = new System.Windows.Forms.Label();
            this.CDR_AB = new System.Windows.Forms.Button();
            this.CDR_STT = new System.Windows.Forms.TextBox();
            this.CDRName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LTTab = new System.Windows.Forms.TabPage();
            this.SV = new System.Windows.Forms.TabPage();
            this.NH = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.HK = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.LT = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ViewLT = new System.Windows.Forms.DataGridView();
            this.LT_DB = new System.Windows.Forms.Button();
            this.LT_EB = new System.Windows.Forms.Button();
            this.LT_AB = new System.Windows.Forms.Button();
            this.ViewSV = new System.Windows.Forms.DataGridView();
            this.SV_MSSV = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SV_DB = new System.Windows.Forms.Button();
            this.SV_AB = new System.Windows.Forms.Button();
            this.AdminControl.SuspendLayout();
            this.MonHoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewMonHoc)).BeginInit();
            this.GVPT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewGVPT)).BeginInit();
            this.GVQL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewGVQL)).BeginInit();
            this.CDR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewCDR)).BeginInit();
            this.LTTab.SuspendLayout();
            this.SV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewLT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewSV)).BeginInit();
            this.SuspendLayout();
            // 
            // AdminText
            // 
            this.AdminText.AutoSize = true;
            this.AdminText.Font = new System.Drawing.Font("Arial Black", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AdminText.Location = new System.Drawing.Point(12, 13);
            this.AdminText.Name = "AdminText";
            this.AdminText.Size = new System.Drawing.Size(154, 54);
            this.AdminText.TabIndex = 12;
            this.AdminText.Text = "Admin";
            // 
            // LogOutButton
            // 
            this.LogOutButton.Location = new System.Drawing.Point(646, 22);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(124, 54);
            this.LogOutButton.TabIndex = 12;
            this.LogOutButton.Text = "Log Out";
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // AdminControl
            // 
            this.AdminControl.Controls.Add(this.MonHoc);
            this.AdminControl.Controls.Add(this.GVPT);
            this.AdminControl.Controls.Add(this.GVQL);
            this.AdminControl.Controls.Add(this.CDR);
            this.AdminControl.Controls.Add(this.LTTab);
            this.AdminControl.Controls.Add(this.SV);
            this.AdminControl.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminControl.Location = new System.Drawing.Point(0, 82);
            this.AdminControl.Name = "AdminControl";
            this.AdminControl.SelectedIndex = 0;
            this.AdminControl.Size = new System.Drawing.Size(796, 461);
            this.AdminControl.TabIndex = 13;
            this.AdminControl.SelectedIndexChanged += new System.EventHandler(this.tabPage1_Click);
            // 
            // MonHoc
            // 
            this.MonHoc.Controls.Add(this.MH_DB);
            this.MonHoc.Controls.Add(this.MH_EB);
            this.MonHoc.Controls.Add(this.MH_AB);
            this.MonHoc.Controls.Add(this.ViewMonHoc);
            this.MonHoc.Controls.Add(this.MH_MHN);
            this.MonHoc.Controls.Add(this.MHname);
            this.MonHoc.Controls.Add(this.MH_MMH);
            this.MonHoc.Controls.Add(this.MHID);
            this.MonHoc.Location = new System.Drawing.Point(4, 40);
            this.MonHoc.Name = "MonHoc";
            this.MonHoc.Padding = new System.Windows.Forms.Padding(3);
            this.MonHoc.Size = new System.Drawing.Size(788, 417);
            this.MonHoc.TabIndex = 0;
            this.MonHoc.Text = "MonHoc";
            this.MonHoc.UseVisualStyleBackColor = true;
            this.MonHoc.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // MH_DB
            // 
            this.MH_DB.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MH_DB.Location = new System.Drawing.Point(33, 346);
            this.MH_DB.Name = "MH_DB";
            this.MH_DB.Size = new System.Drawing.Size(84, 34);
            this.MH_DB.TabIndex = 29;
            this.MH_DB.Text = "Delete";
            this.MH_DB.UseVisualStyleBackColor = true;
            this.MH_DB.Click += new System.EventHandler(this.MHDeleteButton_Click);
            // 
            // MH_EB
            // 
            this.MH_EB.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MH_EB.Location = new System.Drawing.Point(161, 272);
            this.MH_EB.Name = "MH_EB";
            this.MH_EB.Size = new System.Drawing.Size(84, 34);
            this.MH_EB.TabIndex = 28;
            this.MH_EB.Text = "Edit";
            this.MH_EB.UseVisualStyleBackColor = true;
            this.MH_EB.Click += new System.EventHandler(this.MHEditButton_Click);
            // 
            // MH_AB
            // 
            this.MH_AB.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MH_AB.Location = new System.Drawing.Point(33, 272);
            this.MH_AB.Name = "MH_AB";
            this.MH_AB.Size = new System.Drawing.Size(84, 34);
            this.MH_AB.TabIndex = 27;
            this.MH_AB.Text = "Add";
            this.MH_AB.UseVisualStyleBackColor = true;
            this.MH_AB.Click += new System.EventHandler(this.MHAddButton_Click);
            // 
            // ViewMonHoc
            // 
            this.ViewMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewMonHoc.Location = new System.Drawing.Point(308, 22);
            this.ViewMonHoc.Name = "ViewMonHoc";
            this.ViewMonHoc.RowHeadersWidth = 51;
            this.ViewMonHoc.RowTemplate.Height = 24;
            this.ViewMonHoc.Size = new System.Drawing.Size(458, 378);
            this.ViewMonHoc.TabIndex = 14;
            this.ViewMonHoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ViewMonHoc_CellContentClick);
            // 
            // MH_MHN
            // 
            this.MH_MHN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MH_MHN.Location = new System.Drawing.Point(33, 144);
            this.MH_MHN.Name = "MH_MHN";
            this.MH_MHN.Size = new System.Drawing.Size(212, 27);
            this.MH_MHN.TabIndex = 17;
            // 
            // MHname
            // 
            this.MHname.AutoSize = true;
            this.MHname.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MHname.Location = new System.Drawing.Point(29, 104);
            this.MHname.Name = "MHname";
            this.MHname.Size = new System.Drawing.Size(123, 23);
            this.MHname.TabIndex = 16;
            this.MHname.Text = "Tên môn học";
            // 
            // MH_MMH
            // 
            this.MH_MMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MH_MMH.Location = new System.Drawing.Point(33, 48);
            this.MH_MMH.Name = "MH_MMH";
            this.MH_MMH.Size = new System.Drawing.Size(212, 27);
            this.MH_MMH.TabIndex = 15;
            // 
            // MHID
            // 
            this.MHID.AutoSize = true;
            this.MHID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MHID.Location = new System.Drawing.Point(29, 13);
            this.MHID.Name = "MHID";
            this.MHID.Size = new System.Drawing.Size(118, 23);
            this.MHID.TabIndex = 14;
            this.MHID.Text = "Mã môn học";
            // 
            // GVPT
            // 
            this.GVPT.Controls.Add(this.button4);
            this.GVPT.Controls.Add(this.button5);
            this.GVPT.Controls.Add(this.button6);
            this.GVPT.Controls.Add(this.ViewGVPT);
            this.GVPT.Controls.Add(this.GVPT_MSCB);
            this.GVPT.Controls.Add(this.Masocanbo);
            this.GVPT.Controls.Add(this.GVPT_MMH);
            this.GVPT.Controls.Add(this.label1);
            this.GVPT.Location = new System.Drawing.Point(4, 40);
            this.GVPT.Name = "GVPT";
            this.GVPT.Padding = new System.Windows.Forms.Padding(3);
            this.GVPT.Size = new System.Drawing.Size(788, 417);
            this.GVPT.TabIndex = 1;
            this.GVPT.Text = "GVPT";
            this.GVPT.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(34, 357);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 34);
            this.button4.TabIndex = 30;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.GVPT_DeleteButton_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(163, 283);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(84, 34);
            this.button5.TabIndex = 29;
            this.button5.Text = "Edit";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.GVPT_EditButton_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(34, 283);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(84, 34);
            this.button6.TabIndex = 28;
            this.button6.Text = "Add";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.GVPT_AddButton_Click);
            // 
            // ViewGVPT
            // 
            this.ViewGVPT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewGVPT.Location = new System.Drawing.Point(308, 25);
            this.ViewGVPT.Name = "ViewGVPT";
            this.ViewGVPT.RowHeadersWidth = 51;
            this.ViewGVPT.RowTemplate.Height = 24;
            this.ViewGVPT.Size = new System.Drawing.Size(458, 376);
            this.ViewGVPT.TabIndex = 27;
            this.ViewGVPT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ViewGVPT_CellContentClick);
            // 
            // GVPT_MSCB
            // 
            this.GVPT_MSCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GVPT_MSCB.Location = new System.Drawing.Point(34, 50);
            this.GVPT_MSCB.Name = "GVPT_MSCB";
            this.GVPT_MSCB.Size = new System.Drawing.Size(213, 27);
            this.GVPT_MSCB.TabIndex = 26;
            // 
            // Masocanbo
            // 
            this.Masocanbo.AutoSize = true;
            this.Masocanbo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Masocanbo.Location = new System.Drawing.Point(30, 13);
            this.Masocanbo.Name = "Masocanbo";
            this.Masocanbo.Size = new System.Drawing.Size(67, 23);
            this.Masocanbo.TabIndex = 25;
            this.Masocanbo.Text = "MSCB";
            // 
            // GVPT_MMH
            // 
            this.GVPT_MMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GVPT_MMH.Location = new System.Drawing.Point(34, 154);
            this.GVPT_MMH.Name = "GVPT_MMH";
            this.GVPT_MMH.Size = new System.Drawing.Size(213, 27);
            this.GVPT_MMH.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 23);
            this.label1.TabIndex = 23;
            this.label1.Text = "Mã môn học phụ trách";
            // 
            // GVQL
            // 
            this.GVQL.Controls.Add(this.GVQL_DB);
            this.GVQL.Controls.Add(this.GVQL_EB);
            this.GVQL.Controls.Add(this.GVQL_AB);
            this.GVQL.Controls.Add(this.ViewGVQL);
            this.GVQL.Controls.Add(this.GVQL_MSCB);
            this.GVQL.Controls.Add(this.label4);
            this.GVQL.Controls.Add(this.GVQL_MMH);
            this.GVQL.Controls.Add(this.label5);
            this.GVQL.Location = new System.Drawing.Point(4, 40);
            this.GVQL.Name = "GVQL";
            this.GVQL.Padding = new System.Windows.Forms.Padding(3);
            this.GVQL.Size = new System.Drawing.Size(788, 417);
            this.GVQL.TabIndex = 2;
            this.GVQL.Text = "GVQL";
            this.GVQL.UseVisualStyleBackColor = true;
            // 
            // GVQL_DB
            // 
            this.GVQL_DB.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GVQL_DB.Location = new System.Drawing.Point(39, 356);
            this.GVQL_DB.Name = "GVQL_DB";
            this.GVQL_DB.Size = new System.Drawing.Size(84, 34);
            this.GVQL_DB.TabIndex = 38;
            this.GVQL_DB.Text = "Delete";
            this.GVQL_DB.UseVisualStyleBackColor = true;
            this.GVQL_DB.Click += new System.EventHandler(this.GVQL_DB_Click);
            // 
            // GVQL_EB
            // 
            this.GVQL_EB.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GVQL_EB.Location = new System.Drawing.Point(168, 282);
            this.GVQL_EB.Name = "GVQL_EB";
            this.GVQL_EB.Size = new System.Drawing.Size(84, 34);
            this.GVQL_EB.TabIndex = 37;
            this.GVQL_EB.Text = "Edit";
            this.GVQL_EB.UseVisualStyleBackColor = true;
            this.GVQL_EB.Click += new System.EventHandler(this.GVQL_EB_Click);
            // 
            // GVQL_AB
            // 
            this.GVQL_AB.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GVQL_AB.Location = new System.Drawing.Point(39, 282);
            this.GVQL_AB.Name = "GVQL_AB";
            this.GVQL_AB.Size = new System.Drawing.Size(84, 34);
            this.GVQL_AB.TabIndex = 36;
            this.GVQL_AB.Text = "Add";
            this.GVQL_AB.UseVisualStyleBackColor = true;
            this.GVQL_AB.Click += new System.EventHandler(this.GVQL_AB_Click);
            // 
            // ViewGVQL
            // 
            this.ViewGVQL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewGVQL.Location = new System.Drawing.Point(313, 24);
            this.ViewGVQL.Name = "ViewGVQL";
            this.ViewGVQL.RowHeadersWidth = 51;
            this.ViewGVQL.RowTemplate.Height = 24;
            this.ViewGVQL.Size = new System.Drawing.Size(458, 376);
            this.ViewGVQL.TabIndex = 35;
            this.ViewGVQL.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ViewGVQL_CellContentClick);
            // 
            // GVQL_MSCB
            // 
            this.GVQL_MSCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GVQL_MSCB.Location = new System.Drawing.Point(39, 49);
            this.GVQL_MSCB.Name = "GVQL_MSCB";
            this.GVQL_MSCB.Size = new System.Drawing.Size(213, 27);
            this.GVQL_MSCB.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 23);
            this.label4.TabIndex = 33;
            this.label4.Text = "MSCB";
            // 
            // GVQL_MMH
            // 
            this.GVQL_MMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GVQL_MMH.Location = new System.Drawing.Point(39, 153);
            this.GVQL_MMH.Name = "GVQL_MMH";
            this.GVQL_MMH.Size = new System.Drawing.Size(213, 27);
            this.GVQL_MMH.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 23);
            this.label5.TabIndex = 31;
            this.label5.Text = "Mã môn học quản lý";
            // 
            // CDR
            // 
            this.CDR.Controls.Add(this.ViewCDR);
            this.CDR.Controls.Add(this.label3);
            this.CDR.Controls.Add(this.CDR_DB);
            this.CDR.Controls.Add(this.CDR_MMH);
            this.CDR.Controls.Add(this.CDR_EB);
            this.CDR.Controls.Add(this.Sothutu);
            this.CDR.Controls.Add(this.CDR_AB);
            this.CDR.Controls.Add(this.CDR_STT);
            this.CDR.Controls.Add(this.CDRName);
            this.CDR.Controls.Add(this.label2);
            this.CDR.Location = new System.Drawing.Point(4, 40);
            this.CDR.Name = "CDR";
            this.CDR.Padding = new System.Windows.Forms.Padding(3);
            this.CDR.Size = new System.Drawing.Size(788, 417);
            this.CDR.TabIndex = 3;
            this.CDR.Text = "CDR";
            this.CDR.UseVisualStyleBackColor = true;
            // 
            // ViewCDR
            // 
            this.ViewCDR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewCDR.Location = new System.Drawing.Point(308, 26);
            this.ViewCDR.Name = "ViewCDR";
            this.ViewCDR.RowHeadersWidth = 51;
            this.ViewCDR.RowTemplate.Height = 24;
            this.ViewCDR.Size = new System.Drawing.Size(458, 376);
            this.ViewCDR.TabIndex = 28;
            this.ViewCDR.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ViewCDR_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 23);
            this.label3.TabIndex = 18;
            this.label3.Text = "Mã môn học";
            // 
            // CDR_DB
            // 
            this.CDR_DB.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CDR_DB.Location = new System.Drawing.Point(29, 356);
            this.CDR_DB.Name = "CDR_DB";
            this.CDR_DB.Size = new System.Drawing.Size(84, 34);
            this.CDR_DB.TabIndex = 26;
            this.CDR_DB.Text = "Delete";
            this.CDR_DB.UseVisualStyleBackColor = true;
            this.CDR_DB.Click += new System.EventHandler(this.CDR_DB_Click);
            // 
            // CDR_MMH
            // 
            this.CDR_MMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CDR_MMH.Location = new System.Drawing.Point(29, 52);
            this.CDR_MMH.Name = "CDR_MMH";
            this.CDR_MMH.Size = new System.Drawing.Size(212, 27);
            this.CDR_MMH.TabIndex = 19;
            // 
            // CDR_EB
            // 
            this.CDR_EB.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CDR_EB.Location = new System.Drawing.Point(157, 282);
            this.CDR_EB.Name = "CDR_EB";
            this.CDR_EB.Size = new System.Drawing.Size(84, 34);
            this.CDR_EB.TabIndex = 25;
            this.CDR_EB.Text = "Edit";
            this.CDR_EB.UseVisualStyleBackColor = true;
            this.CDR_EB.Click += new System.EventHandler(this.CDR_EB_Click);
            // 
            // Sothutu
            // 
            this.Sothutu.AutoSize = true;
            this.Sothutu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sothutu.Location = new System.Drawing.Point(25, 101);
            this.Sothutu.Name = "Sothutu";
            this.Sothutu.Size = new System.Drawing.Size(47, 23);
            this.Sothutu.TabIndex = 20;
            this.Sothutu.Text = "STT";
            // 
            // CDR_AB
            // 
            this.CDR_AB.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CDR_AB.Location = new System.Drawing.Point(29, 282);
            this.CDR_AB.Name = "CDR_AB";
            this.CDR_AB.Size = new System.Drawing.Size(84, 34);
            this.CDR_AB.TabIndex = 24;
            this.CDR_AB.Text = "Add";
            this.CDR_AB.UseVisualStyleBackColor = true;
            this.CDR_AB.Click += new System.EventHandler(this.CDR_AB_Click);
            // 
            // CDR_STT
            // 
            this.CDR_STT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CDR_STT.Location = new System.Drawing.Point(29, 136);
            this.CDR_STT.Name = "CDR_STT";
            this.CDR_STT.Size = new System.Drawing.Size(212, 27);
            this.CDR_STT.TabIndex = 21;
            // 
            // CDRName
            // 
            this.CDRName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CDRName.Location = new System.Drawing.Point(29, 221);
            this.CDRName.Name = "CDRName";
            this.CDRName.Size = new System.Drawing.Size(212, 27);
            this.CDRName.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 23);
            this.label2.TabIndex = 22;
            this.label2.Text = "Tên chuẩn đầu ra";
            // 
            // LTTab
            // 
            this.LTTab.Controls.Add(this.LT_DB);
            this.LTTab.Controls.Add(this.LT_EB);
            this.LTTab.Controls.Add(this.LT_AB);
            this.LTTab.Controls.Add(this.NH);
            this.LTTab.Controls.Add(this.label6);
            this.LTTab.Controls.Add(this.HK);
            this.LTTab.Controls.Add(this.label7);
            this.LTTab.Controls.Add(this.LT);
            this.LTTab.Controls.Add(this.label8);
            this.LTTab.Controls.Add(this.ViewLT);
            this.LTTab.Location = new System.Drawing.Point(4, 40);
            this.LTTab.Name = "LTTab";
            this.LTTab.Padding = new System.Windows.Forms.Padding(3);
            this.LTTab.Size = new System.Drawing.Size(788, 417);
            this.LTTab.TabIndex = 4;
            this.LTTab.Text = "LanThi";
            this.LTTab.UseVisualStyleBackColor = true;
            // 
            // SV
            // 
            this.SV.Controls.Add(this.SV_DB);
            this.SV.Controls.Add(this.SV_AB);
            this.SV.Controls.Add(this.ViewSV);
            this.SV.Controls.Add(this.SV_MSSV);
            this.SV.Controls.Add(this.label9);
            this.SV.Location = new System.Drawing.Point(4, 40);
            this.SV.Name = "SV";
            this.SV.Padding = new System.Windows.Forms.Padding(3);
            this.SV.Size = new System.Drawing.Size(788, 417);
            this.SV.TabIndex = 5;
            this.SV.Text = "SinhVien";
            this.SV.UseVisualStyleBackColor = true;
            // 
            // NH
            // 
            this.NH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NH.Location = new System.Drawing.Point(44, 212);
            this.NH.Name = "NH";
            this.NH.Size = new System.Drawing.Size(215, 27);
            this.NH.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 23);
            this.label6.TabIndex = 37;
            this.label6.Text = "Năm học";
            // 
            // HK
            // 
            this.HK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HK.Location = new System.Drawing.Point(44, 142);
            this.HK.Name = "HK";
            this.HK.Size = new System.Drawing.Size(215, 27);
            this.HK.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(40, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 23);
            this.label7.TabIndex = 35;
            this.label7.Text = "Học kỳ";
            // 
            // LT
            // 
            this.LT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LT.Location = new System.Drawing.Point(44, 67);
            this.LT.Name = "LT";
            this.LT.Size = new System.Drawing.Size(215, 27);
            this.LT.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(40, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 23);
            this.label8.TabIndex = 33;
            this.label8.Text = "Lần thi";
            // 
            // ViewLT
            // 
            this.ViewLT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewLT.Location = new System.Drawing.Point(318, 26);
            this.ViewLT.Name = "ViewLT";
            this.ViewLT.RowHeadersWidth = 51;
            this.ViewLT.RowTemplate.Height = 24;
            this.ViewLT.Size = new System.Drawing.Size(448, 369);
            this.ViewLT.TabIndex = 32;
            this.ViewLT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ViewLT_CellContentClick);
            // 
            // LT_DB
            // 
            this.LT_DB.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LT_DB.Location = new System.Drawing.Point(44, 359);
            this.LT_DB.Name = "LT_DB";
            this.LT_DB.Size = new System.Drawing.Size(84, 34);
            this.LT_DB.TabIndex = 41;
            this.LT_DB.Text = "Delete";
            this.LT_DB.UseVisualStyleBackColor = true;
            this.LT_DB.Click += new System.EventHandler(this.LT_DB_Click);
            // 
            // LT_EB
            // 
            this.LT_EB.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LT_EB.Location = new System.Drawing.Point(175, 285);
            this.LT_EB.Name = "LT_EB";
            this.LT_EB.Size = new System.Drawing.Size(84, 34);
            this.LT_EB.TabIndex = 40;
            this.LT_EB.Text = "Edit";
            this.LT_EB.UseVisualStyleBackColor = true;
            this.LT_EB.Click += new System.EventHandler(this.LT_EB_Click);
            // 
            // LT_AB
            // 
            this.LT_AB.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LT_AB.Location = new System.Drawing.Point(44, 285);
            this.LT_AB.Name = "LT_AB";
            this.LT_AB.Size = new System.Drawing.Size(84, 34);
            this.LT_AB.TabIndex = 39;
            this.LT_AB.Text = "Add";
            this.LT_AB.UseVisualStyleBackColor = true;
            this.LT_AB.Click += new System.EventHandler(this.LT_AB_Click);
            // 
            // ViewSV
            // 
            this.ViewSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewSV.Location = new System.Drawing.Point(304, 26);
            this.ViewSV.Name = "ViewSV";
            this.ViewSV.RowHeadersWidth = 51;
            this.ViewSV.RowTemplate.Height = 24;
            this.ViewSV.Size = new System.Drawing.Size(458, 376);
            this.ViewSV.TabIndex = 30;
            this.ViewSV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ViewSV_CellContentClick);
            // 
            // SV_MSSV
            // 
            this.SV_MSSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SV_MSSV.Location = new System.Drawing.Point(30, 51);
            this.SV_MSSV.Name = "SV_MSSV";
            this.SV_MSSV.Size = new System.Drawing.Size(213, 27);
            this.SV_MSSV.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(26, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 23);
            this.label9.TabIndex = 28;
            this.label9.Text = "MSSV";
            // 
            // SV_DB
            // 
            this.SV_DB.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SV_DB.Location = new System.Drawing.Point(159, 286);
            this.SV_DB.Name = "SV_DB";
            this.SV_DB.Size = new System.Drawing.Size(84, 34);
            this.SV_DB.TabIndex = 44;
            this.SV_DB.Text = "Delete";
            this.SV_DB.UseVisualStyleBackColor = true;
            this.SV_DB.Click += new System.EventHandler(this.SV_DB_Click);
            // 
            // SV_AB
            // 
            this.SV_AB.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SV_AB.Location = new System.Drawing.Point(30, 286);
            this.SV_AB.Name = "SV_AB";
            this.SV_AB.Size = new System.Drawing.Size(84, 34);
            this.SV_AB.TabIndex = 42;
            this.SV_AB.Text = "Add";
            this.SV_AB.UseVisualStyleBackColor = true;
            this.SV_AB.Click += new System.EventHandler(this.SV_AB_Click);
            // 
            // AdminUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 545);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.AdminText);
            this.Controls.Add(this.AdminControl);
            this.Name = "AdminUI";
            this.Text = "AdminUI";
            this.AdminControl.ResumeLayout(false);
            this.MonHoc.ResumeLayout(false);
            this.MonHoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewMonHoc)).EndInit();
            this.GVPT.ResumeLayout(false);
            this.GVPT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewGVPT)).EndInit();
            this.GVQL.ResumeLayout(false);
            this.GVQL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewGVQL)).EndInit();
            this.CDR.ResumeLayout(false);
            this.CDR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewCDR)).EndInit();
            this.LTTab.ResumeLayout(false);
            this.LTTab.PerformLayout();
            this.SV.ResumeLayout(false);
            this.SV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewLT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label AdminText;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.TabControl AdminControl;
        private System.Windows.Forms.TabPage MonHoc;
        private System.Windows.Forms.TabPage GVPT;
        private System.Windows.Forms.TabPage GVQL;
        private System.Windows.Forms.TabPage CDR;
        private System.Windows.Forms.TabPage LTTab;
        private System.Windows.Forms.TabPage SV;
        private System.Windows.Forms.TextBox MH_MHN;
        private System.Windows.Forms.Label MHname;
        private System.Windows.Forms.TextBox MH_MMH;
        private System.Windows.Forms.Label MHID;
        private System.Windows.Forms.DataGridView ViewMonHoc;
        private System.Windows.Forms.TextBox GVPT_MSCB;
        private System.Windows.Forms.Label Masocanbo;
        private System.Windows.Forms.TextBox GVPT_MMH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ViewGVPT;
        private System.Windows.Forms.Button MH_DB;
        private System.Windows.Forms.Button MH_EB;
        private System.Windows.Forms.Button MH_AB;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView ViewCDR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CDR_DB;
        private System.Windows.Forms.TextBox CDR_MMH;
        private System.Windows.Forms.Button CDR_EB;
        private System.Windows.Forms.Label Sothutu;
        private System.Windows.Forms.Button CDR_AB;
        private System.Windows.Forms.TextBox CDR_STT;
        private System.Windows.Forms.TextBox CDRName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button GVQL_DB;
        private System.Windows.Forms.Button GVQL_EB;
        private System.Windows.Forms.Button GVQL_AB;
        private System.Windows.Forms.DataGridView ViewGVQL;
        private System.Windows.Forms.TextBox GVQL_MSCB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox GVQL_MMH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox HK;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox LT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView ViewLT;
        private System.Windows.Forms.Button LT_DB;
        private System.Windows.Forms.Button LT_EB;
        private System.Windows.Forms.Button LT_AB;
        private System.Windows.Forms.Button SV_DB;
        private System.Windows.Forms.Button SV_AB;
        private System.Windows.Forms.DataGridView ViewSV;
        private System.Windows.Forms.TextBox SV_MSSV;
        private System.Windows.Forms.Label label9;
    }
}