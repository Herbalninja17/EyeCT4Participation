namespace EyeCT4Participation
{
    partial class Chat
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chatLB = new System.Windows.Forms.ListBox();
            this.sendBTN = new System.Windows.Forms.Button();
            this.chattosendTB = new System.Windows.Forms.TextBox();
            this.planappointmentBTN = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.chatLB);
            this.groupBox1.Controls.Add(this.sendBTN);
            this.groupBox1.Controls.Add(this.chattosendTB);
            this.groupBox1.Location = new System.Drawing.Point(218, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 418);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chat";
            // 
            // chatLB
            // 
            this.chatLB.FormattingEnabled = true;
            this.chatLB.Location = new System.Drawing.Point(6, 15);
            this.chatLB.Name = "chatLB";
            this.chatLB.Size = new System.Drawing.Size(342, 368);
            this.chatLB.TabIndex = 11;
            // 
            // sendBTN
            // 
            this.sendBTN.Location = new System.Drawing.Point(279, 390);
            this.sendBTN.Name = "sendBTN";
            this.sendBTN.Size = new System.Drawing.Size(69, 23);
            this.sendBTN.TabIndex = 10;
            this.sendBTN.Text = "SEND";
            this.sendBTN.UseVisualStyleBackColor = true;
            this.sendBTN.Click += new System.EventHandler(this.sendBTN_Click);
            // 
            // chattosendTB
            // 
            this.chattosendTB.Location = new System.Drawing.Point(6, 392);
            this.chattosendTB.Name = "chattosendTB";
            this.chattosendTB.Size = new System.Drawing.Size(267, 20);
            this.chattosendTB.TabIndex = 9;
            // 
            // planappointmentBTN
            // 
            this.planappointmentBTN.Location = new System.Drawing.Point(0, 74);
            this.planappointmentBTN.Name = "planappointmentBTN";
            this.planappointmentBTN.Size = new System.Drawing.Size(200, 44);
            this.planappointmentBTN.TabIndex = 13;
            this.planappointmentBTN.Text = "Plan appointment";
            this.planappointmentBTN.UseVisualStyleBackColor = true;
            this.planappointmentBTN.Click += new System.EventHandler(this.planappointmentBTN_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(0, 30);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.planappointmentBTN);
            this.groupBox2.Location = new System.Drawing.Point(12, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 141);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Afspraak";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 430);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Chat";
            this.Text = "Chat";
            this.Load += new System.EventHandler(this.Chat_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button sendBTN;
        private System.Windows.Forms.TextBox chattosendTB;
        private System.Windows.Forms.Button planappointmentBTN;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox chatLB;
        private System.Windows.Forms.Timer timer1;
    }
}