namespace EyeCT4Participation
{
    partial class Beheerder
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
            this.reportedcontentBTN = new System.Windows.Forms.Button();
            this.contentGB = new System.Windows.Forms.GroupBox();
            this.ignoreBTN = new System.Windows.Forms.Button();
            this.removeBTN = new System.Windows.Forms.Button();
            this.helprequestsReviewBTN = new System.Windows.Forms.Button();
            this.chatBTN = new System.Windows.Forms.Button();
            this.logoutBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reportedcontentBTN
            // 
            this.reportedcontentBTN.Location = new System.Drawing.Point(13, 28);
            this.reportedcontentBTN.Name = "reportedcontentBTN";
            this.reportedcontentBTN.Size = new System.Drawing.Size(147, 79);
            this.reportedcontentBTN.TabIndex = 0;
            this.reportedcontentBTN.Text = "Reported content";
            this.reportedcontentBTN.UseVisualStyleBackColor = true;
            // 
            // contentGB
            // 
            this.contentGB.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.contentGB.Location = new System.Drawing.Point(191, 28);
            this.contentGB.Name = "contentGB";
            this.contentGB.Size = new System.Drawing.Size(200, 411);
            this.contentGB.TabIndex = 1;
            this.contentGB.TabStop = false;
            this.contentGB.Text = "Content";
            // 
            // ignoreBTN
            // 
            this.ignoreBTN.Location = new System.Drawing.Point(13, 329);
            this.ignoreBTN.Name = "ignoreBTN";
            this.ignoreBTN.Size = new System.Drawing.Size(88, 36);
            this.ignoreBTN.TabIndex = 2;
            this.ignoreBTN.Text = "Ignore selected";
            this.ignoreBTN.UseVisualStyleBackColor = true;
            // 
            // removeBTN
            // 
            this.removeBTN.Location = new System.Drawing.Point(12, 286);
            this.removeBTN.Name = "removeBTN";
            this.removeBTN.Size = new System.Drawing.Size(89, 37);
            this.removeBTN.TabIndex = 3;
            this.removeBTN.Text = "Remove selected";
            this.removeBTN.UseVisualStyleBackColor = true;
            // 
            // helprequestsReviewBTN
            // 
            this.helprequestsReviewBTN.Location = new System.Drawing.Point(13, 201);
            this.helprequestsReviewBTN.Name = "helprequestsReviewBTN";
            this.helprequestsReviewBTN.Size = new System.Drawing.Size(147, 79);
            this.helprequestsReviewBTN.TabIndex = 4;
            this.helprequestsReviewBTN.Text = "Helprequests/reviews";
            this.helprequestsReviewBTN.UseVisualStyleBackColor = true;
            // 
            // chatBTN
            // 
            this.chatBTN.Location = new System.Drawing.Point(13, 116);
            this.chatBTN.Name = "chatBTN";
            this.chatBTN.Size = new System.Drawing.Size(147, 79);
            this.chatBTN.TabIndex = 5;
            this.chatBTN.Text = "Chats";
            this.chatBTN.UseVisualStyleBackColor = true;
            // 
            // logoutBTN
            // 
            this.logoutBTN.Location = new System.Drawing.Point(13, 403);
            this.logoutBTN.Name = "logoutBTN";
            this.logoutBTN.Size = new System.Drawing.Size(88, 36);
            this.logoutBTN.TabIndex = 6;
            this.logoutBTN.Text = "Logout";
            this.logoutBTN.UseVisualStyleBackColor = true;
            // 
            // Beheerder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 465);
            this.Controls.Add(this.logoutBTN);
            this.Controls.Add(this.chatBTN);
            this.Controls.Add(this.helprequestsReviewBTN);
            this.Controls.Add(this.removeBTN);
            this.Controls.Add(this.ignoreBTN);
            this.Controls.Add(this.contentGB);
            this.Controls.Add(this.reportedcontentBTN);
            this.Name = "Beheerder";
            this.Text = "Beheerder";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button reportedcontentBTN;
        private System.Windows.Forms.GroupBox contentGB;
        private System.Windows.Forms.Button ignoreBTN;
        private System.Windows.Forms.Button removeBTN;
        private System.Windows.Forms.Button helprequestsReviewBTN;
        private System.Windows.Forms.Button chatBTN;
        private System.Windows.Forms.Button logoutBTN;
    }
}