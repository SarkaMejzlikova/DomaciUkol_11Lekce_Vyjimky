using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomaciUkol_11Lekce_Vyjimky
{
    internal class Account
    {
        public string AccountNumber;
        public string OwnerName;
        public double Balance;

        public Account(string accountNumber, string ownerName) 
        { 
            AccountNumber = accountNumber;
            OwnerName = ownerName;
            Balance = 0;
        }    

        public void Deposit(double deposit)
        {
            if(deposit < 0)
            {
                throw new DepositException(nameof(deposit), deposit);
            }
            else
            {
                Balance += deposit;
            }
        }

        public void Withdraw (double withdraw)
        {
            if (withdraw < 0)
            {
                throw new WithdrawException(nameof(withdraw), withdraw);
            }
            else if(withdraw > Balance)
            {
                throw new BalanceException(nameof(withdraw), withdraw, Balance);
            }
            else
            {
                Balance -= withdraw; 
            }
               
        }
    }
}
