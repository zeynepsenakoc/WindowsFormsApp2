namespace WindowsFormsApp2.NewFolder1
{
    partial class frmAuthor
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AuthorName = new System.Windows.Forms.TextBox();
            this.AuthorSurname = new System.Windows.Forms.TextBox();
            this.AuthorDcp = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yazar Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yazar Soyadı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Açıklama:";
            // 
            // AuthorName
            // 
            this.AuthorName.Location = new System.Drawing.Point(221, 26);
            this.AuthorName.Name = "AuthorName";
            this.AuthorName.Size = new System.Drawing.Size(185, 20);
            this.AuthorName.TabIndex = 3;
            // 
            // AuthorSurname
            // 
            this.AuthorSurname.Location = new System.Drawing.Point(221, 65);
            this.AuthorSurname.Name = "AuthorSurname";
            this.AuthorSurname.Size = new System.Drawing.Size(185, 20);
            this.AuthorSurname.TabIndex = 4;
            // 
            // AuthorDcp
            // 
            this.AuthorDcp.Location = new System.Drawing.Point(221, 113);
            this.AuthorDcp.Name = "AuthorDcp";
            this.AuthorDcp.Size = new System.Drawing.Size(185, 215);
            this.AuthorDcp.TabIndex = 5;
            this.AuthorDcp.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(221, 358);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(184, 29);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // frmAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.AuthorDcp);
            this.Controls.Add(this.AuthorSurname);
            this.Controls.Add(this.AuthorName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAuthor";
            this.Text = "frmAuthor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AuthorName;
        private System.Windows.Forms.TextBox AuthorSurname;
        private System.Windows.Forms.RichTextBox AuthorDcp;
        private System.Windows.Forms.Button btnSave;
    }
}