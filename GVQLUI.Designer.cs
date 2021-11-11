
namespace Assignment2
{
    partial class GVQLUI
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
            this.GVQLLogo = new System.Windows.Forms.Label();
            this.Masocanbo = new System.Windows.Forms.Label();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.GVQLTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.GVQLTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // GVQLLogo
            // 
            this.GVQLLogo.AutoSize = true;
            this.GVQLLogo.Font = new System.Drawing.Font("Arial Black", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GVQLLogo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GVQLLogo.Location = new System.Drawing.Point(12, 19);
            this.GVQLLogo.Name = "GVQLLogo";
            this.GVQLLogo.Size = new System.Drawing.Size(141, 54);
            this.GVQLLogo.TabIndex = 14;
            this.GVQLLogo.Text = "GVQL";
            // 
            // Masocanbo
            // 
            this.Masocanbo.AutoSize = true;
            this.Masocanbo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Masocanbo.Location = new System.Drawing.Point(932, 19);
            this.Masocanbo.Name = "Masocanbo";
            this.Masocanbo.Size = new System.Drawing.Size(67, 23);
            this.Masocanbo.TabIndex = 62;
            this.Masocanbo.Text = "MSCB";
            this.Masocanbo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LogOutButton
            // 
            this.LogOutButton.Location = new System.Drawing.Point(914, 56);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(124, 54);
            this.LogOutButton.TabIndex = 63;
            this.LogOutButton.Text = "Log Out";
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // GVQLTab
            // 
            this.GVQLTab.Controls.Add(this.tabPage1);
            this.GVQLTab.Controls.Add(this.tabPage2);
            this.GVQLTab.Location = new System.Drawing.Point(0, 103);
            this.GVQLTab.Name = "GVQLTab";
            this.GVQLTab.SelectedIndex = 0;
            this.GVQLTab.Size = new System.Drawing.Size(1059, 650);
            this.GVQLTab.TabIndex = 64;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1051, 621);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "QLMH";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(822, 523);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // GVQLUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1060, 756);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.GVQLTab);
            this.Controls.Add(this.Masocanbo);
            this.Controls.Add(this.GVQLLogo);
            this.Name = "GVQLUI";
            this.GVQLTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GVQLLogo;
        private System.Windows.Forms.Label Masocanbo;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.TabControl GVQLTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}