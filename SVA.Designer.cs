
namespace Assignment2
{
    partial class SVA
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
            this.ViewSV = new System.Windows.Forms.DataGridView();
            this.MSSV = new System.Windows.Forms.TextBox();
            this.Masosinhvien = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ViewSV)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewSV
            // 
            this.ViewSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewSV.Location = new System.Drawing.Point(303, 28);
            this.ViewSV.Name = "ViewSV";
            this.ViewSV.RowHeadersWidth = 51;
            this.ViewSV.RowTemplate.Height = 24;
            this.ViewSV.Size = new System.Drawing.Size(304, 274);
            this.ViewSV.TabIndex = 25;
            this.ViewSV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ViewSV_CellContentClick);
            // 
            // MSSV
            // 
            this.MSSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MSSV.Location = new System.Drawing.Point(37, 74);
            this.MSSV.Name = "MSSV";
            this.MSSV.Size = new System.Drawing.Size(234, 27);
            this.MSSV.TabIndex = 35;
            // 
            // Masosinhvien
            // 
            this.Masosinhvien.AutoSize = true;
            this.Masosinhvien.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Masosinhvien.Location = new System.Drawing.Point(33, 26);
            this.Masosinhvien.Name = "Masosinhvien";
            this.Masosinhvien.Size = new System.Drawing.Size(66, 23);
            this.Masosinhvien.TabIndex = 34;
            this.Masosinhvien.Text = "MSSV";
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(37, 228);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(101, 63);
            this.ExitButton.TabIndex = 32;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(170, 133);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(101, 63);
            this.DeleteButton.TabIndex = 31;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(37, 133);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(101, 63);
            this.AddButton.TabIndex = 29;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SVA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 314);
            this.Controls.Add(this.MSSV);
            this.Controls.Add(this.Masosinhvien);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ViewSV);
            this.Name = "SVA";
            this.Text = "SVA";
            this.Load += new System.EventHandler(this.SVA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ViewSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ViewSV;
        private System.Windows.Forms.TextBox MSSV;
        private System.Windows.Forms.Label Masosinhvien;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddButton;
    }
}