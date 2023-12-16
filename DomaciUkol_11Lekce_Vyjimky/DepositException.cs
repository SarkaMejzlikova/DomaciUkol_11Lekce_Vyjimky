using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DomaciUkol_11Lekce_Vyjimky
{
    internal class DepositException : ArgumentOutOfRangeException
    {

        public string myMessage;

        public DepositException(string paramName, double deposit)
        {
            myMessage = $"Na účet chcete vložit zápornou částku, konkrétně: {deposit},- Kč." ;
        }
    }
}
