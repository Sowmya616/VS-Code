using System;

namespace LitwareLib
{
    /// <summary>
    /// Register new employee, calculate HRA DA TA PF GROSS NET TDS etc.
    /// </summary>
    public class Employee
    {
        #region Fields


        private int EmpNo;
        private string EmpName;
        private double Salary;
        private double HRA;
        private double TA;
        private double DA;
        private double PF;
        private double TDS;
        private double NetSalary;
        private double GrossSalary;
        #endregion

        #region Properties
        public int EmployeeNo { get { return this.EmpNo; } set { this.EmpNo = value; } }

        public string EmployeeName { get { return this.EmpName; } set { this.EmpName = value; } }

        public double EmpSalary { get { return this.Salary; } set { Salary = value; } }

        public double GetGrossSalary { get { return this.GrossSalary; } set { this.GrossSalary = value; } }
        #endregion

        #region Calculate PF TDS Net Method
        protected virtual void CalculateSalary()
        {
            this.PF = this.GrossSalary * 0.10;
            this.TDS = this.GrossSalary * 0.18;
            this.NetSalary = this.GrossSalary - (this.PF + this.TDS);
        }
        #endregion

        #region Calculate HRA TA DA method
        protected void Calculate(double HRA_Percent, double TA_Percent, double DA_Percent)
        {
            this.HRA = this.Salary * (HRA_Percent / 100);
            this.TA = this.Salary * (TA_Percent / 100);
            this.DA = this.Salary * (DA_Percent / 100);
            this.GrossSalary = this.Salary + this.HRA + this.TA + this.DA;
        }
        #endregion

        #region Check Employee Number Method
        //private static bool CheckEmpNo(int empNo)
        //{
        //    foreach(Employee emp in employee)
        //    {
        //        if(empNo == emp.EmpNo)
        //        {
        //            Console.WriteLine("Employee Number already Exists...Try other Employee No...");
        //            return false;
        //        }
        //    }
        //    return true;
        //}
        #endregion

        #region Display Method
        public void Display()
        {

            Console.WriteLine("No: {0}", this.EmpNo);
            Console.WriteLine("Name: {0}", this.EmpName);
            Console.WriteLine("Salary: {0}", this.Salary);
            Console.WriteLine("HRA: {0}", this.HRA);
            Console.WriteLine("TA: {0}", this.TA);
            Console.WriteLine("DA: {0}", this.DA);
            Console.WriteLine("Gross: {0}", this.GrossSalary);
            Console.WriteLine("PF: {0}", this.PF);
            Console.WriteLine("TDS: {0}", this.TDS);
            Console.WriteLine("Net: {0}", this.NetSalary);

        }
        #endregion



        #region Set Employee Data Method
        public void SetEmployeeData(int EmpNo, string EmpName, double Salary)
        {


            this.EmpNo = EmpNo;
            this.EmpName = EmpName;
            this.Salary = Salary;

            if (Salary < 5000)
            {
                this.Calculate(10, 5, 15);
                this.CalculateSalary();

            }
            else if (Salary < 10000)
            {
                this.Calculate(15, 10, 20);
                this.CalculateSalary();

            }
            else if (Salary < 15000)
            {
                this.Calculate(20, 15, 25);
                this.CalculateSalary();

            }
            else if (Salary < 20000)
            {
                this.Calculate(25, 20, 30);
                this.CalculateSalary();

            }
            else
            {
                this.Calculate(30, 25, 35);
                this.CalculateSalary();
            }

            this.Display();

        }
        #endregion
    }
}
