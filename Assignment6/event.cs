using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6_1
{
    #region Delegates 
    public delegate void UnderBalance(double balance, double amount);
    public delegate void BalanceZero(double balance, double amount);
    #endregion

    public class Events
    {
        #region UnderBalance Event
        public static void UnderBalanceEvent(double balance, double amount)
        {
            if (balance < 500)
            {
                Console.WriteLine("\nYour Account Balance is Under Balance by UnderBalance Event");
            }
        }
        #endregion

        #region BalanceZero Event
        public static void BalanceZeroEvent(double balance, double amount)
        {
            if (balance == 0)
            {
                Console.WriteLine("\nYour Account balance is 0 by BalanceZero Event");
            }
        }
        #endregion
    }
}
