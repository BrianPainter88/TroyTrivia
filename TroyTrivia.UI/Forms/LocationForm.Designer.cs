namespace TroyTrivia.UI.Forms
{
    partial class LocationForm
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
            this.txtLocationName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnAddLocation = new System.Windows.Forms.Button();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.lblAddress1 = new System.Windows.Forms.Label();
            this.lblAddress2 = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblZipCode = new System.Windows.Forms.Label();
            this.lblAddressInformation = new System.Windows.Forms.Label();
            this.rchSpecialDirections = new System.Windows.Forms.RichTextBox();
            this.lblSpecialDirections = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtLocationName
            // 
            this.txtLocationName.Location = new System.Drawing.Point(66, 31);
            this.txtLocationName.Name = "txtLocationName";
            this.txtLocationName.Size = new System.Drawing.Size(281, 20);
            this.txtLocationName.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(22, 34);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // btnAddLocation
            // 
            this.btnAddLocation.Location = new System.Drawing.Point(66, 401);
            this.btnAddLocation.Name = "btnAddLocation";
            this.btnAddLocation.Size = new System.Drawing.Size(75, 23);
            this.btnAddLocation.TabIndex = 99;
            this.btnAddLocation.Text = "Add Location";
            this.btnAddLocation.UseVisualStyleBackColor = true;
            this.btnAddLocation.Click += new System.EventHandler(this.btnAddLocation_Click);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(22, 70);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(41, 13);
            this.lblPhone.TabIndex = 3;
            this.lblPhone.Text = "Phone:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(66, 67);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(151, 20);
            this.txtPhone.TabIndex = 1;
            // 
            // txtAddress1
            // 
            this.txtAddress1.Location = new System.Drawing.Point(66, 127);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(254, 20);
            this.txtAddress1.TabIndex = 2;
            // 
            // txtAddress2
            // 
            this.txtAddress2.Location = new System.Drawing.Point(66, 153);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(254, 20);
            this.txtAddress2.TabIndex = 3;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(66, 179);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(135, 20);
            this.txtCity.TabIndex = 4;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(66, 205);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(47, 20);
            this.txtState.TabIndex = 5;
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(66, 231);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(75, 20);
            this.txtZip.TabIndex = 6;
            // 
            // lblAddress1
            // 
            this.lblAddress1.AutoSize = true;
            this.lblAddress1.Location = new System.Drawing.Point(6, 130);
            this.lblAddress1.Name = "lblAddress1";
            this.lblAddress1.Size = new System.Drawing.Size(57, 13);
            this.lblAddress1.TabIndex = 10;
            this.lblAddress1.Text = "Address 1:";
            // 
            // lblAddress2
            // 
            this.lblAddress2.AutoSize = true;
            this.lblAddress2.Location = new System.Drawing.Point(6, 156);
            this.lblAddress2.Name = "lblAddress2";
            this.lblAddress2.Size = new System.Drawing.Size(57, 13);
            this.lblAddress2.TabIndex = 11;
            this.lblAddress2.Text = "Address 2:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(36, 182);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(27, 13);
            this.lblCity.TabIndex = 12;
            this.lblCity.Text = "City:";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(28, 208);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(35, 13);
            this.lblState.TabIndex = 13;
            this.lblState.Text = "State:";
            // 
            // lblZipCode
            // 
            this.lblZipCode.AutoSize = true;
            this.lblZipCode.Location = new System.Drawing.Point(38, 234);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Size = new System.Drawing.Size(25, 13);
            this.lblZipCode.TabIndex = 14;
            this.lblZipCode.Text = "Zip:";
            // 
            // lblAddressInformation
            // 
            this.lblAddressInformation.AutoSize = true;
            this.lblAddressInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressInformation.Location = new System.Drawing.Point(66, 108);
            this.lblAddressInformation.Name = "lblAddressInformation";
            this.lblAddressInformation.Size = new System.Drawing.Size(135, 13);
            this.lblAddressInformation.TabIndex = 15;
            this.lblAddressInformation.Text = "- Address Information -";
            // 
            // rchSpecialDirections
            // 
            this.rchSpecialDirections.Location = new System.Drawing.Point(66, 281);
            this.rchSpecialDirections.Name = "rchSpecialDirections";
            this.rchSpecialDirections.Size = new System.Drawing.Size(263, 91);
            this.rchSpecialDirections.TabIndex = 7;
            this.rchSpecialDirections.Text = "";
            // 
            // lblSpecialDirections
            // 
            this.lblSpecialDirections.AutoSize = true;
            this.lblSpecialDirections.Location = new System.Drawing.Point(63, 265);
            this.lblSpecialDirections.Name = "lblSpecialDirections";
            this.lblSpecialDirections.Size = new System.Drawing.Size(95, 13);
            this.lblSpecialDirections.TabIndex = 17;
            this.lblSpecialDirections.Text = "Special Directions:";
            // 
            // LocationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 436);
            this.Controls.Add(this.lblSpecialDirections);
            this.Controls.Add(this.rchSpecialDirections);
            this.Controls.Add(this.lblAddressInformation);
            this.Controls.Add(this.lblZipCode);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblAddress2);
            this.Controls.Add(this.lblAddress1);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtAddress2);
            this.Controls.Add(this.txtAddress1);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.btnAddLocation);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtLocationName);
            this.Name = "LocationForm";
            this.Text = "Location";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLocationName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnAddLocation;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress1;
        private System.Windows.Forms.TextBox txtAddress2;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.Label lblAddress1;
        private System.Windows.Forms.Label lblAddress2;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblZipCode;
        private System.Windows.Forms.Label lblAddressInformation;
        private System.Windows.Forms.RichTextBox rchSpecialDirections;
        private System.Windows.Forms.Label lblSpecialDirections;
    }
}