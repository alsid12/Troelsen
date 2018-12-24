using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatisDataAndMembers
{
    // A simple savings account class.
    class SavingsAccount
    {
        // Instance level data.
        public double currBalance;

        // A static piece of data.
        public static double currInterestRate = 0.04;

        public SavingsAccount(double balance)
        {
            currBalance = balance;
        }

        // Static members to get\set interest rate.
        public static void SetInterestRate(double newRate)
        { currInterestRate = newRate; }

        public static double GetInterestRate()
        {
            return currInterestRate;
        }
    }
}
