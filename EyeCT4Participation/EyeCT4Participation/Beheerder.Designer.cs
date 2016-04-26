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
            this.reportedrequestsBTN = new System.Windows.Forms.Button();
            this.contentGB = new System.Windows.Forms.GroupBox();
            this.LBSelectedContent = new System.Windows.Forms.ListBox();
            this.ignoreBTN = new System.Windows.Forms.Button();
            this.removeBTN = new System.Windows.Forms.Button();
            this.helprequestsBTN = new System.Windows.Forms.Button();
            this.chatBTN = new System.Windows.Forms.Button();
            this.logoutBTN = new System.Windows.Forms.Button();
            this.reviewsBTN = new System.Windows.Forms.Button();
            this.reportedReviewsBTN = new System.Windows.Forms.Button();
            this.reportedChatsBTN = new System.Windows.Forms.Button();
            this.contentGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportedrequestsBTN
            // 
            this.reportedrequestsBTN.Location = new System.Drawing.Point(164, 201);
            this.reportedrequestsBTN.Name = "reportedrequestsBTN";
            this.reportedrequestsBTN.Size = new System.Drawing.Size(141, 79);
            this.reportedrequestsBTN.TabIndex = 0;
            this.reportedrequestsBTN.Text = "Reported Requests";
            this.reportedrequestsBTN.UseVisualStyleBackColor = true;
            this.reportedrequestsBTN.Click += new System.EventHandler(this.reportedcontentBTN_Click);
            // 
            // contentGB
            // 
            this.contentGB.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.contentGB.Controls.Add(this.LBSelectedContent);
            this.contentGB.Location = new System.Drawing.Point(311, 28);
            this.contentGB.Name = "contentGB";
            this.contentGB.Size = new System.Drawing.Size(200, 411);
            this.contentGB.TabIndex = 1;
            this.contentGB.TabStop = false;
            this.contentGB.Text = "Content";
            // 
            // LBSelectedContent
            // 
            this.LBSelectedContent.FormattingEnabled = true;
            this.LBSelectedContent.Location = new System.Drawing.Point(6, 24);
            this.LBSelectedContent.Name = "LBSelectedContent";
            this.LBSelectedContent.Size = new System.Drawing.Size(187, 381);
            this.LBSelectedContent.TabIndex = 0;
            // 
            // ignoreBTN
            // 
            this.ignoreBTN.Location = new System.Drawing.Point(13, 329);
            this.ignoreBTN.Name = "ignoreBTN";
            this.ignoreBTN.Size = new System.Drawing.Size(88, 36);
            this.ignoreBTN.TabIndex = 2;
            this.ignoreBTN.Text = "Ignore selected";
            this.ignoreBTN.UseVisualStyleBackColor = true;
            this.ignoreBTN.Click += new System.EventHandler(this.ignoreBTN_Click);
            // 
            // removeBTN
            // 
            this.removeBTN.Location = new System.Drawing.Point(12, 286);
            this.removeBTN.Name = "removeBTN";
            this.removeBTN.Size = new System.Drawing.Size(89, 37);
            this.removeBTN.TabIndex = 3;
            this.removeBTN.Text = "Remove selected";
            this.removeBTN.UseVisualStyleBackColor = true;
            this.removeBTN.Click += new System.EventHandler(this.removeBTN_Click);
            // 
            // helprequestsBTN
            // 
            this.helprequestsBTN.Location = new System.Drawing.Point(13, 201);
            this.helprequestsBTN.Name = "helprequestsBTN";
            this.helprequestsBTN.Size = new System.Drawing.Size(147, 79);
            this.helprequestsBTN.TabIndex = 4;
            this.helprequestsBTN.Text = "Helprequests";
            this.helprequestsBTN.UseVisualStyleBackColor = true;
            this.helprequestsBTN.Click += new System.EventHandler(this.helprequestsReviewBTN_Click);
            // 
            // chatBTN
            // 
            this.chatBTN.Location = new System.Drawing.Point(12, 12);
            this.chatBTN.Name = "chatBTN";
            this.chatBTN.Size = new System.Drawing.Size(147, 79);
            this.chatBTN.TabIndex = 5;
            this.chatBTN.Text = "Chats";
            this.chatBTN.UseVisualStyleBackColor = true;
            this.chatBTN.Click += new System.EventHandler(this.chatBTN_Click);
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
            // reviewsBTN
            // 
            this.reviewsBTN.Location = new System.Drawing.Point(12, 106);
            this.reviewsBTN.Name = "reviewsBTN";
            this.reviewsBTN.Size = new System.Drawing.Size(147, 79);
            this.reviewsBTN.TabIndex = 7;
            this.reviewsBTN.Text = "Reviews";
            this.reviewsBTN.UseVisualStyleBackColor = true;
            this.reviewsBTN.Click += new System.EventHandler(this.reviewsBTN_Click);
            // 
            // reportedReviewsBTN
            // 
            this.reportedReviewsBTN.Location = new System.Drawing.Point(165, 106);
            this.reportedReviewsBTN.Name = "reportedReviewsBTN";
            this.reportedReviewsBTN.Size = new System.Drawing.Size(141, 79);
            this.reportedReviewsBTN.TabIndex = 8;
            this.reportedReviewsBTN.Text = "Reported Reviews";
            this.reportedReviewsBTN.UseVisualStyleBackColor = true;
            this.reportedReviewsBTN.Click += new System.EventHandler(this.reportedReviewsBTN_Click);
            // 
            // reportedChatsBTN
            // 
            this.reportedChatsBTN.Location = new System.Drawing.Point(164, 12);
            this.reportedChatsBTN.Name = "reportedChatsBTN";
            this.reportedChatsBTN.Size = new System.Drawing.Size(141, 79);
            this.reportedChatsBTN.TabIndex = 9;
            this.reportedChatsBTN.Text = "Reported Chats";
            this.reportedChatsBTN.UseVisualStyleBackColor = true;
            this.reportedChatsBTN.Click += new System.EventHandler(this.reportedChatsBTN_Click);
            // 
            // Beheerder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 457);
            this.Controls.Add(this.reportedChatsBTN);
            this.Controls.Add(this.reportedReviewsBTN);
            this.Controls.Add(this.reviewsBTN);
            this.Controls.Add(this.logoutBTN);
            this.Controls.Add(this.chatBTN);
            this.Controls.Add(this.helprequestsBTN);
            this.Controls.Add(this.removeBTN);
            this.Controls.Add(this.ignoreBTN);
            this.Controls.Add(this.contentGB);
            this.Controls.Add(this.reportedrequestsBTN);
            this.Name = "Beheerder";
            this.Text = "Beheerder";
            this.Load += new System.EventHandler(this.Beheerder_Load);
            this.contentGB.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button reportedrequestsBTN;
        private System.Windows.Forms.GroupBox contentGB;
        private System.Windows.Forms.Button ignoreBTN;
        private System.Windows.Forms.Button removeBTN;
        private System.Windows.Forms.Button helprequestsBTN;
        private System.Windows.Forms.Button chatBTN;
        private System.Windows.Forms.Button logoutBTN;
        private System.Windows.Forms.ListBox LBSelectedContent;
        private System.Windows.Forms.Button reviewsBTN;
        private System.Windows.Forms.Button reportedReviewsBTN;
        private System.Windows.Forms.Button reportedChatsBTN;
    }
}