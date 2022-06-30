using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios2
{
    internal class Funcionario
    {
        public string name;
        public double grooswage;
        public double tax;

        public double NetWage()
        {
            return  grooswage - tax;
        }

        public double UpWage(double porcent)
        {
            return grooswage = grooswage + (grooswage * porcent / 100);
        }

        public override string ToString()
        {
            return name
            + ", R$ "
            + NetWage().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
