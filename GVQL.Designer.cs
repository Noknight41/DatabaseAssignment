
namespace Assignment2
{
    partial class GVQL
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
            this.MSCB = new System.Windows.Forms.TextBox();
            this.Masocanbo = new System.Windows.Forms.Label();
            this.MMH = new System.Windows.Forms.TextBox();
            this.MHID = new System.Windows.Forms.Label();
            this.ViewGVQL = new System.Windows.Forms.DataGridView();
            this.ExitButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ViewGVQL)).BeginInit();
            this.SuspendLayout();
            // 
            // MSCB
            // 
            this.MSCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MSCB.Location = new System.Drawing.Point(39, 91);
            this.MSCB.Name = "MSCB";
            this.MSCB.Size = new System.Drawing.Size(234, 27);
            this.MSCB.TabIndex = 28;
            // 
            // Masocanbo
            // 
            this.Masocanbo.AutoSize = true;
            this.Masocanbo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Masocanbo.Location = new System.Drawing.Point(35, 43);
            this.Masocanbo.Name = "Masocanbo";
            this.Masocanbo.Size = new System.Drawing.Size(67, 23);
            this.Masocanbo.TabIndex = 27;
            this.Masocanbo.Text = "MSCB";
            // 
            // MMH
            // 
            this.MMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MMH.Location = new System.Drawing.Point(39, 192);
            this.MMH.Name = "MMH";
            this.MMH.Size = new System.Drawing.Size(234, 27);
            this.MMH.TabIndex = 26;
            // 
            // MHID
            // 
            this.MHID.AutoSize = true;
            this.MHID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MHID.Location = new System.Drawing.Point(35, 152);
            this.MHID.Name = "MHID";
            this.MHID.Size = new System.Drawing.Size(186, 23);
            this.MHID.TabIndex = 25;
            this.MHID.Text = "Mã môn học quản lý";
            // 
            // ViewGVQL
            // 
            this.ViewGVQL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewGVQL.Location = new System.Drawing.Point(336, 43);
            this.ViewGVQL.Name = "ViewGVQL";
            this.ViewGVQL.RowHeadersWidth = 51;
            this.ViewGVQL.RowTemplate.Height = 24;
            this.ViewGVQL.Size = new System.Drawing.Size(430, 364);
            this.ViewGVQL.TabIndex = 24;
            this.ViewGVQL.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ViewGVQL_CellContentClick);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(172, 340);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(101, 63);
            this.ExitButton.TabIndex = 23;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(39, 340);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(101, 63);
            this.DeleteButton.TabIndex = 22;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(172, 246);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(101, 63);
            this.EditButton.TabIndex = 21;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.Edit_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(39, 246);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(101, 63);
            this.AddButton.TabIndex = 20;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // GVQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 432);
            this.Controls.Add(this.MSCB);
            this.Controls.Add(this.Masocanbo);
            this.Controls.Add(this.MMH);
            this.Controls.Add(this.MHID);
            this.Controls.Add(this.ViewGVQL);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AddButton);
            this.Name = "GVQL";
            this.Text = "GVQL";
            this.Load += new System.EventHandler(this.GVQL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ViewGVQL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MSCB;
        private System.Windows.Forms.Label Masocanbo;
        private System.Windows.Forms.TextBox MMH;
        private System.Windows.Forms.Label MHID;
        private System.Windows.Forms.DataGridView ViewGVQL;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button AddButton;
    }
}