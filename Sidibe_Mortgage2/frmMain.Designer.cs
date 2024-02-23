namespace Sidibe_Mortgage2
{
    partial class frmMain
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
            this.lblPrincipal = new System.Windows.Forms.Label();
            this.txtPrincipalInput = new System.Windows.Forms.TextBox();
            this.lblTermInYears = new System.Windows.Forms.Label();
            this.rad15Years = new System.Windows.Forms.RadioButton();
            this.rad30Years = new System.Windows.Forms.RadioButton();
            this.radOther = new System.Windows.Forms.RadioButton();
            this.txtOtherInput = new System.Windows.Forms.TextBox();
            this.lblInterest = new System.Windows.Forms.Label();
            this.cboInterestRate = new System.Windows.Forms.ComboBox();
            this.btnCalculatePayment = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblMonthlyPayment = new System.Windows.Forms.Label();
            this.lblprincipalInputError = new System.Windows.Forms.Label();
            this.lblTermInYearsError = new System.Windows.Forms.Label();
            this.lblOtherInputError = new System.Windows.Forms.Label();
            this.lblInterestRateError = new System.Windows.Forms.Label();
            this.lstErrorFound = new System.Windows.Forms.ListBox();
            this.lblErrorFound = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPrincipal
            // 
            this.lblPrincipal.AutoSize = true;
            this.lblPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrincipal.Location = new System.Drawing.Point(13, 13);
            this.lblPrincipal.Name = "lblPrincipal";
            this.lblPrincipal.Size = new System.Drawing.Size(147, 36);
            this.lblPrincipal.TabIndex = 0;
            this.lblPrincipal.Text = "Principal :";
            // 
            // txtPrincipalInput
            // 
            this.txtPrincipalInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrincipalInput.Location = new System.Drawing.Point(154, 10);
            this.txtPrincipalInput.Name = "txtPrincipalInput";
            this.txtPrincipalInput.Size = new System.Drawing.Size(213, 41);
            this.txtPrincipalInput.TabIndex = 1;
            // 
            // lblTermInYears
            // 
            this.lblTermInYears.AutoSize = true;
            this.lblTermInYears.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTermInYears.Location = new System.Drawing.Point(13, 81);
            this.lblTermInYears.Name = "lblTermInYears";
            this.lblTermInYears.Size = new System.Drawing.Size(200, 36);
            this.lblTermInYears.TabIndex = 2;
            this.lblTermInYears.Text = "Term In Years";
            // 
            // rad15Years
            // 
            this.rad15Years.AutoSize = true;
            this.rad15Years.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad15Years.Location = new System.Drawing.Point(43, 135);
            this.rad15Years.Name = "rad15Years";
            this.rad15Years.Size = new System.Drawing.Size(159, 40);
            this.rad15Years.TabIndex = 3;
            this.rad15Years.TabStop = true;
            this.rad15Years.Text = "15 Years";
            this.rad15Years.UseVisualStyleBackColor = true;
            // 
            // rad30Years
            // 
            this.rad30Years.AutoSize = true;
            this.rad30Years.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad30Years.Location = new System.Drawing.Point(43, 194);
            this.rad30Years.Name = "rad30Years";
            this.rad30Years.Size = new System.Drawing.Size(159, 40);
            this.rad30Years.TabIndex = 4;
            this.rad30Years.TabStop = true;
            this.rad30Years.Text = "30 Years";
            this.rad30Years.UseVisualStyleBackColor = true;
            // 
            // radOther
            // 
            this.radOther.AutoSize = true;
            this.radOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radOther.Location = new System.Drawing.Point(43, 256);
            this.radOther.Name = "radOther";
            this.radOther.Size = new System.Drawing.Size(137, 40);
            this.radOther.TabIndex = 5;
            this.radOther.TabStop = true;
            this.radOther.Text = "Other...";
            this.radOther.UseVisualStyleBackColor = true;
            this.radOther.CheckedChanged += new System.EventHandler(this.radOther_CheckedChanged);
            // 
            // txtOtherInput
            // 
            this.txtOtherInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOtherInput.Location = new System.Drawing.Point(173, 255);
            this.txtOtherInput.Name = "txtOtherInput";
            this.txtOtherInput.Size = new System.Drawing.Size(100, 41);
            this.txtOtherInput.TabIndex = 6;
            this.txtOtherInput.Visible = false;
            // 
            // lblInterest
            // 
            this.lblInterest.AutoSize = true;
            this.lblInterest.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterest.Location = new System.Drawing.Point(13, 334);
            this.lblInterest.Name = "lblInterest";
            this.lblInterest.Size = new System.Drawing.Size(113, 36);
            this.lblInterest.TabIndex = 7;
            this.lblInterest.Text = "Interest";
            // 
            // cboInterestRate
            // 
            this.cboInterestRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboInterestRate.FormattingEnabled = true;
            this.cboInterestRate.Items.AddRange(new object[] {
            "3.0",
            "3.1",
            "3.2",
            "3.3",
            "3.4",
            "3.5",
            "3.6",
            "3.7",
            "3.8",
            "3.9",
            "4.0",
            "4.1",
            "4.2",
            "4.3",
            "4.4",
            "4.5"});
            this.cboInterestRate.Location = new System.Drawing.Point(132, 326);
            this.cboInterestRate.Name = "cboInterestRate";
            this.cboInterestRate.Size = new System.Drawing.Size(81, 44);
            this.cboInterestRate.TabIndex = 8;
            // 
            // btnCalculatePayment
            // 
            this.btnCalculatePayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculatePayment.Location = new System.Drawing.Point(43, 399);
            this.btnCalculatePayment.Name = "btnCalculatePayment";
            this.btnCalculatePayment.Size = new System.Drawing.Size(324, 77);
            this.btnCalculatePayment.TabIndex = 9;
            this.btnCalculatePayment.Text = "Calculate Payment";
            this.btnCalculatePayment.UseVisualStyleBackColor = true;
            this.btnCalculatePayment.Click += new System.EventHandler(this.btnCalculatePayment_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(43, 482);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(123, 63);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(246, 482);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(121, 63);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblMonthlyPayment
            // 
            this.lblMonthlyPayment.AutoSize = true;
            this.lblMonthlyPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthlyPayment.Location = new System.Drawing.Point(12, 580);
            this.lblMonthlyPayment.Name = "lblMonthlyPayment";
            this.lblMonthlyPayment.Size = new System.Drawing.Size(0, 36);
            this.lblMonthlyPayment.TabIndex = 12;
            // 
            // lblprincipalInputError
            // 
            this.lblprincipalInputError.AutoSize = true;
            this.lblprincipalInputError.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprincipalInputError.ForeColor = System.Drawing.Color.Red;
            this.lblprincipalInputError.Location = new System.Drawing.Point(373, 13);
            this.lblprincipalInputError.Name = "lblprincipalInputError";
            this.lblprincipalInputError.Size = new System.Drawing.Size(36, 36);
            this.lblprincipalInputError.TabIndex = 13;
            this.lblprincipalInputError.Text = "X";
            // 
            // lblTermInYearsError
            // 
            this.lblTermInYearsError.AutoSize = true;
            this.lblTermInYearsError.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTermInYearsError.ForeColor = System.Drawing.Color.Red;
            this.lblTermInYearsError.Location = new System.Drawing.Point(209, 81);
            this.lblTermInYearsError.Name = "lblTermInYearsError";
            this.lblTermInYearsError.Size = new System.Drawing.Size(36, 36);
            this.lblTermInYearsError.TabIndex = 14;
            this.lblTermInYearsError.Text = "X";
            // 
            // lblOtherInputError
            // 
            this.lblOtherInputError.AutoSize = true;
            this.lblOtherInputError.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOtherInputError.ForeColor = System.Drawing.Color.Red;
            this.lblOtherInputError.Location = new System.Drawing.Point(279, 260);
            this.lblOtherInputError.Name = "lblOtherInputError";
            this.lblOtherInputError.Size = new System.Drawing.Size(36, 36);
            this.lblOtherInputError.TabIndex = 15;
            this.lblOtherInputError.Text = "X";
            // 
            // lblInterestRateError
            // 
            this.lblInterestRateError.AutoSize = true;
            this.lblInterestRateError.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterestRateError.ForeColor = System.Drawing.Color.Red;
            this.lblInterestRateError.Location = new System.Drawing.Point(219, 334);
            this.lblInterestRateError.Name = "lblInterestRateError";
            this.lblInterestRateError.Size = new System.Drawing.Size(36, 36);
            this.lblInterestRateError.TabIndex = 16;
            this.lblInterestRateError.Text = "X";
            // 
            // lstErrorFound
            // 
            this.lstErrorFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstErrorFound.FormattingEnabled = true;
            this.lstErrorFound.HorizontalScrollbar = true;
            this.lstErrorFound.ItemHeight = 29;
            this.lstErrorFound.Location = new System.Drawing.Point(321, 141);
            this.lstErrorFound.Name = "lstErrorFound";
            this.lstErrorFound.Size = new System.Drawing.Size(467, 178);
            this.lstErrorFound.TabIndex = 17;
            // 
            // lblErrorFound
            // 
            this.lblErrorFound.AutoSize = true;
            this.lblErrorFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorFound.Location = new System.Drawing.Point(315, 91);
            this.lblErrorFound.Name = "lblErrorFound";
            this.lblErrorFound.Size = new System.Drawing.Size(301, 36);
            this.lblErrorFound.TabIndex = 18;
            this.lblErrorFound.Text = "List of error(s) found :";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 654);
            this.Controls.Add(this.lblErrorFound);
            this.Controls.Add(this.lstErrorFound);
            this.Controls.Add(this.lblInterestRateError);
            this.Controls.Add(this.lblOtherInputError);
            this.Controls.Add(this.lblTermInYearsError);
            this.Controls.Add(this.lblprincipalInputError);
            this.Controls.Add(this.lblMonthlyPayment);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalculatePayment);
            this.Controls.Add(this.cboInterestRate);
            this.Controls.Add(this.lblInterest);
            this.Controls.Add(this.txtOtherInput);
            this.Controls.Add(this.radOther);
            this.Controls.Add(this.rad30Years);
            this.Controls.Add(this.rad15Years);
            this.Controls.Add(this.lblTermInYears);
            this.Controls.Add(this.txtPrincipalInput);
            this.Controls.Add(this.lblPrincipal);
            this.Name = "frmMain";
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrincipal;
        private System.Windows.Forms.TextBox txtPrincipalInput;
        private System.Windows.Forms.Label lblTermInYears;
        private System.Windows.Forms.RadioButton rad15Years;
        private System.Windows.Forms.RadioButton rad30Years;
        private System.Windows.Forms.RadioButton radOther;
        private System.Windows.Forms.TextBox txtOtherInput;
        private System.Windows.Forms.Label lblInterest;
        private System.Windows.Forms.ComboBox cboInterestRate;
        private System.Windows.Forms.Button btnCalculatePayment;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblMonthlyPayment;
        private System.Windows.Forms.Label lblprincipalInputError;
        private System.Windows.Forms.Label lblTermInYearsError;
        private System.Windows.Forms.Label lblOtherInputError;
        private System.Windows.Forms.Label lblInterestRateError;
        private System.Windows.Forms.ListBox lstErrorFound;
        private System.Windows.Forms.Label lblErrorFound;
    }
}

