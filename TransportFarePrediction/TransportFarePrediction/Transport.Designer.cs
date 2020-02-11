namespace TransportFarePrediction
{
    partial class Transport
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblOutcome = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtVendorID = new System.Windows.Forms.TextBox();
            this.txtRateCode = new System.Windows.Forms.TextBox();
            this.txtPassengerCount = new System.Windows.Forms.TextBox();
            this.txtTripTime = new System.Windows.Forms.TextBox();
            this.txtTripDistance = new System.Windows.Forms.TextBox();
            this.txtPaymentType = new System.Windows.Forms.TextBox();
            this.txtFareAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(34, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(586, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Transport Fare Prediction  || Machine Learning System";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe Marker", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(229, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 80);
            this.button1.TabIndex = 7;
            this.button1.Text = "Predict Transport Fare";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblOutcome
            // 
            this.lblOutcome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutcome.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutcome.Location = new System.Drawing.Point(76, 60);
            this.lblOutcome.Name = "lblOutcome";
            this.lblOutcome.Size = new System.Drawing.Size(475, 234);
            this.lblOutcome.TabIndex = 2;
            this.lblOutcome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(429, 349);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 46);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtVendorID
            // 
            this.txtVendorID.Location = new System.Drawing.Point(708, 63);
            this.txtVendorID.Name = "txtVendorID";
            this.txtVendorID.Size = new System.Drawing.Size(100, 20);
            this.txtVendorID.TabIndex = 0;
            // 
            // txtRateCode
            // 
            this.txtRateCode.Location = new System.Drawing.Point(708, 112);
            this.txtRateCode.Name = "txtRateCode";
            this.txtRateCode.Size = new System.Drawing.Size(100, 20);
            this.txtRateCode.TabIndex = 1;
            // 
            // txtPassengerCount
            // 
            this.txtPassengerCount.Location = new System.Drawing.Point(708, 152);
            this.txtPassengerCount.Name = "txtPassengerCount";
            this.txtPassengerCount.Size = new System.Drawing.Size(100, 20);
            this.txtPassengerCount.TabIndex = 2;
            // 
            // txtTripTime
            // 
            this.txtTripTime.Location = new System.Drawing.Point(708, 194);
            this.txtTripTime.Name = "txtTripTime";
            this.txtTripTime.Size = new System.Drawing.Size(100, 20);
            this.txtTripTime.TabIndex = 3;
            // 
            // txtTripDistance
            // 
            this.txtTripDistance.Location = new System.Drawing.Point(708, 245);
            this.txtTripDistance.Name = "txtTripDistance";
            this.txtTripDistance.Size = new System.Drawing.Size(100, 20);
            this.txtTripDistance.TabIndex = 4;
            // 
            // txtPaymentType
            // 
            this.txtPaymentType.Location = new System.Drawing.Point(708, 288);
            this.txtPaymentType.Name = "txtPaymentType";
            this.txtPaymentType.Size = new System.Drawing.Size(100, 20);
            this.txtPaymentType.TabIndex = 5;
            // 
            // txtFareAmount
            // 
            this.txtFareAmount.Location = new System.Drawing.Point(708, 327);
            this.txtFareAmount.Name = "txtFareAmount";
            this.txtFareAmount.Size = new System.Drawing.Size(100, 20);
            this.txtFareAmount.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(576, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Vendor ID(CMT/VTS)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(613, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Rate Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(606, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Passenger Count";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(613, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Trip Time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(606, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Trip Distance";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(568, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Payment Type (CRD/CSH)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(619, 334);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Fare Amount";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(525, 349);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 46);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Transport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(835, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFareAmount);
            this.Controls.Add(this.txtPaymentType);
            this.Controls.Add(this.txtTripDistance);
            this.Controls.Add(this.txtTripTime);
            this.Controls.Add(this.txtPassengerCount);
            this.Controls.Add(this.txtRateCode);
            this.Controls.Add(this.txtVendorID);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblOutcome);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Transport";
            this.Text = "Transport Fare Prediction";
            this.Load += new System.EventHandler(this.Transport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblOutcome;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtVendorID;
        private System.Windows.Forms.TextBox txtRateCode;
        private System.Windows.Forms.TextBox txtPassengerCount;
        private System.Windows.Forms.TextBox txtTripTime;
        private System.Windows.Forms.TextBox txtTripDistance;
        private System.Windows.Forms.TextBox txtPaymentType;
        private System.Windows.Forms.TextBox txtFareAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnClear;
    }
}

