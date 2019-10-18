using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountOperationAppPractice1
{
    class Account
    {
        public int acnumber;
        public string cname;
        private double balance;

        public double Deposit(double amount)
        {
            balance = balance + amount;
            return balance ;

        }
        public double withdraw(double amount)
        {
            balance= balance - amount;
            return balance;
        }
        public string getinfo()
        {
            var msg = cname + " Your account number:" + acnumber + "and its balance:" + balance;
            return msg;
        }
    }
}
