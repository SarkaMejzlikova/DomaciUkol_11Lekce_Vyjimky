using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomaciUkol_11Lekce_Vyjimky
{
    internal class BalanceException : ArgumentOutOfRangeException
    {
        public string myMessage;

        public BalanceException(string paramName, double withdraw, double balance)
        {
            myMessage = $"Z účtu chcete vybrat větší částku než je zůstatek. Zůstatek: {balance},- Kč, výběr: {withdraw},- Kč.";
        }
    }
}
