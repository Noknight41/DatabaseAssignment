
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.STT = new System.Windows.Forms.ComboBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GVQLLogo = new System.Windows.Forms.Label();
            this.Note = new System.Windows.Forms.Button();
            this.Masosinhvien = new System.Windows.Forms.Label();
            this.SVControl.SuspendLayout();
            this.GC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewNote)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SVControl
            // 
            this.SVControl.Controls.Add(this.GC);
            this.SVControl.Controls.Add(this.tabPage1);
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
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.STT);
            this.tabPage1.Controls.Add(this.maskedTextBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1108, 625);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Làm bài";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(389, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 24);
            this.label2.TabIndex = 153;
            this.label2.Text = "Thời gian";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(891, 9);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 43);
            this.button1.TabIndex = 152;
            this.button1.Text = "Nộp bài";
            this.button1.UseVisualStyleBackColor = true;
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
            this.STT.Location = new System.Drawing.Point(119, 16);
            this.STT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.STT.Name = "STT";
            this.STT.Size = new System.Drawing.Size(60, 28);
            this.STT.TabIndex = 150;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(149, 565);
            this.maskedTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(883, 27);
            this.maskedTextBox1.TabIndex = 149;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 567);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 24);
            this.label1.TabIndex = 148;
            this.label1.Text = "Trả lời";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(27, 60);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1005, 468);
            this.richTextBox1.TabIndex = 147;
            this.richTextBox1.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 146;
            this.label3.Text = "Câu hỏi";
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
            this.GC.ResumeLayout(false);
            this.GC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewNote)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
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
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox STT;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label GVQLLogo;
        private System.Windows.Forms.Button Note;
        private System.Windows.Forms.Label Masosinhvien;
        private System.Windows.Forms.Button N_EB;
    }
}