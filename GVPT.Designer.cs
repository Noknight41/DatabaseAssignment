
namespace Assignment2
{
    partial class GVPT
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
            this.AddButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ViewGVPT = new System.Windows.Forms.DataGridView();
            this.MHID = new System.Windows.Forms.Label();
            this.MMH = new System.Windows.Forms.TextBox();
            this.Masocanbo = new System.Windows.Forms.Label();
            this.MSCB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ViewGVPT)).BeginInit();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(37, 233);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(101, 63);
            this.AddButton.TabIndex = 11;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(170, 233);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(101, 63);
            this.EditButton.TabIndex = 12;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.Edit_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(37, 327);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(101, 63);
            this.DeleteButton.TabIndex = 13;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(170, 327);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(101, 63);
            this.ExitButton.TabIndex = 14;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ViewGVPT
            // 
            this.ViewGVPT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewGVPT.Location = new System.Drawing.Point(334, 30);
            this.ViewGVPT.Name = "ViewGVPT";
            this.ViewGVPT.RowHeadersWidth = 51;
            this.ViewGVPT.RowTemplate.Height = 24;
            this.ViewGVPT.Size = new System.Drawing.Size(430, 364);
            this.ViewGVPT.TabIndex = 15;
            this.ViewGVPT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ViewGVPT_CellContentClick);
            // 
            // MHID
            // 
            this.MHID.AutoSize = true;
            this.MHID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MHID.Location = new System.Drawing.Point(33, 139);
            this.MHID.Name = "MHID";
            this.MHID.Size = new System.Drawing.Size(205, 23);
            this.MHID.TabIndex = 16;
            this.MHID.Text = "Mã môn học phụ trách";
            // 
            // MMH
            // 
            this.MMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MMH.Location = new System.Drawing.Point(37, 179);
            this.MMH.Name = "MMH";
            this.MMH.Size = new System.Drawing.Size(234, 27);
            this.MMH.TabIndex = 17;
            // 
            // Masocanbo
            // 
            this.Masocanbo.AutoSize = true;
            this.Masocanbo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Masocanbo.Location = new System.Drawing.Point(33, 30);
            this.Masocanbo.Name = "Masocanbo";
            this.Masocanbo.Size = new System.Drawing.Size(67, 23);
            this.Masocanbo.TabIndex = 18;
            this.Masocanbo.Text = "MSCB";
            // 
            // MSCB
            // 
            this.MSCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MSCB.Location = new System.Drawing.Point(37, 78);
            this.MSCB.Name = "MSCB";
            this.MSCB.Size = new System.Drawing.Size(234, 27);
            this.MSCB.TabIndex = 19;
            // 
            // GVPT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 416);
            this.Controls.Add(this.MSCB);
            this.Controls.Add(this.Masocanbo);
            this.Controls.Add(this.MMH);
            this.Controls.Add(this.MHID);
            this.Controls.Add(this.ViewGVPT);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AddButton);
            this.Name = "GVPT";
            this.Text = "GVPT";
            this.Load += new System.EventHandler(this.GVPT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ViewGVPT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.DataGridView ViewGVPT;
        private System.Windows.Forms.Label MHID;
        private System.Windows.Forms.TextBox MMH;
        private System.Windows.Forms.Label Masocanbo;
        private System.Windows.Forms.TextBox MSCB;
    }
}