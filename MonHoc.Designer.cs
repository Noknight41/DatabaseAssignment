
namespace Assignment2
{
    partial class MonHoc
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
            this.ViewMonHoc = new System.Windows.Forms.DataGridView();
            this.MMH = new System.Windows.Forms.TextBox();
            this.MHID = new System.Windows.Forms.Label();
            this.MHN = new System.Windows.Forms.TextBox();
            this.MHname = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ViewMonHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewMonHoc
            // 
            this.ViewMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewMonHoc.Location = new System.Drawing.Point(291, 12);
            this.ViewMonHoc.Name = "ViewMonHoc";
            this.ViewMonHoc.RowHeadersWidth = 51;
            this.ViewMonHoc.RowTemplate.Height = 24;
            this.ViewMonHoc.Size = new System.Drawing.Size(418, 406);
            this.ViewMonHoc.TabIndex = 0;
            this.ViewMonHoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ViewMonHoc_CellContentClick);
            // 
            // MMH
            // 
            this.MMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MMH.Location = new System.Drawing.Point(32, 75);
            this.MMH.Name = "MMH";
            this.MMH.Size = new System.Drawing.Size(212, 27);
            this.MMH.TabIndex = 7;
            // 
            // MHID
            // 
            this.MHID.AutoSize = true;
            this.MHID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MHID.Location = new System.Drawing.Point(28, 40);
            this.MHID.Name = "MHID";
            this.MHID.Size = new System.Drawing.Size(118, 23);
            this.MHID.TabIndex = 6;
            this.MHID.Text = "Mã môn học";
            // 
            // MHN
            // 
            this.MHN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MHN.Location = new System.Drawing.Point(32, 171);
            this.MHN.Name = "MHN";
            this.MHN.Size = new System.Drawing.Size(212, 27);
            this.MHN.TabIndex = 9;
            // 
            // MHname
            // 
            this.MHname.AutoSize = true;
            this.MHname.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MHname.Location = new System.Drawing.Point(28, 131);
            this.MHname.Name = "MHname";
            this.MHname.Size = new System.Drawing.Size(123, 23);
            this.MHname.TabIndex = 8;
            this.MHname.Text = "Tên môn học";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(30, 257);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(101, 63);
            this.AddButton.TabIndex = 10;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(166, 257);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(101, 63);
            this.Edit.TabIndex = 11;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(30, 355);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(101, 63);
            this.DeleteButton.TabIndex = 12;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(166, 355);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(101, 63);
            this.ExitButton.TabIndex = 13;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 430);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.MHN);
            this.Controls.Add(this.MHname);
            this.Controls.Add(this.MMH);
            this.Controls.Add(this.MHID);
            this.Controls.Add(this.ViewMonHoc);
            this.Name = "MonHoc";
            this.Text = "MonHoc";
            this.Load += new System.EventHandler(this.MonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ViewMonHoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ViewMonHoc;
        private System.Windows.Forms.TextBox MMH;
        private System.Windows.Forms.Label MHID;
        private System.Windows.Forms.TextBox MHN;
        private System.Windows.Forms.Label MHname;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ExitButton;
    }
}