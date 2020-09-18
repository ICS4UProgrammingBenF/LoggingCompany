namespace LoggingCompany
{
    partial class LoggingCompanyForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblWhichLength = new System.Windows.Forms.Label();
            this.radOneM = new System.Windows.Forms.RadioButton();
            this.radPointFiveM = new System.Windows.Forms.RadioButton();
            this.radPointTwoFiveM = new System.Windows.Forms.RadioButton();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblThanks = new System.Windows.Forms.Label();
            this.txtTotalLogs = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(3, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(273, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Totally Not a Scam Logging Company";
            // 
            // lblWhichLength
            // 
            this.lblWhichLength.AutoSize = true;
            this.lblWhichLength.Location = new System.Drawing.Point(12, 76);
            this.lblWhichLength.Name = "lblWhichLength";
            this.lblWhichLength.Size = new System.Drawing.Size(175, 13);
            this.lblWhichLength.TabIndex = 1;
            this.lblWhichLength.Text = "Which length of log would you like?";
            // 
            // radOneM
            // 
            this.radOneM.AutoSize = true;
            this.radOneM.Location = new System.Drawing.Point(15, 120);
            this.radOneM.Name = "radOneM";
            this.radOneM.Size = new System.Drawing.Size(61, 17);
            this.radOneM.TabIndex = 2;
            this.radOneM.TabStop = true;
            this.radOneM.Text = "1 Metre";
            this.radOneM.UseVisualStyleBackColor = true;
            // 
            // radPointFiveM
            // 
            this.radPointFiveM.AutoSize = true;
            this.radPointFiveM.Location = new System.Drawing.Point(15, 144);
            this.radPointFiveM.Name = "radPointFiveM";
            this.radPointFiveM.Size = new System.Drawing.Size(75, 17);
            this.radPointFiveM.TabIndex = 3;
            this.radPointFiveM.TabStop = true;
            this.radPointFiveM.Text = "0.5 Metres";
            this.radPointFiveM.UseVisualStyleBackColor = true;
            // 
            // radPointTwoFiveM
            // 
            this.radPointTwoFiveM.AutoSize = true;
            this.radPointTwoFiveM.Location = new System.Drawing.Point(15, 168);
            this.radPointTwoFiveM.Name = "radPointTwoFiveM";
            this.radPointTwoFiveM.Size = new System.Drawing.Size(81, 17);
            this.radPointTwoFiveM.TabIndex = 4;
            this.radPointTwoFiveM.TabStop = true;
            this.radPointTwoFiveM.Text = "0.25 Metres";
            this.radPointTwoFiveM.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(102, 220);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 5;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblThanks
            // 
            this.lblThanks.AutoSize = true;
            this.lblThanks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThanks.ForeColor = System.Drawing.Color.Red;
            this.lblThanks.Location = new System.Drawing.Point(4, 278);
            this.lblThanks.Name = "lblThanks";
            this.lblThanks.Size = new System.Drawing.Size(265, 26);
            this.lblThanks.TabIndex = 6;
            this.lblThanks.Text = "Thank you! \r\nWe\'ll take your money and keep the supplies!";
            this.lblThanks.Visible = false;
            // 
            // txtTotalLogs
            // 
            this.txtTotalLogs.Enabled = false;
            this.txtTotalLogs.Location = new System.Drawing.Point(13, 255);
            this.txtTotalLogs.Name = "txtTotalLogs";
            this.txtTotalLogs.Size = new System.Drawing.Size(253, 20);
            this.txtTotalLogs.TabIndex = 7;
            // 
            // LoggingCompanyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 313);
            this.Controls.Add(this.txtTotalLogs);
            this.Controls.Add(this.lblThanks);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.radPointTwoFiveM);
            this.Controls.Add(this.radPointFiveM);
            this.Controls.Add(this.radOneM);
            this.Controls.Add(this.lblWhichLength);
            this.Controls.Add(this.lblTitle);
            this.Name = "LoggingCompanyForm";
            this.Text = "Logging Company";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblWhichLength;
        private System.Windows.Forms.RadioButton radOneM;
        private System.Windows.Forms.RadioButton radPointFiveM;
        private System.Windows.Forms.RadioButton radPointTwoFiveM;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblThanks;
        private System.Windows.Forms.TextBox txtTotalLogs;
    }
}

