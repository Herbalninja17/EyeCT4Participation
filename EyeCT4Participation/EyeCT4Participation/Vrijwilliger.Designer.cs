namespace EyeCT4Participation
{
    partial class Vrijwilliger
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
            this.helprequestBTN = new System.Windows.Forms.Button();
            this.replyBTN1 = new System.Windows.Forms.Button();
            this.logoutBTN = new System.Windows.Forms.Button();
            this.reviewBTN = new System.Windows.Forms.Button();
            this.appointmentBTN = new System.Windows.Forms.Button();
            this.VrijwilligerGrpBx = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.TxtBxReactionPost = new System.Windows.Forms.RichTextBox();
            this.BtnReactionPost = new System.Windows.Forms.Button();
            this.VrijwilligerGrpBx.SuspendLayout();
            this.SuspendLayout();
            // 
            // helprequestBTN
            // 
            this.helprequestBTN.Location = new System.Drawing.Point(12, 12);
            this.helprequestBTN.Name = "helprequestBTN";
            this.helprequestBTN.Size = new System.Drawing.Size(145, 92);
            this.helprequestBTN.TabIndex = 0;
            this.helprequestBTN.Text = "Help requests";
            this.helprequestBTN.UseVisualStyleBackColor = true;
            this.helprequestBTN.Click += new System.EventHandler(this.helprequestBTN_Click);
            // 
            // replyBTN1
            // 
            this.replyBTN1.Location = new System.Drawing.Point(26, 19);
            this.replyBTN1.Name = "replyBTN1";
            this.replyBTN1.Size = new System.Drawing.Size(75, 23);
            this.replyBTN1.TabIndex = 3;
            this.replyBTN1.Text = "Reply";
            this.replyBTN1.UseVisualStyleBackColor = true;
            // 
            // logoutBTN
            // 
            this.logoutBTN.Location = new System.Drawing.Point(12, 455);
            this.logoutBTN.Name = "logoutBTN";
            this.logoutBTN.Size = new System.Drawing.Size(75, 23);
            this.logoutBTN.TabIndex = 4;
            this.logoutBTN.Text = "Logout";
            this.logoutBTN.UseVisualStyleBackColor = true;
            this.logoutBTN.Click += new System.EventHandler(this.logoutBTN_Click);
            // 
            // reviewBTN
            // 
            this.reviewBTN.Location = new System.Drawing.Point(12, 125);
            this.reviewBTN.Name = "reviewBTN";
            this.reviewBTN.Size = new System.Drawing.Size(145, 88);
            this.reviewBTN.TabIndex = 5;
            this.reviewBTN.Text = "Reviews";
            this.reviewBTN.UseVisualStyleBackColor = true;
            this.reviewBTN.Click += new System.EventHandler(this.reviewBTN_Click);
            // 
            // appointmentBTN
            // 
            this.appointmentBTN.Location = new System.Drawing.Point(12, 233);
            this.appointmentBTN.Name = "appointmentBTN";
            this.appointmentBTN.Size = new System.Drawing.Size(145, 88);
            this.appointmentBTN.TabIndex = 13;
            this.appointmentBTN.Text = "Open calender";
            this.appointmentBTN.UseVisualStyleBackColor = true;
            // 
            // VrijwilligerGrpBx
            // 
            this.VrijwilligerGrpBx.Controls.Add(this.listBox1);
            this.VrijwilligerGrpBx.Controls.Add(this.replyBTN1);
            this.VrijwilligerGrpBx.Location = new System.Drawing.Point(615, 22);
            this.VrijwilligerGrpBx.Name = "VrijwilligerGrpBx";
            this.VrijwilligerGrpBx.Size = new System.Drawing.Size(531, 490);
            this.VrijwilligerGrpBx.TabIndex = 14;
            this.VrijwilligerGrpBx.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Location = new System.Drawing.Point(107, 10);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(404, 446);
            this.listBox1.TabIndex = 11;
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // TxtBxReactionPost
            // 
            this.TxtBxReactionPost.Location = new System.Drawing.Point(266, 125);
            this.TxtBxReactionPost.Name = "TxtBxReactionPost";
            this.TxtBxReactionPost.Size = new System.Drawing.Size(296, 165);
            this.TxtBxReactionPost.TabIndex = 15;
            this.TxtBxReactionPost.Text = "";
            this.TxtBxReactionPost.Visible = false;
            // 
            // BtnReactionPost
            // 
            this.BtnReactionPost.Location = new System.Drawing.Point(487, 298);
            this.BtnReactionPost.Name = "BtnReactionPost";
            this.BtnReactionPost.Size = new System.Drawing.Size(75, 23);
            this.BtnReactionPost.TabIndex = 16;
            this.BtnReactionPost.Text = "Post Reaction";
            this.BtnReactionPost.UseVisualStyleBackColor = true;
            this.BtnReactionPost.Visible = false;
            // 
            // Vrijwilliger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 524);
            this.Controls.Add(this.BtnReactionPost);
            this.Controls.Add(this.TxtBxReactionPost);
            this.Controls.Add(this.VrijwilligerGrpBx);
            this.Controls.Add(this.appointmentBTN);
            this.Controls.Add(this.reviewBTN);
            this.Controls.Add(this.logoutBTN);
            this.Controls.Add(this.helprequestBTN);
            this.Name = "Vrijwilliger";
            this.Text = "Vrijwilliger";
            this.VrijwilligerGrpBx.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button helprequestBTN;
        private System.Windows.Forms.Button replyBTN1;
        private System.Windows.Forms.Button logoutBTN;
        private System.Windows.Forms.Button reviewBTN;
        private System.Windows.Forms.Button appointmentBTN;
        private System.Windows.Forms.GroupBox VrijwilligerGrpBx;
        private System.Windows.Forms.RichTextBox TxtBxReactionPost;
        private System.Windows.Forms.Button BtnReactionPost;
        private System.Windows.Forms.ListBox listBox1;
    }
}