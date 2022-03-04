namespace WindowsFormsApp2.NewFolder1
{
    partial class frmRegister
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.MemberName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.MemberSurname = new System.Windows.Forms.Label();
            this.BirthDate = new System.Windows.Forms.Label();
            this.MailAdress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ProfilePic = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PasswoordAgain = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.mskdPhnone = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(119, 25);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 20);
            this.textBox2.TabIndex = 11;
            // 
            // MemberName
            // 
            this.MemberName.AutoSize = true;
            this.MemberName.Location = new System.Drawing.Point(34, 28);
            this.MemberName.Name = "MemberName";
            this.MemberName.Size = new System.Drawing.Size(47, 13);
            this.MemberName.TabIndex = 10;
            this.MemberName.Text = "Üye Adı:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(119, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 13;
            // 
            // MemberSurname
            // 
            this.MemberSurname.AutoSize = true;
            this.MemberSurname.Location = new System.Drawing.Point(34, 63);
            this.MemberSurname.Name = "MemberSurname";
            this.MemberSurname.Size = new System.Drawing.Size(40, 13);
            this.MemberSurname.TabIndex = 12;
            this.MemberSurname.Text = "Soyad:";
            // 
            // BirthDate
            // 
            this.BirthDate.AutoSize = true;
            this.BirthDate.Location = new System.Drawing.Point(34, 93);
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.Size = new System.Drawing.Size(73, 13);
            this.BirthDate.TabIndex = 14;
            this.BirthDate.Text = "Doğum Tarihi:";
            // 
            // MailAdress
            // 
            this.MailAdress.Location = new System.Drawing.Point(119, 135);
            this.MailAdress.Name = "MailAdress";
            this.MailAdress.Size = new System.Drawing.Size(200, 20);
            this.MailAdress.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Mail Adresi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Telefon:";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(119, 223);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(200, 20);
            this.Password.TabIndex = 21;
            this.Password.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Şifre:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // ProfilePic
            // 
            this.ProfilePic.Location = new System.Drawing.Point(119, 312);
            this.ProfilePic.Name = "ProfilePic";
            this.ProfilePic.Size = new System.Drawing.Size(200, 20);
            this.ProfilePic.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Profil Resmi:";
            // 
            // PasswoordAgain
            // 
            this.PasswoordAgain.Location = new System.Drawing.Point(119, 271);
            this.PasswoordAgain.Name = "PasswoordAgain";
            this.PasswoordAgain.Size = new System.Drawing.Size(200, 20);
            this.PasswoordAgain.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Şifre Tekrar:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(119, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 26);
            this.button1.TabIndex = 26;
            this.button1.Text = "Kyadet";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(119, 93);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 27;
            // 
            // mskdPhnone
            // 
            this.mskdPhnone.Location = new System.Drawing.Point(119, 178);
            this.mskdPhnone.Mask = "(999) 000-0000";
            this.mskdPhnone.Name = "mskdPhnone";
            this.mskdPhnone.Size = new System.Drawing.Size(200, 20);
            this.mskdPhnone.TabIndex = 28;
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 450);
            this.Controls.Add(this.mskdPhnone);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PasswoordAgain);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ProfilePic);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MailAdress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BirthDate);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.MemberSurname);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.MemberName);
            this.Name = "frmRegister";
            this.Text = "frmRegister";
            this.Load += new System.EventHandler(this.frmRegister_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label MemberName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label MemberSurname;
        private System.Windows.Forms.Label BirthDate;
        private System.Windows.Forms.TextBox MailAdress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ProfilePic;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PasswoordAgain;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.MaskedTextBox mskdPhnone;
    }
}