namespace JobSourceApp
{
    partial class Form1
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
            this.LblTitle = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.LblNumofHoursWorked = new System.Windows.Forms.Label();
            this.TxtHoursWorked = new System.Windows.Forms.TextBox();
            this.LblNumofDependents = new System.Windows.Forms.Label();
            this.TxtDependents = new System.Windows.Forms.TextBox();
            this.BtnCalculateHomePay = new System.Windows.Forms.Button();
            this.BtnResetDisplay = new System.Windows.Forms.Button();
            this.LblGrossPay = new System.Windows.Forms.Label();
            this.LblFedDeduct = new System.Windows.Forms.Label();
            this.LblSocialSecDeduction = new System.Windows.Forms.Label();
            this.LblAgencyFee = new System.Windows.Forms.Label();
            this.LblNetPay = new System.Windows.Forms.Label();
            this.TxtGrossPay = new System.Windows.Forms.TextBox();
            this.TxtFedDeduction = new System.Windows.Forms.TextBox();
            this.TxtSocialSecurityDeduction = new System.Windows.Forms.TextBox();
            this.TxtAgencyFee = new System.Windows.Forms.TextBox();
            this.TxtNetPay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = " ";
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(304, 26);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(136, 29);
            this.LblTitle.TabIndex = 1;
            this.LblTitle.Text = "Job Source";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(130, 87);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(44, 16);
            this.LblName.TabIndex = 2;
            this.LblName.Text = "Name";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(234, 87);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(100, 22);
            this.TxtName.TabIndex = 3;
            // 
            // LblNumofHoursWorked
            // 
            this.LblNumofHoursWorked.AutoSize = true;
            this.LblNumofHoursWorked.Location = new System.Drawing.Point(130, 126);
            this.LblNumofHoursWorked.Name = "LblNumofHoursWorked";
            this.LblNumofHoursWorked.Size = new System.Drawing.Size(132, 16);
            this.LblNumofHoursWorked.TabIndex = 2;
            this.LblNumofHoursWorked.Text = "No. of Hours Worked";
            // 
            // TxtHoursWorked
            // 
            this.TxtHoursWorked.Location = new System.Drawing.Point(291, 120);
            this.TxtHoursWorked.Name = "TxtHoursWorked";
            this.TxtHoursWorked.Size = new System.Drawing.Size(100, 22);
            this.TxtHoursWorked.TabIndex = 3;
            // 
            // LblNumofDependents
            // 
            this.LblNumofDependents.AutoSize = true;
            this.LblNumofDependents.Location = new System.Drawing.Point(130, 164);
            this.LblNumofDependents.Name = "LblNumofDependents";
            this.LblNumofDependents.Size = new System.Drawing.Size(119, 16);
            this.LblNumofDependents.TabIndex = 2;
            this.LblNumofDependents.Text = "No. of Dependents";
            // 
            // TxtDependents
            // 
            this.TxtDependents.Location = new System.Drawing.Point(291, 164);
            this.TxtDependents.Name = "TxtDependents";
            this.TxtDependents.Size = new System.Drawing.Size(100, 22);
            this.TxtDependents.TabIndex = 3;
            // 
            // BtnCalculateHomePay
            // 
            this.BtnCalculateHomePay.Location = new System.Drawing.Point(185, 203);
            this.BtnCalculateHomePay.Name = "BtnCalculateHomePay";
            this.BtnCalculateHomePay.Size = new System.Drawing.Size(124, 45);
            this.BtnCalculateHomePay.TabIndex = 4;
            this.BtnCalculateHomePay.Text = "Calculate HomePay";
            this.BtnCalculateHomePay.UseVisualStyleBackColor = true;
            this.BtnCalculateHomePay.Click += new System.EventHandler(this.BtnCalculateHomePay_Click);
            // 
            // BtnResetDisplay
            // 
            this.BtnResetDisplay.Location = new System.Drawing.Point(364, 203);
            this.BtnResetDisplay.Name = "BtnResetDisplay";
            this.BtnResetDisplay.Size = new System.Drawing.Size(154, 45);
            this.BtnResetDisplay.TabIndex = 4;
            this.BtnResetDisplay.Text = "Reset Display";
            this.BtnResetDisplay.UseVisualStyleBackColor = true;
            this.BtnResetDisplay.Click += new System.EventHandler(this.BtnResetDisplay_Click);
            // 
            // LblGrossPay
            // 
            this.LblGrossPay.AutoSize = true;
            this.LblGrossPay.Location = new System.Drawing.Point(291, 270);
            this.LblGrossPay.Name = "LblGrossPay";
            this.LblGrossPay.Size = new System.Drawing.Size(73, 16);
            this.LblGrossPay.TabIndex = 5;
            this.LblGrossPay.Text = "Gross Pay:";
            // 
            // LblFedDeduct
            // 
            this.LblFedDeduct.AutoSize = true;
            this.LblFedDeduct.Location = new System.Drawing.Point(291, 301);
            this.LblFedDeduct.Name = "LblFedDeduct";
            this.LblFedDeduct.Size = new System.Drawing.Size(98, 16);
            this.LblFedDeduct.TabIndex = 5;
            this.LblFedDeduct.Text = "Fed Deduction:";
            // 
            // LblSocialSecDeduction
            // 
            this.LblSocialSecDeduction.AutoSize = true;
            this.LblSocialSecDeduction.Location = new System.Drawing.Point(291, 332);
            this.LblSocialSecDeduction.Name = "LblSocialSecDeduction";
            this.LblSocialSecDeduction.Size = new System.Drawing.Size(99, 16);
            this.LblSocialSecDeduction.TabIndex = 5;
            this.LblSocialSecDeduction.Text = "Social Security:";
            // 
            // LblAgencyFee
            // 
            this.LblAgencyFee.AutoSize = true;
            this.LblAgencyFee.Location = new System.Drawing.Point(291, 363);
            this.LblAgencyFee.Name = "LblAgencyFee";
            this.LblAgencyFee.Size = new System.Drawing.Size(80, 16);
            this.LblAgencyFee.TabIndex = 5;
            this.LblAgencyFee.Text = "AgencyFee:";
            // 
            // LblNetPay
            // 
            this.LblNetPay.AutoSize = true;
            this.LblNetPay.Location = new System.Drawing.Point(291, 394);
            this.LblNetPay.Name = "LblNetPay";
            this.LblNetPay.Size = new System.Drawing.Size(58, 16);
            this.LblNetPay.TabIndex = 5;
            this.LblNetPay.Text = "Net Pay:";
            // 
            // TxtGrossPay
            // 
            this.TxtGrossPay.Location = new System.Drawing.Point(400, 270);
            this.TxtGrossPay.Name = "TxtGrossPay";
            this.TxtGrossPay.Size = new System.Drawing.Size(100, 22);
            this.TxtGrossPay.TabIndex = 6;
            // 
            // TxtFedDeduction
            // 
            this.TxtFedDeduction.Location = new System.Drawing.Point(400, 298);
            this.TxtFedDeduction.Name = "TxtFedDeduction";
            this.TxtFedDeduction.Size = new System.Drawing.Size(100, 22);
            this.TxtFedDeduction.TabIndex = 6;
            // 
            // TxtSocialSecurityDeduction
            // 
            this.TxtSocialSecurityDeduction.Location = new System.Drawing.Point(400, 329);
            this.TxtSocialSecurityDeduction.Name = "TxtSocialSecurityDeduction";
            this.TxtSocialSecurityDeduction.Size = new System.Drawing.Size(100, 22);
            this.TxtSocialSecurityDeduction.TabIndex = 6;
            // 
            // TxtAgencyFee
            // 
            this.TxtAgencyFee.Location = new System.Drawing.Point(400, 366);
            this.TxtAgencyFee.Name = "TxtAgencyFee";
            this.TxtAgencyFee.Size = new System.Drawing.Size(100, 22);
            this.TxtAgencyFee.TabIndex = 6;
            // 
            // TxtNetPay
            // 
            this.TxtNetPay.Location = new System.Drawing.Point(400, 394);
            this.TxtNetPay.Name = "TxtNetPay";
            this.TxtNetPay.Size = new System.Drawing.Size(100, 22);
            this.TxtNetPay.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtNetPay);
            this.Controls.Add(this.TxtAgencyFee);
            this.Controls.Add(this.TxtSocialSecurityDeduction);
            this.Controls.Add(this.TxtFedDeduction);
            this.Controls.Add(this.TxtGrossPay);
            this.Controls.Add(this.LblNetPay);
            this.Controls.Add(this.LblAgencyFee);
            this.Controls.Add(this.LblSocialSecDeduction);
            this.Controls.Add(this.LblFedDeduct);
            this.Controls.Add(this.LblGrossPay);
            this.Controls.Add(this.BtnResetDisplay);
            this.Controls.Add(this.BtnCalculateHomePay);
            this.Controls.Add(this.TxtDependents);
            this.Controls.Add(this.TxtHoursWorked);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.LblNumofDependents);
            this.Controls.Add(this.LblNumofHoursWorked);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label LblNumofHoursWorked;
        private System.Windows.Forms.TextBox TxtHoursWorked;
        private System.Windows.Forms.Label LblNumofDependents;
        private System.Windows.Forms.TextBox TxtDependents;
        private System.Windows.Forms.Button BtnCalculateHomePay;
        private System.Windows.Forms.Button BtnResetDisplay;
        private System.Windows.Forms.Label LblGrossPay;
        private System.Windows.Forms.Label LblFedDeduct;
        private System.Windows.Forms.Label LblSocialSecDeduction;
        private System.Windows.Forms.Label LblAgencyFee;
        private System.Windows.Forms.Label LblNetPay;
        private System.Windows.Forms.TextBox TxtGrossPay;
        private System.Windows.Forms.TextBox TxtFedDeduction;
        private System.Windows.Forms.TextBox TxtSocialSecurityDeduction;
        private System.Windows.Forms.TextBox TxtAgencyFee;
        private System.Windows.Forms.TextBox TxtNetPay;
    }
}

