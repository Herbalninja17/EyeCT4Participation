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
            this.SuspendLayout();
            // 
            // usernameTB
            // 
            this.usernameTB.Location = new System.Drawing.Point(42, 138);
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.Size = new System.Drawing.Size(100, 20);
            this.usernameTB.TabIndex = 0;
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(42, 174);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(100, 20);
            this.passwordTB.TabIndex = 1;
            // 
            // loginBTN
            // 
            this.loginBTN.Location = new System.Drawing.Point(42, 347);
            this.loginBTN.Name = "loginBTN";
            this.loginBTN.Size = new System.Drawing.Size(100, 23);
            this.loginBTN.TabIndex = 2;
            this.loginBTN.Text = "Login";
            this.loginBTN.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "EyeCT4Participation";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 436);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginBTN);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.usernameTB);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernameTB;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.Button loginBTN;
        private System.Windows.Forms.Label label1;
    }
}