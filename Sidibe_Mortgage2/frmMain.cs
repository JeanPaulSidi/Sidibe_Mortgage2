using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sidibe_Mortgage2
{
    public partial class frmMain : Form
    {
        int ErrorCounter;
        bool ErrorFound;

        public frmMain()
        {
            InitializeComponent();
        }

        public void DisplayFormMainInitialState() 
        {
            txtPrincipalInput.Clear();
            rad15Years.Checked = false;
            rad30Years.Checked = false;
            radOther.Checked = false;
            txtOtherInput.Clear();
            cboInterestRate.Text = string.Empty;
            lblMonthlyPayment.Text = string.Empty;
            txtPrincipalInput.Focus();
            btnReset.Enabled = false;
        }

        public void CheckTextboxPrincipalInput()
        {
            ErrorFound = false;

            if (txtPrincipalInput.Text == string.Empty) 
            {
                ErrorFound = true;
                ErrorCounter++;
                lstErrorFound.Items.Add("Error " + ErrorCounter + " : Missing input (principal amount)");
            }
            else if (!int.TryParse(txtPrincipalInput.Text, out int PrincipalAmount)) 
            {
                ErrorFound = true;
                ErrorCounter++;
                lstErrorFound.Items.Add("Error " + ErrorCounter + " : Input (principal amount) must be a whole number");
            }
            else if (PrincipalAmount == 0) 
            {
                ErrorFound = true;
                ErrorCounter++;
                lstErrorFound.Items.Add("Error " + ErrorCounter + " : Input (principal amount) cannot be 0");
            }
            else if (PrincipalAmount < 0) 
            {
                ErrorFound = true;
                ErrorCounter++;
                lstErrorFound.Items.Add("Error " + ErrorCounter + " : Input (principal amount) cannot be negative");
            }

            if (ErrorFound) 
            {
                lblprincipalInputError.Visible = true;
            }
        }

        public void CheckTextboxOtherInput()
        {
            if (txtOtherInput.Text == string.Empty) 
            {
                ErrorFound = true;
                ErrorCounter++;
                lstErrorFound.Items.Add("Error " + ErrorCounter + " : Missing input (number of years)");
            }
            else if (!int.TryParse(txtOtherInput.Text, out int NumberOfYears)) 
            {
                ErrorFound = true;
                ErrorCounter++;
                lstErrorFound.Items.Add("Error " + ErrorCounter + " : Input (number of years) must be a whole number");
            }
            else if (NumberOfYears == 0) 
            {
                ErrorFound = true;
                ErrorCounter++;
                lstErrorFound.Items.Add("Error " + ErrorCounter + " : Input (number of years) cannot be 0");
            }
            else if (NumberOfYears < 0) 
            {
                ErrorFound = true;
                ErrorCounter++;
                lstErrorFound.Items.Add("Error " + ErrorCounter + " : Input (number of years) cannot be negative");
            }
            else if ( !(NumberOfYears >= 5 && NumberOfYears <= 40) ) 
            {
                ErrorFound = true;
                ErrorCounter++;
                lstErrorFound.Items.Add("Error " + ErrorCounter + " : Input (number of years) must be between 5 and 40");
            }

            if (ErrorFound) 
            {
                lblOtherInputError.Visible = true;
            }
        }

        public void CheckRadiobuttons() 
        {
            ErrorFound = false;

            if ( !(rad15Years.Checked) && !(rad30Years.Checked) && !(radOther.Checked) ) 
            {
                ErrorFound = true;
                ErrorCounter++;
                lstErrorFound.Items.Add("Error " + ErrorCounter + " : Term in years has not been selected");
                lblTermInYearsError.Visible = true;
            }
            else if (radOther.Checked) 
            {
                CheckTextboxOtherInput();
            }
        }

        public void CheckComboboxInterestRate() 
        {
            ErrorFound = false;

            if (cboInterestRate.Text == string.Empty) 
            {
                ErrorFound = true;
                ErrorCounter++;
                lstErrorFound.Items.Add("Error " + ErrorCounter + " : Interest rate has not been selected");
                lblInterestRateError.Visible = true;
            }
        }

        public void HideErrorMessages() 
        {
            lblprincipalInputError.Visible = false;
            lblTermInYearsError.Visible = false;
            lblOtherInputError.Visible = false;
            lblInterestRateError.Visible = false;
            lblErrorFound.Visible = false;
            lstErrorFound.Visible = false;
        }

        public void LookForErrors() 
        {
            lstErrorFound.Items.Clear();
            ErrorCounter = 0;

            HideErrorMessages();
            CheckTextboxPrincipalInput();
            CheckRadiobuttons();
            CheckComboboxInterestRate();
        }

        public double CalculateNumberOfPayments() 
        {
            if (rad15Years.Checked) 
            {
                return (15 * 12);
            }
            if (rad30Years.Checked) 
            {
                return (30 * 12);
            }
            else 
            {
                return (double.Parse(txtOtherInput.Text) * 12);
            }
        }

        public double CalculateMonthlyInterestRate() 
        {
            return (double.Parse(cboInterestRate.Text) / 1200);
        }

        public void CalculateMonthlyPayment() 
        {
            double MonthlyInterestRate;
            double TotalInterest;
            double NumberOfPayments;
            decimal PrincipalAmount;
            double MonthlyMorgage;
            decimal TotalMonthlyMorgage;

            MonthlyInterestRate = CalculateMonthlyInterestRate();
            NumberOfPayments = CalculateNumberOfPayments();

            TotalInterest = 1 + MonthlyInterestRate;

            MonthlyMorgage = MonthlyInterestRate * Math.Pow(TotalInterest, NumberOfPayments) / (Math.Pow(TotalInterest, NumberOfPayments) - 1);
            PrincipalAmount = decimal.Parse(txtPrincipalInput.Text);

            TotalMonthlyMorgage = (decimal)MonthlyMorgage * PrincipalAmount;
            lblMonthlyPayment.Text = "Monthly payment is " + TotalMonthlyMorgage.ToString("C");
        }

        private void radOther_CheckedChanged(object sender, EventArgs e)
        {
            txtOtherInput.Visible = radOther.Checked;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DisplayFormMainInitialState();
            HideErrorMessages();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCalculatePayment_Click(object sender, EventArgs e)
        {
            LookForErrors();

            lblErrorFound.Visible = ErrorCounter > 0;
            lstErrorFound.Visible = ErrorCounter > 0;
            btnReset.Enabled = ErrorCounter == 0;

            if (ErrorCounter == 0) 
            {
                CalculateMonthlyPayment();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Text = "Jean Paul Sidibe : Mortgage Calculator";

            DisplayFormMainInitialState();
            HideErrorMessages();
        }
    }
}
