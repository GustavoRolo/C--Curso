using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propetis
{
    internal class Class1
    {
        private int _id;
        private string _cpf;
        private double _saldo;


        public Class1(int id, string cpf, double saldo)
        {
            _id = id;
            _cpf = cpf;
            _saldo = saldo;
        }

        public Class1()
        {

        }
        public int Id
        {
            get{
                return _id;
            }

        }

        public string Cpf
        {
            get{
                return _cpf;
            }

        }
        public double saldo
        {
            get{
                return _saldo;
            }
            set{
                _saldo = value;
            }
        }
    }
}
