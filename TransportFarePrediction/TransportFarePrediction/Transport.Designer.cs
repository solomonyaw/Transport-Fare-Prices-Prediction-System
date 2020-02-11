﻿namespace TransportFarePrediction
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
            this.button1.TabIndex = 1;
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
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Transport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(637, 450);
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
    }
}

