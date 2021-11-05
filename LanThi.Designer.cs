
namespace Assignment2
{
    partial class LanThi
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
            this.ViewLT = new System.Windows.Forms.DataGridView();
            this.LT = new System.Windows.Forms.TextBox();
            this.Masocanbo = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.HK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ViewLT)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewLT
            // 
            this.ViewLT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewLT.Location = new System.Drawing.Point(304, 12);
            this.ViewLT.Name = "ViewLT";
            this.ViewLT.RowHeadersWidth = 51;
            this.ViewLT.RowTemplate.Height = 24;
            this.ViewLT.Size = new System.Drawing.Size(430, 364);
            this.ViewLT.TabIndex = 16;
            this.ViewLT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ViewLT_CellContentClick);
            // 
            // LT
            // 
            this.LT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LT.Location = new System.Drawing.Point(30, 53);
            this.LT.Name = "LT";
            this.LT.Size = new System.Drawing.Size(234, 27);
            this.LT.TabIndex = 27;
            // 
            // Masocanbo
            // 
            this.Masocanbo.AutoSize = true;
            this.Masocanbo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Masocanbo.Location = new System.Drawing.Point(26, 22);
            this.Masocanbo.Name = "Masocanbo";
            this.Masocanbo.Size = new System.Drawing.Size(68, 23);
            this.Masocanbo.TabIndex = 26;
            this.Masocanbo.Text = "Lần thi";
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(163, 316);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(101, 63);
            this.ExitButton.TabIndex = 23;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(30, 318);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(101, 63);
            this.DeleteButton.TabIndex = 22;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(163, 241);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(101, 63);
            this.EditButton.TabIndex = 21;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(30, 244);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(101, 63);
            this.AddButton.TabIndex = 20;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // HK
            // 
            this.HK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HK.Location = new System.Drawing.Point(30, 128);
            this.HK.Name = "HK";
            this.HK.Size = new System.Drawing.Size(234, 27);
            this.HK.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 23);
            this.label1.TabIndex = 28;
            this.label1.Text = "Học kỳ";
            // 
            // NH
            // 
            this.NH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NH.Location = new System.Drawing.Point(30, 198);
            this.NH.Name = "NH";
            this.NH.Size = new System.Drawing.Size(234, 27);
            this.NH.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 23);
            this.label2.TabIndex = 30;
            this.label2.Text = "Năm học";
            // 
            // LanThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 393);
            this.Controls.Add(this.NH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LT);
            this.Controls.Add(this.Masocanbo);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ViewLT);
            this.Name = "LanThi";
            this.Text = "LanThi";
            this.Load += new System.EventHandler(this.LanThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ViewLT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ViewLT;
        private System.Windows.Forms.TextBox LT;
        private System.Windows.Forms.Label Masocanbo;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox HK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NH;
        private System.Windows.Forms.Label label2;
    }
}