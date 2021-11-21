
namespace Assignment2
{
    partial class XDT
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
            this.CHTextArea = new System.Windows.Forms.RichTextBox();
            this.sadsda = new System.Windows.Forms.Label();
            this.STTCB = new System.Windows.Forms.ComboBox();
            this.Exit = new System.Windows.Forms.Button();
            this.XCH_B = new System.Windows.Forms.Button();
            this.MDTLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CHTextArea
            // 
            this.CHTextArea.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHTextArea.Location = new System.Drawing.Point(17, 117);
            this.CHTextArea.Name = "CHTextArea";
            this.CHTextArea.ReadOnly = true;
            this.CHTextArea.Size = new System.Drawing.Size(745, 463);
            this.CHTextArea.TabIndex = 0;
            this.CHTextArea.Text = "";
            // 
            // sadsda
            // 
            this.sadsda.AutoSize = true;
            this.sadsda.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sadsda.Location = new System.Drawing.Point(26, 71);
            this.sadsda.Name = "sadsda";
            this.sadsda.Size = new System.Drawing.Size(49, 24);
            this.sadsda.TabIndex = 155;
            this.sadsda.Text = "STT";
            // 
            // STTCB
            // 
            this.STTCB.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STTCB.FormattingEnabled = true;
            this.STTCB.Location = new System.Drawing.Point(95, 68);
            this.STTCB.Name = "STTCB";
            this.STTCB.Size = new System.Drawing.Size(121, 32);
            this.STTCB.TabIndex = 156;
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(612, 64);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(150, 37);
            this.Exit.TabIndex = 157;
            this.Exit.Text = "Hoàn thành";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // XCH_B
            // 
            this.XCH_B.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XCH_B.Location = new System.Drawing.Point(250, 64);
            this.XCH_B.Name = "XCH_B";
            this.XCH_B.Size = new System.Drawing.Size(140, 37);
            this.XCH_B.TabIndex = 158;
            this.XCH_B.Text = "Xem";
            this.XCH_B.UseVisualStyleBackColor = true;
            this.XCH_B.Click += new System.EventHandler(this.XCH_B_Click);
            // 
            // MDTLabel
            // 
            this.MDTLabel.AutoSize = true;
            this.MDTLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MDTLabel.Location = new System.Drawing.Point(358, 19);
            this.MDTLabel.Name = "MDTLabel";
            this.MDTLabel.Size = new System.Drawing.Size(54, 24);
            this.MDTLabel.TabIndex = 159;
            this.MDTLabel.Text = "MDT";
            // 
            // XDT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 590);
            this.Controls.Add(this.MDTLabel);
            this.Controls.Add(this.XCH_B);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.STTCB);
            this.Controls.Add(this.sadsda);
            this.Controls.Add(this.CHTextArea);
            this.Name = "XDT";
            this.Text = "XDT";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.XDT_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox CHTextArea;
        private System.Windows.Forms.Label sadsda;
        private System.Windows.Forms.ComboBox STTCB;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button XCH_B;
        private System.Windows.Forms.Label MDTLabel;
    }
}