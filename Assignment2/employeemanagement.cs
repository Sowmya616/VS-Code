using System;

using LitwareLib;


namespace Employee_Management
{

    /// <summary>
    /// Employee  Management Class
    /// </summary>
    public class Program
    {
        #region Get Valid Integer Method
        public static int GetValidInteger(string msg = null)
        {
            int value = 0;
            try
            {
                do
                {
                    if (msg != null)
                        Console.Write(msg);
                    if (!int.TryParse(Console.ReadLine(), out value))
                    {
                        Console.WriteLine("Enter a valid number...Try Again...");
                        continue;
                    }
                    break;
                } while (true);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return value;
        }
        #endregion

        #region Get Valid Double Method
        public static double GetValidDouble(string msg = null)
        {
            double value = 0;
            try
            {
                do
                {
                    if (msg != null)
                        Console.Write(msg);
                    if (!double.TryParse(Console.ReadLine(), out value))
                    {
                        Console.WriteLine("Enter a valid number...Try Again...");
                        continue;
                    }
                    break;
                } while (true);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return value;
        }
        #endregion

        #region Take Input Method
        public static void TakeInput(Employee emp)
        {
            try
            {
                Console.WriteLine("\n--------------------Register New Employee--------------------");
                int id = Program.GetValidInteger("Enter Employee Number: ");

                Console.Write("Enter Employee Name: ");
                string name = Console.ReadLine();

                double salary = Program.GetValidDouble("Enter Employee Salary: ");
                emp.SetEmployeeData(id, name, salary);
                Console.WriteLine();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        #endregion

        #region Get Gross Salary Method
        private static void GetGrossSalary(Employee em)
        {
            Console.WriteLine("Gross Salary is: {0}", em.GetGrossSalary);
        }
        #endregion

        #region Main Method
        static void Main(string[] args)
        {
            try
            {
                int size = Program.GetValidInteger("How many Employees record want to insert: ");
                Employee.SetSize(size);
                Employee emp = null;

                for (int i = 0; i < size; i++)
                {
                    emp = new Employee();
                    Program.TakeInput(emp);
                    Program.GetGrossSalary(emp);

                }

                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        #endregion
    }
}
