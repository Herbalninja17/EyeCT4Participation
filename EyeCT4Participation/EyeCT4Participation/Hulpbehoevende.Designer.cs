namespace EyeCT4Participation
{
    partial class Hulpbehoevende
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
            this.reviewBTN = new System.Windows.Forms.Button();
            this.logoutBTN = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.reviewVolunteerBTN = new System.Windows.Forms.Button();
            this.LBvol3 = new System.Windows.Forms.ListBox();
            this.LBvol2 = new System.Windows.Forms.ListBox();
            this.LBvol1 = new System.Windows.Forms.ListBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.contentTB3 = new System.Windows.Forms.TextBox();
            this.contentTB2 = new System.Windows.Forms.TextBox();
            this.contentTB1 = new System.Windows.Forms.TextBox();
            this.submitBTN = new System.Windows.Forms.Button();
            this.profileBTN = new System.Windows.Forms.Button();
            this.appointmentBTN = new System.Windows.Forms.Button();
            this.requestsBTN = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reviewBTN
            // 
            this.reviewBTN.Location = new System.Drawing.Point(12, 12);
            this.reviewBTN.Name = "reviewBTN";
            this.reviewBTN.Size = new System.Drawing.Size(143, 50);
            this.reviewBTN.TabIndex = 0;
            this.reviewBTN.Text = "My reviews";
            this.reviewBTN.UseVisualStyleBackColor = true;
            this.reviewBTN.Click += new System.EventHandler(this.reviewBTN_Click);
            // 
            // logoutBTN
            // 
            this.logoutBTN.Location = new System.Drawing.Point(12, 399);
            this.logoutBTN.Name = "logoutBTN";
            this.logoutBTN.Size = new System.Drawing.Size(143, 44);
            this.logoutBTN.TabIndex = 2;
            this.logoutBTN.Text = "Logout";
            this.logoutBTN.UseVisualStyleBackColor = true;
            this.logoutBTN.Click += new System.EventHandler(this.logoutBTN_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.groupBox1.Controls.Add(this.reviewVolunteerBTN);
            this.groupBox1.Controls.Add(this.LBvol3);
            this.groupBox1.Controls.Add(this.LBvol2);
            this.groupBox1.Controls.Add(this.LBvol1);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.contentTB3);
            this.groupBox1.Controls.Add(this.contentTB2);
            this.groupBox1.Controls.Add(this.contentTB1);
            this.groupBox1.Controls.Add(this.submitBTN);
            this.groupBox1.Location = new System.Drawing.Point(171, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(618, 431);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "My requests/reviews";
            // 
            // reviewVolunteerBTN
            // 
            this.reviewVolunteerBTN.Location = new System.Drawing.Point(476, 77);
            this.reviewVolunteerBTN.Name = "reviewVolunteerBTN";
            this.reviewVolunteerBTN.Size = new System.Drawing.Size(135, 52);
            this.reviewVolunteerBTN.TabIndex = 35;
            this.reviewVolunteerBTN.Text = "Review selected volunteer";
            this.reviewVolunteerBTN.UseVisualStyleBackColor = true;
            this.reviewVolunteerBTN.Click += new System.EventHandler(this.reviewVolunteerBTN_Click);
            // 
            // LBvol3
            // 
            this.LBvol3.FormattingEnabled = true;
            this.LBvol3.Location = new System.Drawing.Point(351, 317);
            this.LBvol3.Name = "LBvol3";
            this.LBvol3.Size = new System.Drawing.Size(119, 108);
            this.LBvol3.TabIndex = 34;
            this.LBvol3.Click += new System.EventHandler(this.LBvol3_Click);
            // 
            // LBvol2
            // 
            this.LBvol2.FormattingEnabled = true;
            this.LBvol2.Location = new System.Drawing.Point(351, 182);
            this.LBvol2.Name = "LBvol2";
            this.LBvol2.Size = new System.Drawing.Size(119, 108);
            this.LBvol2.TabIndex = 33;
            this.LBvol2.Click += new System.EventHandler(this.LBvol2_Click);
            // 
            // LBvol1
            // 
            this.LBvol1.FormattingEnabled = true;
            this.LBvol1.Location = new System.Drawing.Point(351, 43);
            this.LBvol1.Name = "LBvol1";
            this.LBvol1.Size = new System.Drawing.Size(119, 108);
            this.LBvol1.TabIndex = 32;
            this.LBvol1.Click += new System.EventHandler(this.LBvol1_Click);
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox6.Location = new System.Drawing.Point(351, 293);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.ShortcutsEnabled = false;
            this.textBox6.Size = new System.Drawing.Size(119, 23);
            this.textBox6.TabIndex = 22;
            this.textBox6.Text = "Interested volunteers:";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox5.Location = new System.Drawing.Point(351, 159);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.ShortcutsEnabled = false;
            this.textBox5.Size = new System.Drawing.Size(119, 23);
            this.textBox5.TabIndex = 21;
            this.textBox5.Text = "Interested volunteers:";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(476, 193);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(135, 52);
            this.button8.TabIndex = 20;
            this.button8.Text = "Report selected volunteer";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(476, 135);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(135, 52);
            this.button6.TabIndex = 19;
            this.button6.Text = "Initiate chat with selected volunteer";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox4.Location = new System.Drawing.Point(351, 19);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.ShortcutsEnabled = false;
            this.textBox4.Size = new System.Drawing.Size(119, 23);
            this.textBox4.TabIndex = 11;
            this.textBox4.Text = "Interested volunteers:";
            // 
            // contentTB3
            // 
            this.contentTB3.Location = new System.Drawing.Point(17, 295);
            this.contentTB3.Multiline = true;
            this.contentTB3.Name = "contentTB3";
            this.contentTB3.ReadOnly = true;
            this.contentTB3.ShortcutsEnabled = false;
            this.contentTB3.Size = new System.Drawing.Size(328, 130);
            this.contentTB3.TabIndex = 10;
            // 
            // contentTB2
            // 
            this.contentTB2.Location = new System.Drawing.Point(17, 159);
            this.contentTB2.Multiline = true;
            this.contentTB2.Name = "contentTB2";
            this.contentTB2.ReadOnly = true;
            this.contentTB2.ShortcutsEnabled = false;
            this.contentTB2.Size = new System.Drawing.Size(328, 130);
            this.contentTB2.TabIndex = 9;
            // 
            // contentTB1
            // 
            this.contentTB1.Location = new System.Drawing.Point(17, 21);
            this.contentTB1.Multiline = true;
            this.contentTB1.Name = "contentTB1";
            this.contentTB1.ReadOnly = true;
            this.contentTB1.ShortcutsEnabled = false;
            this.contentTB1.Size = new System.Drawing.Size(328, 130);
            this.contentTB1.TabIndex = 8;
            // 
            // submitBTN
            // 
            this.submitBTN.Location = new System.Drawing.Point(476, 19);
            this.submitBTN.Name = "submitBTN";
            this.submitBTN.Size = new System.Drawing.Size(135, 52);
            this.submitBTN.TabIndex = 5;
            this.submitBTN.Text = "Submit request";
            this.submitBTN.UseVisualStyleBackColor = true;
            this.submitBTN.Click += new System.EventHandler(this.submitBTN_Click);
            // 
            // profileBTN
            // 
            this.profileBTN.Location = new System.Drawing.Point(12, 68);
            this.profileBTN.Name = "profileBTN";
            this.profileBTN.Size = new System.Drawing.Size(143, 50);
            this.profileBTN.TabIndex = 5;
            this.profileBTN.Text = "My profile";
            this.profileBTN.UseVisualStyleBackColor = true;
            this.profileBTN.Click += new System.EventHandler(this.profileBTN_Click);
            // 
            // appointmentBTN
            // 
            this.appointmentBTN.Location = new System.Drawing.Point(12, 124);
            this.appointmentBTN.Name = "appointmentBTN";
            this.appointmentBTN.Size = new System.Drawing.Size(143, 50);
            this.appointmentBTN.TabIndex = 6;
            this.appointmentBTN.Text = "My appointments";
            this.appointmentBTN.UseVisualStyleBackColor = true;
            this.appointmentBTN.Click += new System.EventHandler(this.appointmentBTN_Click);
            // 
            // requestsBTN
            // 
            this.requestsBTN.Location = new System.Drawing.Point(12, 180);
            this.requestsBTN.Name = "requestsBTN";
            this.requestsBTN.Size = new System.Drawing.Size(143, 50);
            this.requestsBTN.TabIndex = 7;
            this.requestsBTN.Text = "My requests";
            this.requestsBTN.UseVisualStyleBackColor = true;
            this.requestsBTN.Click += new System.EventHandler(this.requestsBTN_Click);
            // 
            // Hulpbehoevende
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 458);
            this.Controls.Add(this.requestsBTN);
            this.Controls.Add(this.appointmentBTN);
            this.Controls.Add(this.profileBTN);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.logoutBTN);
            this.Controls.Add(this.reviewBTN);
            this.Name = "Hulpbehoevende";
            this.Text = "Welkom hulpbehoevende";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button reviewBTN;
        private System.Windows.Forms.Button logoutBTN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox contentTB3;
        private System.Windows.Forms.TextBox contentTB2;
        private System.Windows.Forms.TextBox contentTB1;
        private System.Windows.Forms.Button submitBTN;
        private System.Windows.Forms.Button profileBTN;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button appointmentBTN;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button requestsBTN;
        private System.Windows.Forms.ListBox LBvol3;
        private System.Windows.Forms.ListBox LBvol2;
        private System.Windows.Forms.ListBox LBvol1;
        private System.Windows.Forms.Button reviewVolunteerBTN;
    }
}

