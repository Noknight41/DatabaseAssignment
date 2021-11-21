
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
            this.GC = new System.Windows.Forms.TabPage();
            this.N_EB = new System.Windows.Forms.Button();
            this.ViewNote = new System.Windows.Forms.DataGridView();
            this.N_N = new System.Windows.Forms.RichTextBox();
            this.asdad = new System.Windows.Forms.Label();
            this.sdafasd = new System.Windows.Forms.Label();
            this.N_MDT = new System.Windows.Forms.TextBox();
            this.LB = new System.Windows.Forms.TabPage();
            this.LD = new System.Windows.Forms.Button();
            this.sadsda = new System.Windows.Forms.Label();
            this.GVQLLogo = new System.Windows.Forms.Label();
            this.Note = new System.Windows.Forms.Button();
            this.Masosinhvien = new System.Windows.Forms.Label();
            this.ViewDT = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SVControl.SuspendLayout();
            this.GC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewNote)).BeginInit();
            this.LB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewDT)).BeginInit();
            this.SuspendLayout();
            // 
            // SVControl
            // 
            this.SVControl.Controls.Add(this.GC);
            this.SVControl.Controls.Add(this.LB);
            this.SVControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.SVControl.Location = new System.Drawing.Point(1, 89);
            this.SVControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SVControl.Name = "SVControl";
            this.SVControl.SelectedIndex = 0;
            this.SVControl.Size = new System.Drawing.Size(1116, 658);
            this.SVControl.TabIndex = 67;
            this.SVControl.SelectedIndexChanged += new System.EventHandler(this.SVControl_SelectedIndexChanged);
            // 
            // GC
            // 
            this.GC.Controls.Add(this.N_EB);
            this.GC.Controls.Add(this.ViewNote);
            this.GC.Controls.Add(this.N_N);
            this.GC.Controls.Add(this.asdad);
            this.GC.Controls.Add(this.sdafasd);
            this.GC.Controls.Add(this.N_MDT);
            this.GC.Location = new System.Drawing.Point(4, 29);
            this.GC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GC.Name = "GC";
            this.GC.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GC.Size = new System.Drawing.Size(1108, 625);
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
            this.ViewNote.Location = new System.Drawing.Point(472, 21);
            this.ViewNote.Name = "ViewNote";
            this.ViewNote.RowHeadersWidth = 51;
            this.ViewNote.RowTemplate.Height = 24;
            this.ViewNote.Size = new System.Drawing.Size(610, 599);
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
            this.asdad.Size = new System.Drawing.Size(48, 22);
            this.asdad.TabIndex = 3;
            this.asdad.Text = "Note";
            // 
            // sdafasd
            // 
            this.sdafasd.AutoSize = true;
            this.sdafasd.Location = new System.Drawing.Point(47, 31);
            this.sdafasd.Name = "sdafasd";
            this.sdafasd.Size = new System.Drawing.Size(83, 22);
            this.sdafasd.TabIndex = 1;
            this.sdafasd.Text = "Mã đề thi";
            // 
            // N_MDT
            // 
            this.N_MDT.Location = new System.Drawing.Point(51, 71);
            this.N_MDT.Name = "N_MDT";
            this.N_MDT.Size = new System.Drawing.Size(312, 27);
            this.N_MDT.TabIndex = 0;
            // 
            // LB
            // 
            this.LB.Controls.Add(this.textBox1);
            this.LB.Controls.Add(this.ViewDT);
            this.LB.Controls.Add(this.LD);
            this.LB.Controls.Add(this.sadsda);
            this.LB.Location = new System.Drawing.Point(4, 29);
            this.LB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LB.Name = "LB";
            this.LB.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LB.Size = new System.Drawing.Size(1108, 625);
            this.LB.TabIndex = 0;
            this.LB.Text = "Làm bài";
            this.LB.UseVisualStyleBackColor = true;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(136, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(470, 27);
            this.textBox1.TabIndex = 154;
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
            this.GC.ResumeLayout(false);
            this.GC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewNote)).EndInit();
            this.LB.ResumeLayout(false);
            this.LB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewDT)).EndInit();
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
        private System.Windows.Forms.TextBox textBox1;
    }
}