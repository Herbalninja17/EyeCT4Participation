namespace EyeCT4Participation
{
    partial class PlaceRequest
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxTravelTime = new System.Windows.Forms.TextBox();
            this.textBoxEndTime = new System.Windows.Forms.TextBox();
            this.textBoxStartTime = new System.Windows.Forms.TextBox();
            this.UrgencyRadioBTN = new System.Windows.Forms.RadioButton();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.lblBeginTime = new System.Windows.Forms.Label();
            this.textBoxVolunteersNeeded = new System.Windows.Forms.TextBox();
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            this.textBoxTransportType = new System.Windows.Forms.TextBox();
            this.placeRequestBTN = new System.Windows.Forms.Button();
            this.textBoxDescription = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxTravelTime);
            this.groupBox1.Controls.Add(this.textBoxEndTime);
            this.groupBox1.Controls.Add(this.textBoxStartTime);
            this.groupBox1.Controls.Add(this.UrgencyRadioBTN);
            this.groupBox1.Controls.Add(this.lblEndTime);
            this.groupBox1.Controls.Add(this.lblBeginTime);
            this.groupBox1.Controls.Add(this.textBoxVolunteersNeeded);
            this.groupBox1.Controls.Add(this.textBoxLocation);
            this.groupBox1.Controls.Add(this.textBoxTransportType);
            this.groupBox1.Location = new System.Drawing.Point(278, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 146);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Other details";
            // 
            // textBoxTravelTime
            // 
            this.textBoxTravelTime.Location = new System.Drawing.Point(142, 45);
            this.textBoxTravelTime.Name = "textBoxTravelTime";
            this.textBoxTravelTime.Size = new System.Drawing.Size(100, 20);
            this.textBoxTravelTime.TabIndex = 12;
            this.textBoxTravelTime.Text = "Travel time";
            // 
            // textBoxEndTime
            // 
            this.textBoxEndTime.Location = new System.Drawing.Point(142, 98);
            this.textBoxEndTime.Name = "textBoxEndTime";
            this.textBoxEndTime.Size = new System.Drawing.Size(100, 20);
            this.textBoxEndTime.TabIndex = 11;
            // 
            // textBoxStartTime
            // 
            this.textBoxStartTime.Location = new System.Drawing.Point(6, 98);
            this.textBoxStartTime.Name = "textBoxStartTime";
            this.textBoxStartTime.Size = new System.Drawing.Size(100, 20);
            this.textBoxStartTime.TabIndex = 10;
            // 
            // UrgencyRadioBTN
            // 
            this.UrgencyRadioBTN.AutoSize = true;
            this.UrgencyRadioBTN.Location = new System.Drawing.Point(100, 124);
            this.UrgencyRadioBTN.Name = "UrgencyRadioBTN";
            this.UrgencyRadioBTN.Size = new System.Drawing.Size(57, 17);
            this.UrgencyRadioBTN.TabIndex = 2;
            this.UrgencyRadioBTN.Text = "Urgent";
            this.UrgencyRadioBTN.UseVisualStyleBackColor = true;
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Location = new System.Drawing.Point(139, 82);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(84, 13);
            this.lblEndTime.TabIndex = 9;
            this.lblEndTime.Text = "End time hh/mm";
            // 
            // lblBeginTime
            // 
            this.lblBeginTime.AutoSize = true;
            this.lblBeginTime.Location = new System.Drawing.Point(3, 82);
            this.lblBeginTime.Name = "lblBeginTime";
            this.lblBeginTime.Size = new System.Drawing.Size(87, 13);
            this.lblBeginTime.TabIndex = 8;
            this.lblBeginTime.Text = "Start time hh/mm";
            // 
            // textBoxVolunteersNeeded
            // 
            this.textBoxVolunteersNeeded.Location = new System.Drawing.Point(142, 19);
            this.textBoxVolunteersNeeded.Name = "textBoxVolunteersNeeded";
            this.textBoxVolunteersNeeded.Size = new System.Drawing.Size(100, 20);
            this.textBoxVolunteersNeeded.TabIndex = 5;
            this.textBoxVolunteersNeeded.Text = "Volunteers needed";
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.Location = new System.Drawing.Point(6, 19);
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.Size = new System.Drawing.Size(100, 20);
            this.textBoxLocation.TabIndex = 3;
            this.textBoxLocation.Text = "Location";
            // 
            // textBoxTransportType
            // 
            this.textBoxTransportType.Location = new System.Drawing.Point(6, 45);
            this.textBoxTransportType.Name = "textBoxTransportType";
            this.textBoxTransportType.Size = new System.Drawing.Size(100, 20);
            this.textBoxTransportType.TabIndex = 4;
            this.textBoxTransportType.Text = "Transport type";
            // 
            // placeRequestBTN
            // 
            this.placeRequestBTN.Location = new System.Drawing.Point(366, 165);
            this.placeRequestBTN.Name = "placeRequestBTN";
            this.placeRequestBTN.Size = new System.Drawing.Size(85, 23);
            this.placeRequestBTN.TabIndex = 10;
            this.placeRequestBTN.Text = "Place request";
            this.placeRequestBTN.UseVisualStyleBackColor = true;
            this.placeRequestBTN.Click += new System.EventHandler(this.placeRequestBTN_Click);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(13, 13);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(259, 175);
            this.textBoxDescription.TabIndex = 9;
            this.textBoxDescription.Text = "Description of the request";
            // 
            // PlaceRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 200);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.placeRequestBTN);
            this.Controls.Add(this.textBoxDescription);
            this.Name = "PlaceRequest";
            this.Text = "PlaceRequest";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxEndTime;
        private System.Windows.Forms.TextBox textBoxStartTime;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.RadioButton UrgencyRadioBTN;
        private System.Windows.Forms.Label lblBeginTime;
        private System.Windows.Forms.TextBox textBoxVolunteersNeeded;
        private System.Windows.Forms.TextBox textBoxLocation;
        private System.Windows.Forms.TextBox textBoxTransportType;
        private System.Windows.Forms.Button placeRequestBTN;
        private System.Windows.Forms.RichTextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxTravelTime;
    }
}