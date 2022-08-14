using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSourceApp
{
    internal class Employee
    {
        // constant fields for calculations
        private const decimal RATE = 150.00m;
        private const decimal FEDERAL_TAX = 0.25m;
        private const decimal SOCIAL_SECURITY_RATE = 0.0785m;
        private const decimal DEPENDENT_ALLOWANCE = 0.0575m;
        private const decimal AGENCY_CHARGE = 0.13m;

       

        //fields
        private string name;
        private double hoursWorked;
        private int dependents;
        private decimal federalTax;
        private decimal socialSecurityRate;
        private decimal agencyFee;
        private decimal gross;
        private decimal netPay;

        //constructor
        public Employee(string name, double hoursWorked, int dependents)
        {
            this.name = name;
            this.hoursWorked = hoursWorked;
            this.dependents = dependents;
            DetermineGross();
            DetermineFederalTaxRate();
            DetermineAgencyFee();
            DetermineSocialSecurity();
            DetermineNet();

        }

        //default constructor
        public Employee()
        {

        }

        //getters and setters
        public string Name { get => name; set => name = value; }
        public double HoursWorked { get => hoursWorked; set => hoursWorked = value; }
        public int Dependents { get => dependents; set => dependents = value; }
        public decimal FederalTax { get => federalTax; }
        public decimal SocialSecurityRate { get => socialSecurityRate; }
        public decimal AgencyFee { get => agencyFee; }
        public decimal Gross { get => gross;}
        public decimal NetPay { get => netPay;}

        // methods

        public void DetermineGross()
        {
            gross = ((decimal)(hoursWorked) * RATE);
        }

        public void DetermineFederalTaxRate()
        {
            federalTax = (gross - (gross * (DEPENDENT_ALLOWANCE
                 * dependents))) * FEDERAL_TAX;
        }

        public void DetermineAgencyFee()
        {
            agencyFee = gross * AGENCY_CHARGE;

        }

        public void DetermineSocialSecurity()
        {
            socialSecurityRate = gross * SOCIAL_SECURITY_RATE;
        }

        public void DetermineNet()
        {
            netPay = gross - socialSecurityRate - federalTax - agencyFee;
        }
    }
}
