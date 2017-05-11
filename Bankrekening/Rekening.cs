using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankrekening
{
    class Rekening
    {
        public double Saldo { get; set; }

        public void stort(double amount)
        {
            Saldo += amount;
        }

        public void NeemOp(double amount)
        {
            Saldo -= amount;
        }

        public void SaveSaldo()
        {

        }
    }
}
