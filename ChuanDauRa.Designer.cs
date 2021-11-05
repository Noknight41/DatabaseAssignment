
namespace Assignment2
{
    partial class ChuanDauRa
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
            this.ViewCDR = new System.Windows.Forms.DataGridView();
            this.MMH = new System.Windows.Forms.TextBox();
            this.MHID = new System.Windows.Forms.Label();
            this.STT = new System.Windows.Forms.TextBox();
            this.Sothutu = new System.Windows.Forms.Label();
            this.CDRName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ViewCDR)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewCDR
            // 
            this.ViewCDR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewCDR.Location = new System.Drawing.Point(287, 12);
            this.ViewCDR.Name = "ViewCDR";
            this.ViewCDR.RowHeadersWidth = 51;
            this.ViewCDR.RowTemplate.Height = 24;
            this.ViewCDR.Size = new System.Drawing.Size(553, 450);
            this.ViewCDR.TabIndex = 1;
            // 
            // MMH
            // 
            this.MMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MMH.Location = new System.Drawing.Point(27, 70);
            this.MMH.Name = "MMH";
            this.MMH.Size = new System.Drawing.Size(212, 27);
            this.MMH.TabIndex = 9;
            // 
            // MHID
            // 
            this.MHID.AutoSize = true;
            this.MHID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MHID.Location = new System.Drawing.Point(23, 35);
            this.MHID.Name = "MHID";
            this.MHID.Size = new System.Drawing.Size(118, 23);
            this.MHID.TabIndex = 8;
            this.MHID.Text = "Mã môn học";
            // 
            // STT
            // 
            this.STT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STT.Location = new System.Drawing.Point(27, 154);
            this.STT.Name = "STT";
            this.STT.Size = new System.Drawing.Size(212, 27);
            this.STT.TabIndex = 11;
            // 
            // Sothutu
            // 
            this.Sothutu.AutoSize = true;
            this.Sothutu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sothutu.Location = new System.Drawing.Point(23, 119);
            this.Sothutu.Name = "Sothutu";
            this.Sothutu.Size = new System.Drawing.Size(47, 23);
            this.Sothutu.TabIndex = 10;
            this.Sothutu.Text = "STT";
            // 
            // CDRName
            // 
            this.CDRName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CDRName.Location = new System.Drawing.Point(27, 239);
            this.CDRName.Name = "CDRName";
            this.CDRName.Size = new System.Drawing.Size(212, 27);
            this.CDRName.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tên chuẩn đầu ra";
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(163, 398);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(101, 63);
            this.ExitButton.TabIndex = 17;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(27, 398);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(101, 63);
            this.DeleteButton.TabIndex = 16;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(163, 300);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(101, 63);
            this.Edit.TabIndex = 15;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(27, 300);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(101, 63);
            this.AddButton.TabIndex = 14;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ChuanDauRa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 474);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.CDRName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.STT);
            this.Controls.Add(this.Sothutu);
            this.Controls.Add(this.MMH);
            this.Controls.Add(this.MHID);
            this.Controls.Add(this.ViewCDR);
            this.Name = "ChuanDauRa";
            this.Text = "ChuanDauRa";
            this.Load += new System.EventHandler(this.CDR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ViewCDR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ViewCDR;
        private System.Windows.Forms.TextBox MMH;
        private System.Windows.Forms.Label MHID;
        private System.Windows.Forms.TextBox STT;
        private System.Windows.Forms.Label Sothutu;
        private System.Windows.Forms.TextBox CDRName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button AddButton;
    }
}