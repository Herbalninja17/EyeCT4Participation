namespace EyeCT4Participation
{
    partial class ReviewVolunteer
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
            this.trackBarReview = new System.Windows.Forms.TrackBar();
            this.BeoordelingLB = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxOpmerkingen = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarReview)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBarReview
            // 
            this.trackBarReview.Location = new System.Drawing.Point(12, 32);
            this.trackBarReview.Maximum = 5;
            this.trackBarReview.Minimum = 1;
            this.trackBarReview.Name = "trackBarReview";
            this.trackBarReview.Size = new System.Drawing.Size(260, 45);
            this.trackBarReview.TabIndex = 0;
            this.trackBarReview.Value = 5;
            // 
            // BeoordelingLB
            // 
            this.BeoordelingLB.AutoSize = true;
            this.BeoordelingLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BeoordelingLB.Location = new System.Drawing.Point(69, 9);
            this.BeoordelingLB.Name = "BeoordelingLB";
            this.BeoordelingLB.Size = new System.Drawing.Size(127, 25);
            this.BeoordelingLB.TabIndex = 1;
            this.BeoordelingLB.Text = "Beoordeling";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(252, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "5";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(194, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "4";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(105, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Review";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxOpmerkingen
            // 
            this.textBoxOpmerkingen.Location = new System.Drawing.Point(12, 91);
            this.textBoxOpmerkingen.Multiline = true;
            this.textBoxOpmerkingen.Name = "textBoxOpmerkingen";
            this.textBoxOpmerkingen.Size = new System.Drawing.Size(260, 125);
            this.textBoxOpmerkingen.TabIndex = 17;
            // 
            // ReviewVolunteer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.textBoxOpmerkingen);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BeoordelingLB);
            this.Controls.Add(this.trackBarReview);
            this.Name = "ReviewVolunteer";
            this.Text = "ReviewVolunteer";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarReview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBarReview;
        private System.Windows.Forms.Label BeoordelingLB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxOpmerkingen;
    }
}