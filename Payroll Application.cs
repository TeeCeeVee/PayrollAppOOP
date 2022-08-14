using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobSourceApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalculateHomePay_Click(object sender, EventArgs e)
        {
            string name;
            int dependents;
            int hoursWorked;

            try
            {
                // variables to store the input
                name = TxtName.Text;
                hoursWorked = int.Parse(TxtHoursWorked.Text);
                dependents = int.Parse(TxtHoursWorked.Text);

                // instantiate

                Employee employee = new Employee(name, hoursWorked, dependents);

                // calculations
                TxtGrossPay.Text = employee.Gross.ToString("c");
                TxtFedDeduction.Text = employee.FederalTax.ToString("c");
                TxtSocialSecurityDeduction.Text = employee.SocialSecurityRate.ToString("c");
                TxtAgencyFee.Text = employee.AgencyFee.ToString("c");
                TxtNetPay.Text = employee.NetPay.ToString("c");

      


            }
            catch (Exception)
            {

                MessageBox.Show("You have to enter numbers into the boxes, not text");
                BtnResetDisplay.PerformClick();
            }
        }

        private void BtnResetDisplay_Click(object sender, EventArgs e)
        {
            TxtName.Clear();
            TxtHoursWorked.Clear();
            TxtDependents.Clear();
            TxtName.Clear();
            TxtHoursWorked.Clear();
            TxtDependents.Clear();
            TxtGrossPay.Clear();
            TxtFedDeduction.Clear();
            TxtSocialSecurityDeduction.Clear();
            TxtAgencyFee.Clear();
            TxtNetPay.Clear();
            
     



           
        }


    }
}
