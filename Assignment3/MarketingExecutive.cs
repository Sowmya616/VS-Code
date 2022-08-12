using System;

using LitwareLib;

namespace Assignment3
{
    internal class MarketingExecutive : Employee
    {
        #region Fields
        private double kmTravel;
        private double tourAllowance;
        private double telephoneAllowance;
        #endregion

        #region Calculate Allowances
        protected void CalculateAllowance()
        {
            this.tourAllowance = 5 * this.kmTravel;
            this.telephoneAllowance = 1000;
        }
        #endregion

        #region Calculate Gross Salary
        protected void GrossCalculation()
        {
            this.GetGrossSalary += this.kmTravel + this.tourAllowance;
        }
        #endregion

        protected override void CalculateSalary()
        {
            this.GrossCalculation();
            base.CalculateSalary();
        }
    }
}
