using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod.Account;
using FactoryMethod.FactoryMethod;

namespace FactoryMethod
{
    public class BankAccountService
    {
        public static BankAccount GetAccount(decimal salary)
        {
            if (salary < 1000) return new GreyAccountFactory().Create();
            if (salary < 3000) return new GreenAccountFactory().Create();
            if (salary < 5000) return new RedAccountFactory().Create();
            return new BlueAccountFactory().Create();
        }
    }
}
