using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    internal class Clientes
    {
        private long _numberaccount;
        private string _name;
        private double _deposit;
        private double _saldo;
        private double _saque;

        public long NumberAccount
        {
            get { return _numberaccount; }
            set { _numberaccount = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public double Deposit
        {
            get { return _deposit; }
            set
            {
                _deposit = value;
                _saldo = value + _saldo;
            }
        }

        public double Saldo
        {
            get { return _saldo; }

        }

        public double Saque
        {
            set
            {
                _saque = value;
                _saldo = (_saldo - (_saque + 5));
            }
        }

        public override string ToString()
        {
            return "Conta " + _numberaccount + " Titular: " + _name + " Saldo: $ " + _saldo + "\n";
        }

    }
}
