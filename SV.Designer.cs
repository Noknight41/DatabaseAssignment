
namespace Assignment2
{
    partial class SV
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
            this.SVControl = new System.Windows.Forms.TabControl();
            this.XDT = new System.Windows.Forms.TabPage();
            this.XMDT = new System.Windows.Forms.TextBox();
            this.VXDT = new System.Windows.Forms.DataGridView();
            this.XD = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.GC = new System.Windows.Forms.TabPage();
            this.N_EB = new System.Windows.Forms.Button();
            this.ViewNote = new System.Windows.Forms.DataGridView();
            this.N_N = new System.Windows.Forms.RichTextBox();
            this.asdad = new System.Windows.Forms.Label();
            this.sdafasd = new System.Windows.Forms.Label();
            this.N_MDT = new System.Windows.Forms.TextBox();
            this.LB = new System.Windows.Forms.TabPage();
            this.LDT = new System.Windows.Forms.TextBox();
            this.ViewDT = new System.Windows.Forms.DataGridView();
            this.LD = new System.Windows.Forms.Button();
            this.sadsda = new System.Windows.Forms.Label();
            this.DT = new System.Windows.Forms.TabPage();
            this.LT_DT = new System.Windows.Forms.TextBox();
            this.LT_B = new System.Windows.Forms.Button();
            this.asqnjc = new System.Windows.Forms.Label();
            this.ViewDiemThi = new System.Windows.Forms.DataGridView();
            this.PW = new System.Windows.Forms.TabPage();
            this.label25 = new System.Windows.Forms.Label();
            this.PW_Edit = new System.Windows.Forms.Button();
            this.Password = new System.Windows.Forms.TextBox();
            this.GVQLLogo = new System.Windows.Forms.Label();
            this.Note = new System.Windows.Forms.Button();
            this.Masosinhvien = new System.Windows.Forms.Label();
            this.SVControl.SuspendLayout();
            this.XDT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VXDT)).BeginInit();
            this.GC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewNote)).BeginInit();
            this.LB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewDT)).BeginInit();
            this.DT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewDiemThi)).BeginInit();
            this.PW.SuspendLayout();
            this.SuspendLayout();
            // 
            // SVControl
            // 
            this.SVControl.Controls.Add(this.XDT);
            this.SVControl.Controls.Add(this.GC);
            this.SVControl.Controls.Add(this.LB);
            this.SVControl.Controls.Add(this.DT);
            this.SVControl.Controls.Add(this.PW);
            this.SVControl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SVControl.Location = new System.Drawing.Point(1, 89);
            this.SVControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SVControl.Name = "SVControl";
            this.SVControl.SelectedIndex = 0;
            this.SVControl.Size = new System.Drawing.Size(1116, 658);
            this.SVControl.TabIndex = 67;
            this.SVControl.SelectedIndexChanged += new System.EventHandler(this.SVControl_SelectedIndexChanged);
            // 
            // XDT
            // 
            this.XDT.Controls.Add(this.XMDT);
            this.XDT.Controls.Add(this.VXDT);
            this.XDT.Controls.Add(this.XD);
            this.XDT.Controls.Add(this.label1);
            this.XDT.Location = new System.Drawing.Point(4, 32);
            this.XDT.Name = "XDT";
            this.XDT.Size = new System.Drawing.Size(1108, 622);
            this.XDT.TabIndex = 2;
            this.XDT.Text = "Xem đề thi";
            this.XDT.UseVisualStyleBackColor = true;
            // 
            // XMDT
            // 
            this.XMDT.Location = new System.Drawing.Point(135, 35);
            this.XMDT.Name = "XMDT";
            this.XMDT.Size = new System.Drawing.Size(470, 30);
            this.XMDT.TabIndex = 162;
            // 
            // VXDT
            // 
            this.VXDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VXDT.Location = new System.Drawing.Point(29, 93);
            this.VXDT.Name = "VXDT";
            this.VXDT.RowHeadersWidth = 51;
            this.VXDT.RowTemplate.Height = 24;
            this.VXDT.Size = new System.Drawing.Size(1054, 503);
            this.VXDT.TabIndex = 161;
            // 
            // XD
            // 
            this.XD.Location = new System.Drawing.Point(940, 27);
            this.XD.Margin = new System.Windows.Forms.Padding(4);
            this.XD.Name = "XD";
            this.XD.Size = new System.Drawing.Size(143, 43);
            this.XD.TabIndex = 160;
            this.XD.Text = "Xem đề thi";
            this.XD.UseVisualStyleBackColor = true;
            this.XD.Click += new System.EventHandler(this.XD_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 24);
            this.label1.TabIndex = 159;
            this.label1.Text = "Mã đề thi";
            // 
            // GC
            // 
            this.GC.Controls.Add(this.N_EB);
            this.GC.Controls.Add(this.ViewNote);
            this.GC.Controls.Add(this.N_N);
            this.GC.Controls.Add(this.asdad);
            this.GC.Controls.Add(this.sdafasd);
            this.GC.Controls.Add(this.N_MDT);
            this.GC.Location = new System.Drawing.Point(4, 32);
            this.GC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GC.Name = "GC";
            this.GC.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GC.Size = new System.Drawing.Size(1108, 622);
            this.GC.TabIndex = 1;
            this.GC.Text = "Ghi chú";
            this.GC.UseVisualStyleBackColor = true;
            // 
            // N_EB
            // 
            this.N_EB.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.N_EB.Location = new System.Drawing.Point(279, 550);
            this.N_EB.Name = "N_EB";
            this.N_EB.Size = new System.Drawing.Size(84, 34);
            this.N_EB.TabIndex = 28;
            this.N_EB.Text = "Note";
            this.N_EB.UseVisualStyleBackColor = true;
            this.N_EB.Click += new System.EventHandler(this.N_EB_Click);
            // 
            // ViewNote
            // 
            this.ViewNote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewNote.Location = new System.Drawing.Point(451, 21);
            this.ViewNote.Name = "ViewNote";
            this.ViewNote.RowHeadersWidth = 51;
            this.ViewNote.RowTemplate.Height = 24;
            this.ViewNote.Size = new System.Drawing.Size(631, 581);
            this.ViewNote.TabIndex = 5;
            // 
            // N_N
            // 
            this.N_N.Location = new System.Drawing.Point(51, 176);
            this.N_N.Name = "N_N";
            this.N_N.Size = new System.Drawing.Size(312, 321);
            this.N_N.TabIndex = 4;
            this.N_N.Text = "";
            // 
            // asdad
            // 
            this.asdad.AutoSize = true;
            this.asdad.Location = new System.Drawing.Point(47, 142);
            this.asdad.Name = "asdad";
            this.asdad.Size = new System.Drawing.Size(51, 23);
            this.asdad.TabIndex = 3;
            this.asdad.Text = "Note";
            // 
            // sdafasd
            // 
            this.sdafasd.AutoSize = true;
            this.sdafasd.Location = new System.Drawing.Point(47, 31);
            this.sdafasd.Name = "sdafasd";
            this.sdafasd.Size = new System.Drawing.Size(92, 23);
            this.sdafasd.TabIndex = 1;
            this.sdafasd.Text = "Mã đề thi";
            // 
            // N_MDT
            // 
            this.N_MDT.Location = new System.Drawing.Point(51, 71);
            this.N_MDT.Name = "N_MDT";
            this.N_MDT.Size = new System.Drawing.Size(312, 30);
            this.N_MDT.TabIndex = 0;
            // 
            // LB
            // 
            this.LB.Controls.Add(this.LDT);
            this.LB.Controls.Add(this.ViewDT);
            this.LB.Controls.Add(this.LD);
            this.LB.Controls.Add(this.sadsda);
            this.LB.Location = new System.Drawing.Point(4, 32);
            this.LB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LB.Name = "LB";
            this.LB.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LB.Size = new System.Drawing.Size(1108, 622);
            this.LB.TabIndex = 0;
            this.LB.Text = "Làm bài";
            this.LB.UseVisualStyleBackColor = true;
            // 
            // LDT
            // 
            this.LDT.Location = new System.Drawing.Point(136, 34);
            this.LDT.Name = "LDT";
            this.LDT.Size = new System.Drawing.Size(470, 30);
            this.LDT.TabIndex = 154;
            // 
            // ViewDT
            // 
            this.ViewDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewDT.Location = new System.Drawing.Point(30, 92);
            this.ViewDT.Name = "ViewDT";
            this.ViewDT.RowHeadersWidth = 51;
            this.ViewDT.RowTemplate.Height = 24;
            this.ViewDT.Size = new System.Drawing.Size(1054, 503);
            this.ViewDT.TabIndex = 153;
            // 
            // LD
            // 
            this.LD.Location = new System.Drawing.Point(941, 26);
            this.LD.Margin = new System.Windows.Forms.Padding(4);
            this.LD.Name = "LD";
            this.LD.Size = new System.Drawing.Size(143, 43);
            this.LD.TabIndex = 152;
            this.LD.Text = "Làm đề";
            this.LD.UseVisualStyleBackColor = true;
            this.LD.Click += new System.EventHandler(this.LD_Click);
            // 
            // sadsda
            // 
            this.sadsda.AutoSize = true;
            this.sadsda.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sadsda.Location = new System.Drawing.Point(26, 37);
            this.sadsda.Name = "sadsda";
            this.sadsda.Size = new System.Drawing.Size(97, 24);
            this.sadsda.TabIndex = 146;
            this.sadsda.Text = "Mã đề thi";
            // 
            // DT
            // 
            this.DT.Controls.Add(this.LT_DT);
            this.DT.Controls.Add(this.LT_B);
            this.DT.Controls.Add(this.asqnjc);
            this.DT.Controls.Add(this.ViewDiemThi);
            this.DT.Location = new System.Drawing.Point(4, 32);
            this.DT.Name = "DT";
            this.DT.Size = new System.Drawing.Size(1108, 622);
            this.DT.TabIndex = 3;
            this.DT.Text = "Điểm thi";
            this.DT.UseVisualStyleBackColor = true;
            // 
            // LT_DT
            // 
            this.LT_DT.Location = new System.Drawing.Point(178, 26);
            this.LT_DT.Name = "LT_DT";
            this.LT_DT.Size = new System.Drawing.Size(470, 30);
            this.LT_DT.TabIndex = 157;
            // 
            // LT_B
            // 
            this.LT_B.Location = new System.Drawing.Point(930, 19);
            this.LT_B.Margin = new System.Windows.Forms.Padding(4);
            this.LT_B.Name = "LT_B";
            this.LT_B.Size = new System.Drawing.Size(143, 43);
            this.LT_B.TabIndex = 156;
            this.LT_B.Text = "Xem";
            this.LT_B.UseVisualStyleBackColor = true;
            this.LT_B.Click += new System.EventHandler(this.LT_B_Click);
            // 
            // asqnjc
            // 
            this.asqnjc.AutoSize = true;
            this.asqnjc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asqnjc.Location = new System.Drawing.Point(34, 29);
            this.asqnjc.Name = "asqnjc";
            this.asqnjc.Size = new System.Drawing.Size(75, 24);
            this.asqnjc.TabIndex = 155;
            this.asqnjc.Text = "Lần thi";
            // 
            // ViewDiemThi
            // 
            this.ViewDiemThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewDiemThi.Location = new System.Drawing.Point(38, 86);
            this.ViewDiemThi.Name = "ViewDiemThi";
            this.ViewDiemThi.RowHeadersWidth = 51;
            this.ViewDiemThi.RowTemplate.Height = 24;
            this.ViewDiemThi.Size = new System.Drawing.Size(1035, 512);
            this.ViewDiemThi.TabIndex = 0;
            // 
            // PW
            // 
            this.PW.Controls.Add(this.label25);
            this.PW.Controls.Add(this.PW_Edit);
            this.PW.Controls.Add(this.Password);
            this.PW.Location = new System.Drawing.Point(4, 32);
            this.PW.Name = "PW";
            this.PW.Size = new System.Drawing.Size(1108, 622);
            this.PW.TabIndex = 4;
            this.PW.Text = "Password";
            this.PW.UseVisualStyleBackColor = true;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(238, 193);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(98, 23);
            this.label25.TabIndex = 155;
            this.label25.Text = "Password";
            // 
            // PW_Edit
            // 
            this.PW_Edit.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PW_Edit.Location = new System.Drawing.Point(838, 308);
            this.PW_Edit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PW_Edit.Name = "PW_Edit";
            this.PW_Edit.Size = new System.Drawing.Size(84, 34);
            this.PW_Edit.TabIndex = 154;
            this.PW_Edit.Text = "Edit";
            this.PW_Edit.UseVisualStyleBackColor = true;
            this.PW_Edit.Click += new System.EventHandler(this.PW_Edit_Click);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(243, 241);
            this.Password.Margin = new System.Windows.Forms.Padding(4);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(677, 30);
            this.Password.TabIndex = 153;
            // 
            // GVQLLogo
            // 
            this.GVQLLogo.AutoSize = true;
            this.GVQLLogo.Font = new System.Drawing.Font("Arial Black", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GVQLLogo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GVQLLogo.Location = new System.Drawing.Point(47, 21);
            this.GVQLLogo.Name = "GVQLLogo";
            this.GVQLLogo.Size = new System.Drawing.Size(80, 54);
            this.GVQLLogo.TabIndex = 70;
            this.GVQLLogo.Text = "SV";
            // 
            // Note
            // 
            this.Note.Location = new System.Drawing.Point(965, 30);
            this.Note.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Note.Name = "Note";
            this.Note.Size = new System.Drawing.Size(124, 54);
            this.Note.TabIndex = 69;
            this.Note.Text = "Log Out";
            this.Note.UseVisualStyleBackColor = true;
            this.Note.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // Masosinhvien
            // 
            this.Masosinhvien.AutoSize = true;
            this.Masosinhvien.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Masosinhvien.Location = new System.Drawing.Point(214, 43);
            this.Masosinhvien.Name = "Masosinhvien";
            this.Masosinhvien.Size = new System.Drawing.Size(66, 23);
            this.Masosinhvien.TabIndex = 68;
            this.Masosinhvien.Text = "MSSV";
            this.Masosinhvien.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1119, 747);
            this.Controls.Add(this.GVQLLogo);
            this.Controls.Add(this.Note);
            this.Controls.Add(this.Masosinhvien);
            this.Controls.Add(this.SVControl);
            this.Name = "SV";
            this.Text = "SV";
            this.SVControl.ResumeLayout(false);
            this.XDT.ResumeLayout(false);
            this.XDT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VXDT)).EndInit();
            this.GC.ResumeLayout(false);
            this.GC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewNote)).EndInit();
            this.LB.ResumeLayout(false);
            this.LB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewDT)).EndInit();
            this.DT.ResumeLayout(false);
            this.DT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewDiemThi)).EndInit();
            this.PW.ResumeLayout(false);
            this.PW.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl SVControl;
        private System.Windows.Forms.TabPage GC;
        private System.Windows.Forms.DataGridView ViewNote;
        private System.Windows.Forms.RichTextBox N_N;
        private System.Windows.Forms.Label asdad;
        private System.Windows.Forms.Label sdafasd;
        private System.Windows.Forms.TextBox N_MDT;
        private System.Windows.Forms.TabPage LB;
        private System.Windows.Forms.Button LD;
        private System.Windows.Forms.Label sadsda;
        private System.Windows.Forms.Label GVQLLogo;
        private System.Windows.Forms.Button Note;
        private System.Windows.Forms.Label Masosinhvien;
        private System.Windows.Forms.Button N_EB;
        private System.Windows.Forms.DataGridView ViewDT;
        private System.Windows.Forms.TextBox LDT;
        private System.Windows.Forms.TabPage XDT;
        private System.Windows.Forms.TextBox XMDT;
        private System.Windows.Forms.DataGridView VXDT;
        private System.Windows.Forms.Button XD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage DT;
        private System.Windows.Forms.DataGridView ViewDiemThi;
        private System.Windows.Forms.TextBox LT_DT;
        private System.Windows.Forms.Button LT_B;
        private System.Windows.Forms.Label asqnjc;
        private System.Windows.Forms.TabPage PW;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button PW_Edit;
        private System.Windows.Forms.TextBox Password;
    }
}