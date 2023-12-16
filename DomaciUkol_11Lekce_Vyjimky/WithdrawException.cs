using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomaciUkol_11Lekce_Vyjimky
{
    internal class WithdrawException : ArgumentOutOfRangeException
    {
        public string myMessage;

        public WithdrawException(string paramName, double withdraw)
        {
            myMessage = $"Z účtu chcete vybrat zápornou částku, konkrétně: {withdraw},- Kč.";
        }
    }
}
