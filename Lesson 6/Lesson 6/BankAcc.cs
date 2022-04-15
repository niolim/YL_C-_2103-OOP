using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6
{
    internal class BankAcc
    {
        private int bankAcc;
        private string bankName;

        public BankAcc(int x, string y)
        {
            bankAcc = x;
            bankName = y;
        }

        public override bool Equals (object obj)
        {
            if (obj == null || GetType() != obj.GetType()) 
                return false;
            BankAcc bank = (BankAcc)obj;
            return (bankAcc == bank.bankAcc);
        }

        public override int GetHashCode()
        {
            return bankAcc ;  
        }

        public override string ToString()
        {

            return $"{bankName} -- {bankAcc}";

        }

    }
}
