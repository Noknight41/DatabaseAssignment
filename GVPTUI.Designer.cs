
namespace Assignment2
{
    partial class GVPTUI
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
            this.Masocanbo = new System.Windows.Forms.Label();
            this.DTCH = new System.Windows.Forms.TabPage();
            this.TDTCH = new System.Windows.Forms.TabPage();
            this.DT = new System.Windows.Forms.TabPage();
            this.TDT = new System.Windows.Forms.TabPage();
            this.CH = new System.Windows.Forms.TabPage();
            this.PTL = new System.Windows.Forms.TabPage();
            this.PCH = new System.Windows.Forms.TabPage();
            this.PMTC = new System.Windows.Forms.TabPage();
            this.FMT = new System.Windows.Forms.TabPage();
            this.ViewFMT = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.IDFMT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.URL = new System.Windows.Forms.TextBox();
            this.LT_AB = new System.Windows.Forms.Button();
            this.FMT_EB = new System.Windows.Forms.Button();
            this.FMT_DB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LKFMT_AB = new System.Windows.Forms.Button();
            this.LKFMT_EB = new System.Windows.Forms.Button();
            this.LKFMT_DB = new System.Windows.Forms.Button();
            this.LKBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.STT = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.IDLK = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.GVPTControl = new System.Windows.Forms.TabControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ViewPCH = new System.Windows.Forms.DataGridView();
            this.PCH.SuspendLayout();
            this.PMTC.SuspendLayout();
            this.FMT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewFMT)).BeginInit();
            this.GVPTControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewPCH)).BeginInit();
            this.SuspendLayout();
            // 
            // AdminText
            // 
            this.AdminText.AutoSize = true;
            this.AdminText.Font = new System.Drawing.Font("Arial Black", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AdminText.Location = new System.Drawing.Point(12, 20);
            this.AdminText.Name = "AdminText";
            this.AdminText.Size = new System.Drawing.Size(139, 54);
            this.AdminText.TabIndex = 13;
            this.AdminText.Text = "GVPT";
            // 
            // LogOutButton
            // 
            this.LogOutButton.Location = new System.Drawing.Point(1100, 42);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(124, 54);
            this.LogOutButton.TabIndex = 50;
            this.LogOutButton.Text = "Log Out";
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // Masocanbo
            // 
            this.Masocanbo.AutoSize = true;
            this.Masocanbo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Masocanbo.Location = new System.Drawing.Point(1128, 9);
            this.Masocanbo.Name = "Masocanbo";
            this.Masocanbo.Size = new System.Drawing.Size(67, 23);
            this.Masocanbo.TabIndex = 61;
            this.Masocanbo.Text = "MSCB";
            this.Masocanbo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DTCH
            // 
            this.DTCH.Location = new System.Drawing.Point(4, 29);
            this.DTCH.Name = "DTCH";
            this.DTCH.Padding = new System.Windows.Forms.Padding(3);
            this.DTCH.Size = new System.Drawing.Size(821, 517);
            this.DTCH.TabIndex = 8;
            this.DTCH.Text = "Nội dung DT";
            this.DTCH.UseVisualStyleBackColor = true;
            // 
            // TDTCH
            // 
            this.TDTCH.Location = new System.Drawing.Point(4, 29);
            this.TDTCH.Name = "TDTCH";
            this.TDTCH.Padding = new System.Windows.Forms.Padding(3);
            this.TDTCH.Size = new System.Drawing.Size(821, 517);
            this.TDTCH.TabIndex = 7;
            this.TDTCH.Text = "Nội dung TDT";
            this.TDTCH.UseVisualStyleBackColor = true;
            // 
            // DT
            // 
            this.DT.Location = new System.Drawing.Point(4, 29);
            this.DT.Name = "DT";
            this.DT.Padding = new System.Windows.Forms.Padding(3);
            this.DT.Size = new System.Drawing.Size(821, 517);
            this.DT.TabIndex = 6;
            this.DT.Text = "Đề thi";
            this.DT.UseVisualStyleBackColor = true;
            // 
            // TDT
            // 
            this.TDT.Location = new System.Drawing.Point(4, 29);
            this.TDT.Name = "TDT";
            this.TDT.Padding = new System.Windows.Forms.Padding(3);
            this.TDT.Size = new System.Drawing.Size(821, 517);
            this.TDT.TabIndex = 5;
            this.TDT.Text = "Tập đề thi";
            this.TDT.UseVisualStyleBackColor = true;
            // 
            // CH
            // 
            this.CH.Location = new System.Drawing.Point(4, 29);
            this.CH.Name = "CH";
            this.CH.Padding = new System.Windows.Forms.Padding(3);
            this.CH.Size = new System.Drawing.Size(821, 517);
            this.CH.TabIndex = 4;
            this.CH.Text = "Câu hỏi";
            this.CH.UseVisualStyleBackColor = true;
            // 
            // PTL
            // 
            this.PTL.Location = new System.Drawing.Point(4, 29);
            this.PTL.Name = "PTL";
            this.PTL.Padding = new System.Windows.Forms.Padding(3);
            this.PTL.Size = new System.Drawing.Size(1251, 643);
            this.PTL.TabIndex = 3;
            this.PTL.Text = "Phần trả lời";
            this.PTL.UseVisualStyleBackColor = true;
            // 
            // PCH
            // 
            this.PCH.Controls.Add(this.ViewPCH);
            this.PCH.Location = new System.Drawing.Point(4, 29);
            this.PCH.Name = "PCH";
            this.PCH.Padding = new System.Windows.Forms.Padding(3);
            this.PCH.Size = new System.Drawing.Size(1251, 643);
            this.PCH.TabIndex = 2;
            this.PCH.Text = "Phần câu hỏi";
            this.PCH.UseVisualStyleBackColor = true;
            // 
            // PMTC
            // 
            this.PMTC.Controls.Add(this.dataGridView1);
            this.PMTC.Location = new System.Drawing.Point(4, 29);
            this.PMTC.Name = "PMTC";
            this.PMTC.Padding = new System.Windows.Forms.Padding(3);
            this.PMTC.Size = new System.Drawing.Size(1251, 643);
            this.PMTC.TabIndex = 1;
            this.PMTC.Text = "Phần mô tả chung";
            this.PMTC.UseVisualStyleBackColor = true;
            // 
            // FMT
            // 
            this.FMT.Controls.Add(this.label5);
            this.FMT.Controls.Add(this.IDLK);
            this.FMT.Controls.Add(this.URL);
            this.FMT.Controls.Add(this.IDFMT);
            this.FMT.Controls.Add(this.label4);
            this.FMT.Controls.Add(this.STT);
            this.FMT.Controls.Add(this.label3);
            this.FMT.Controls.Add(this.LKBox);
            this.FMT.Controls.Add(this.LKFMT_DB);
            this.FMT.Controls.Add(this.LKFMT_EB);
            this.FMT.Controls.Add(this.LKFMT_AB);
            this.FMT.Controls.Add(this.label2);
            this.FMT.Controls.Add(this.label1);
            this.FMT.Controls.Add(this.FMT_DB);
            this.FMT.Controls.Add(this.FMT_EB);
            this.FMT.Controls.Add(this.LT_AB);
            this.FMT.Controls.Add(this.label7);
            this.FMT.Controls.Add(this.label8);
            this.FMT.Controls.Add(this.ViewFMT);
            this.FMT.Location = new System.Drawing.Point(4, 29);
            this.FMT.Name = "FMT";
            this.FMT.Padding = new System.Windows.Forms.Padding(3);
            this.FMT.Size = new System.Drawing.Size(1251, 643);
            this.FMT.TabIndex = 0;
            this.FMT.Text = "File mô tả";
            this.FMT.UseVisualStyleBackColor = true;
            // 
            // ViewFMT
            // 
            this.ViewFMT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewFMT.Location = new System.Drawing.Point(522, 23);
            this.ViewFMT.Name = "ViewFMT";
            this.ViewFMT.RowHeadersWidth = 51;
            this.ViewFMT.RowTemplate.Height = 24;
            this.ViewFMT.Size = new System.Drawing.Size(701, 608);
            this.ViewFMT.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(39, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 23);
            this.label8.TabIndex = 43;
            this.label8.Text = "ID File mô tả";
            // 
            // IDFMT
            // 
            this.IDFMT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDFMT.Location = new System.Drawing.Point(38, 67);
            this.IDFMT.Name = "IDFMT";
            this.IDFMT.Size = new System.Drawing.Size(417, 27);
            this.IDFMT.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(36, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 23);
            this.label7.TabIndex = 45;
            this.label7.Text = "URL hình ảnh";
            // 
            // URL
            // 
            this.URL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.URL.Location = new System.Drawing.Point(38, 143);
            this.URL.Name = "URL";
            this.URL.Size = new System.Drawing.Size(417, 27);
            this.URL.TabIndex = 46;
            // 
            // LT_AB
            // 
            this.LT_AB.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LT_AB.Location = new System.Drawing.Point(41, 414);
            this.LT_AB.Name = "LT_AB";
            this.LT_AB.Size = new System.Drawing.Size(84, 34);
            this.LT_AB.TabIndex = 47;
            this.LT_AB.Text = "Add";
            this.LT_AB.UseVisualStyleBackColor = true;
            this.LT_AB.Click += new System.EventHandler(this.FMT_AB_Click);
            // 
            // FMT_EB
            // 
            this.FMT_EB.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FMT_EB.Location = new System.Drawing.Point(224, 414);
            this.FMT_EB.Name = "FMT_EB";
            this.FMT_EB.Size = new System.Drawing.Size(84, 34);
            this.FMT_EB.TabIndex = 48;
            this.FMT_EB.Text = "Edit";
            this.FMT_EB.UseVisualStyleBackColor = true;
            this.FMT_EB.Click += new System.EventHandler(this.FMT_EB_Click);
            // 
            // FMT_DB
            // 
            this.FMT_DB.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FMT_DB.Location = new System.Drawing.Point(386, 414);
            this.FMT_DB.Name = "FMT_DB";
            this.FMT_DB.Size = new System.Drawing.Size(84, 34);
            this.FMT_DB.TabIndex = 49;
            this.FMT_DB.Text = "Delete";
            this.FMT_DB.UseVisualStyleBackColor = true;
            this.FMT_DB.Click += new System.EventHandler(this.FMT_DB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 380);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 23);
            this.label1.TabIndex = 50;
            this.label1.Text = "FMT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 517);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 23);
            this.label2.TabIndex = 51;
            this.label2.Text = "Liên kết FMT";
            // 
            // LKFMT_AB
            // 
            this.LKFMT_AB.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LKFMT_AB.Location = new System.Drawing.Point(41, 547);
            this.LKFMT_AB.Name = "LKFMT_AB";
            this.LKFMT_AB.Size = new System.Drawing.Size(84, 34);
            this.LKFMT_AB.TabIndex = 52;
            this.LKFMT_AB.Text = "Add";
            this.LKFMT_AB.UseVisualStyleBackColor = true;
            this.LKFMT_AB.Click += new System.EventHandler(this.LKFMT_AB_Click);
            // 
            // LKFMT_EB
            // 
            this.LKFMT_EB.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LKFMT_EB.Location = new System.Drawing.Point(224, 547);
            this.LKFMT_EB.Name = "LKFMT_EB";
            this.LKFMT_EB.Size = new System.Drawing.Size(84, 34);
            this.LKFMT_EB.TabIndex = 53;
            this.LKFMT_EB.Text = "Edit";
            this.LKFMT_EB.UseVisualStyleBackColor = true;
            // 
            // LKFMT_DB
            // 
            this.LKFMT_DB.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LKFMT_DB.Location = new System.Drawing.Point(386, 547);
            this.LKFMT_DB.Name = "LKFMT_DB";
            this.LKFMT_DB.Size = new System.Drawing.Size(84, 34);
            this.LKFMT_DB.TabIndex = 54;
            this.LKFMT_DB.Text = "Delete";
            this.LKFMT_DB.UseVisualStyleBackColor = true;
            // 
            // LKBox
            // 
            this.LKBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LKBox.FormattingEnabled = true;
            this.LKBox.Items.AddRange(new object[] {
            "PCH",
            "PTL",
            "PMTC"});
            this.LKBox.Location = new System.Drawing.Point(38, 217);
            this.LKBox.Name = "LKBox";
            this.LKBox.Size = new System.Drawing.Size(417, 28);
            this.LKBox.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 23);
            this.label3.TabIndex = 56;
            this.label3.Text = "Liên kết với";
            // 
            // STT
            // 
            this.STT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STT.FormattingEnabled = true;
            this.STT.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.STT.Location = new System.Drawing.Point(395, 291);
            this.STT.Name = "STT";
            this.STT.Size = new System.Drawing.Size(60, 28);
            this.STT.TabIndex = 57;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 23);
            this.label4.TabIndex = 58;
            this.label4.Text = "ID phần liên kết";
            // 
            // IDLK
            // 
            this.IDLK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDLK.Location = new System.Drawing.Point(38, 292);
            this.IDLK.Name = "IDLK";
            this.IDLK.Size = new System.Drawing.Size(324, 27);
            this.IDLK.TabIndex = 59;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(391, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 23);
            this.label5.TabIndex = 60;
            this.label5.Text = "STT";
            // 
            // GVPTControl
            // 
            this.GVPTControl.Controls.Add(this.FMT);
            this.GVPTControl.Controls.Add(this.PMTC);
            this.GVPTControl.Controls.Add(this.PCH);
            this.GVPTControl.Controls.Add(this.PTL);
            this.GVPTControl.Controls.Add(this.CH);
            this.GVPTControl.Controls.Add(this.TDT);
            this.GVPTControl.Controls.Add(this.DT);
            this.GVPTControl.Controls.Add(this.TDTCH);
            this.GVPTControl.Controls.Add(this.DTCH);
            this.GVPTControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GVPTControl.Location = new System.Drawing.Point(0, 102);
            this.GVPTControl.Name = "GVPTControl";
            this.GVPTControl.SelectedIndex = 0;
            this.GVPTControl.Size = new System.Drawing.Size(1259, 676);
            this.GVPTControl.TabIndex = 0;
            this.GVPTControl.TabStop = false;
            this.GVPTControl.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(573, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(657, 610);
            this.dataGridView1.TabIndex = 0;
            // 
            // ViewPCH
            // 
            this.ViewPCH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewPCH.Location = new System.Drawing.Point(576, 22);
            this.ViewPCH.Name = "ViewPCH";
            this.ViewPCH.RowHeadersWidth = 51;
            this.ViewPCH.RowTemplate.Height = 24;
            this.ViewPCH.Size = new System.Drawing.Size(663, 609);
            this.ViewPCH.TabIndex = 1;
            // 
            // GVPTUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1255, 774);
            this.Controls.Add(this.Masocanbo);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.AdminText);
            this.Controls.Add(this.GVPTControl);
            this.Name = "GVPTUI";
            this.Text = "GVPT";
            this.PCH.ResumeLayout(false);
            this.PMTC.ResumeLayout(false);
            this.FMT.ResumeLayout(false);
            this.FMT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewFMT)).EndInit();
            this.GVPTControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewPCH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label AdminText;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.Label Masocanbo;
        private System.Windows.Forms.TabPage DTCH;
        private System.Windows.Forms.TabPage TDTCH;
        private System.Windows.Forms.TabPage DT;
        private System.Windows.Forms.TabPage TDT;
        private System.Windows.Forms.TabPage CH;
        private System.Windows.Forms.TabPage PTL;
        private System.Windows.Forms.TabPage PCH;
        private System.Windows.Forms.TabPage PMTC;
        private System.Windows.Forms.TabPage FMT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox IDLK;
        private System.Windows.Forms.TextBox URL;
        private System.Windows.Forms.TextBox IDFMT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox STT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox LKBox;
        private System.Windows.Forms.Button LKFMT_DB;
        private System.Windows.Forms.Button LKFMT_EB;
        private System.Windows.Forms.Button LKFMT_AB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button FMT_DB;
        private System.Windows.Forms.Button FMT_EB;
        private System.Windows.Forms.Button LT_AB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView ViewFMT;
        private System.Windows.Forms.TabControl GVPTControl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView ViewPCH;
    }
}