
namespace Assignment2
{
    partial class LDT
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
            this.MDTLabel = new System.Windows.Forms.Label();
            this.XCH_B = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.STTCB = new System.Windows.Forms.ComboBox();
            this.sadsda = new System.Windows.Forms.Label();
            this.CHTextArea = new System.Windows.Forms.RichTextBox();
            this.NTL = new System.Windows.Forms.TextBox();
            this.asdaasvf = new System.Windows.Forms.Label();
            this.NTL_B = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MDTLabel
            // 
            this.MDTLabel.AutoSize = true;
            this.MDTLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MDTLabel.Location = new System.Drawing.Point(369, 9);
            this.MDTLabel.Name = "MDTLabel";
            this.MDTLabel.Size = new System.Drawing.Size(54, 24);
            this.MDTLabel.TabIndex = 165;
            this.MDTLabel.Text = "MDT";
            // 
            // XCH_B
            // 
            this.XCH_B.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XCH_B.Location = new System.Drawing.Point(252, 55);
            this.XCH_B.Name = "XCH_B";
            this.XCH_B.Size = new System.Drawing.Size(140, 37);
            this.XCH_B.TabIndex = 164;
            this.XCH_B.Text = "Xem";
            this.XCH_B.UseVisualStyleBackColor = true;
            this.XCH_B.Click += new System.EventHandler(this.XCH_B_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(623, 54);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(150, 37);
            this.Exit.TabIndex = 163;
            this.Exit.Text = "Hoàn thành";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // STTCB
            // 
            this.STTCB.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STTCB.FormattingEnabled = true;
            this.STTCB.Location = new System.Drawing.Point(106, 58);
            this.STTCB.Name = "STTCB";
            this.STTCB.Size = new System.Drawing.Size(121, 31);
            this.STTCB.TabIndex = 162;
            // 
            // sadsda
            // 
            this.sadsda.AutoSize = true;
            this.sadsda.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sadsda.Location = new System.Drawing.Point(37, 61);
            this.sadsda.Name = "sadsda";
            this.sadsda.Size = new System.Drawing.Size(49, 24);
            this.sadsda.TabIndex = 161;
            this.sadsda.Text = "STT";
            // 
            // CHTextArea
            // 
            this.CHTextArea.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHTextArea.Location = new System.Drawing.Point(28, 107);
            this.CHTextArea.Name = "CHTextArea";
            this.CHTextArea.ReadOnly = true;
            this.CHTextArea.Size = new System.Drawing.Size(745, 463);
            this.CHTextArea.TabIndex = 160;
            this.CHTextArea.Text = "";
            // 
            // NTL
            // 
            this.NTL.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NTL.Location = new System.Drawing.Point(124, 587);
            this.NTL.Name = "NTL";
            this.NTL.Size = new System.Drawing.Size(475, 30);
            this.NTL.TabIndex = 166;
            // 
            // asdaasvf
            // 
            this.asdaasvf.AutoSize = true;
            this.asdaasvf.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asdaasvf.Location = new System.Drawing.Point(24, 590);
            this.asdaasvf.Name = "asdaasvf";
            this.asdaasvf.Size = new System.Drawing.Size(71, 24);
            this.asdaasvf.TabIndex = 167;
            this.asdaasvf.Text = "Trả lời";
            // 
            // NTL_B
            // 
            this.NTL_B.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NTL_B.Location = new System.Drawing.Point(633, 580);
            this.NTL_B.Name = "NTL_B";
            this.NTL_B.Size = new System.Drawing.Size(140, 37);
            this.NTL_B.TabIndex = 168;
            this.NTL_B.Text = "Nhập";
            this.NTL_B.UseVisualStyleBackColor = true;
            this.NTL_B.Click += new System.EventHandler(this.NTL_B_Click);
            // 
            // LDT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 641);
            this.Controls.Add(this.NTL_B);
            this.Controls.Add(this.asdaasvf);
            this.Controls.Add(this.NTL);
            this.Controls.Add(this.MDTLabel);
            this.Controls.Add(this.XCH_B);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.STTCB);
            this.Controls.Add(this.sadsda);
            this.Controls.Add(this.CHTextArea);
            this.Name = "LDT";
            this.Text = "LDT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MDTLabel;
        private System.Windows.Forms.Button XCH_B;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.ComboBox STTCB;
        private System.Windows.Forms.Label sadsda;
        private System.Windows.Forms.RichTextBox CHTextArea;
        private System.Windows.Forms.TextBox NTL;
        private System.Windows.Forms.Label asdaasvf;
        private System.Windows.Forms.Button NTL_B;
    }
}