namespace EyeCT4Participation
{
    partial class Login
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
            this.usernameTB = new System.Windows.Forms.TextBox();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.loginBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.accounttypeCB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.registerBTN = new System.Windows.Forms.Button();
            this.addressTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cityTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.phonenumberTB = new System.Windows.Forms.TextBox();
            this.carCKB = new System.Windows.Forms.CheckBox();
            this.licenceCKB = new System.Windows.Forms.CheckBox();
            this.fingerprintCKB = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // usernameTB
            // 
            this.usernameTB.Location = new System.Drawing.Point(118, 145);
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.Size = new System.Drawing.Size(128, 20);
            this.usernameTB.TabIndex = 0;
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(118, 171);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(128, 20);
            this.passwordTB.TabIndex = 1;
            // 
            // loginBTN
            // 
            this.loginBTN.Location = new System.Drawing.Point(42, 347);
            this.loginBTN.Name = "loginBTN";
            this.loginBTN.Size = new System.Drawing.Size(99, 23);
            this.loginBTN.TabIndex = 2;
            this.loginBTN.Text = "Login";
            this.loginBTN.UseVisualStyleBackColor = true;
            this.loginBTN.Click += new System.EventHandler(this.loginBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "EyeCT4Participation";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(2, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(407, 20);
            this.textBox1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "User Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Password:";
            // 
            // accounttypeCB
            // 
            this.accounttypeCB.FormattingEnabled = true;
            this.accounttypeCB.Items.AddRange(new object[] {
            "Admin",
            "Volunteer",
            "Needy"});
            this.accounttypeCB.Location = new System.Drawing.Point(118, 118);
            this.accounttypeCB.Name = "accounttypeCB";
            this.accounttypeCB.Size = new System.Drawing.Size(128, 21);
            this.accounttypeCB.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Account type:";
            // 
            // registerBTN
            // 
            this.registerBTN.Location = new System.Drawing.Point(147, 347);
            this.registerBTN.Name = "registerBTN";
            this.registerBTN.Size = new System.Drawing.Size(99, 23);
            this.registerBTN.TabIndex = 10;
            this.registerBTN.Text = "Register";
            this.registerBTN.UseVisualStyleBackColor = true;
            this.registerBTN.Click += new System.EventHandler(this.registerBTN_Click);
            // 
            // addressTB
            // 
            this.addressTB.Location = new System.Drawing.Point(118, 197);
            this.addressTB.Name = "addressTB";
            this.addressTB.Size = new System.Drawing.Size(128, 20);
            this.addressTB.TabIndex = 11;
            this.addressTB.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Address:";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "City:";
            this.label6.Visible = false;
            // 
            // cityTB
            // 
            this.cityTB.Location = new System.Drawing.Point(118, 223);
            this.cityTB.Name = "cityTB";
            this.cityTB.Size = new System.Drawing.Size(128, 20);
            this.cityTB.TabIndex = 13;
            this.cityTB.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Phone number:";
            this.label7.Visible = false;
            // 
            // phonenumberTB
            // 
            this.phonenumberTB.Location = new System.Drawing.Point(118, 249);
            this.phonenumberTB.Name = "phonenumberTB";
            this.phonenumberTB.Size = new System.Drawing.Size(128, 20);
            this.phonenumberTB.TabIndex = 15;
            this.phonenumberTB.Visible = false;
            // 
            // carCKB
            // 
            this.carCKB.AutoSize = true;
            this.carCKB.Location = new System.Drawing.Point(118, 321);
            this.carCKB.Name = "carCKB";
            this.carCKB.Size = new System.Drawing.Size(42, 17);
            this.carCKB.TabIndex = 17;
            this.carCKB.Text = "Car";
            this.carCKB.UseVisualStyleBackColor = true;
            this.carCKB.Visible = false;
            // 
            // licenceCKB
            // 
            this.licenceCKB.AutoSize = true;
            this.licenceCKB.Location = new System.Drawing.Point(118, 298);
            this.licenceCKB.Name = "licenceCKB";
            this.licenceCKB.Size = new System.Drawing.Size(64, 17);
            this.licenceCKB.TabIndex = 18;
            this.licenceCKB.Text = "Licence";
            this.licenceCKB.UseVisualStyleBackColor = true;
            this.licenceCKB.Visible = false;
            // 
            // fingerprintCKB
            // 
            this.fingerprintCKB.AutoSize = true;
            this.fingerprintCKB.Location = new System.Drawing.Point(118, 275);
            this.fingerprintCKB.Name = "fingerprintCKB";
            this.fingerprintCKB.Size = new System.Drawing.Size(116, 17);
            this.fingerprintCKB.TabIndex = 19;
            this.fingerprintCKB.Text = "Fingerprint scanner";
            this.fingerprintCKB.UseVisualStyleBackColor = true;
            this.fingerprintCKB.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 384);
            this.Controls.Add(this.carCKB);
            this.Controls.Add(this.fingerprintCKB);
            this.Controls.Add(this.licenceCKB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.phonenumberTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cityTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addressTB);
            this.Controls.Add(this.registerBTN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.accounttypeCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginBTN);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.usernameTB);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernameTB;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.Button loginBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox accounttypeCB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button registerBTN;
        private System.Windows.Forms.TextBox addressTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cityTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox phonenumberTB;
        private System.Windows.Forms.CheckBox carCKB;
        private System.Windows.Forms.CheckBox licenceCKB;
        private System.Windows.Forms.CheckBox fingerprintCKB;
    }
}