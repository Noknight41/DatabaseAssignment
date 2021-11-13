
namespace Assignment2
{
    partial class SVUI
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
            this.LogOutButton = new System.Windows.Forms.Button();
            this.Masosinhvien = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.GVQLLogo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.STT = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogOutButton
            // 
            this.LogOutButton.Location = new System.Drawing.Point(710, 35);
            this.LogOutButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(93, 44);
            this.LogOutButton.TabIndex = 65;
            this.LogOutButton.Text = "Log Out";
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // Masosinhvien
            // 
            this.Masosinhvien.AutoSize = true;
            this.Masosinhvien.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Masosinhvien.Location = new System.Drawing.Point(738, 14);
            this.Masosinhvien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Masosinhvien.Name = "Masosinhvien";
            this.Masosinhvien.Size = new System.Drawing.Size(54, 18);
            this.Masosinhvien.TabIndex = 64;
            this.Masosinhvien.Text = "MSSV";
            this.Masosinhvien.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.tabControl1.Location = new System.Drawing.Point(2, 76);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(801, 560);
            this.tabControl1.TabIndex = 66;
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
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(793, 530);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Làm bài";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(793, 530);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ghi chú";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // GVQLLogo
            // 
            this.GVQLLogo.AutoSize = true;
            this.GVQLLogo.Font = new System.Drawing.Font("Arial Black", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GVQLLogo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GVQLLogo.Location = new System.Drawing.Point(19, 19);
            this.GVQLLogo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GVQLLogo.Name = "GVQLLogo";
            this.GVQLLogo.Size = new System.Drawing.Size(63, 42);
            this.GVQLLogo.TabIndex = 67;
            this.GVQLLogo.Text = "SV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 19);
            this.label3.TabIndex = 146;
            this.label3.Text = "Câu hỏi";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(20, 49);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(755, 381);
            this.richTextBox1.TabIndex = 147;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 461);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 19);
            this.label1.TabIndex = 148;
            this.label1.Text = "Trả lời";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(112, 459);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(663, 23);
            this.maskedTextBox1.TabIndex = 149;
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
            this.STT.Location = new System.Drawing.Point(89, 13);
            this.STT.Margin = new System.Windows.Forms.Padding(2);
            this.STT.Name = "STT";
            this.STT.Size = new System.Drawing.Size(46, 25);
            this.STT.TabIndex = 150;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(668, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 35);
            this.button1.TabIndex = 152;
            this.button1.Text = "Nộp bài";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(292, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 153;
            this.label2.Text = "Thời gian";
            // 
            // SVUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(812, 643);
            this.Controls.Add(this.GVQLLogo);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.Masosinhvien);
            this.Enabled = false;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SVUI";
            this.Text = "SVUI";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.Label Masosinhvien;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label GVQLLogo;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox STT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}