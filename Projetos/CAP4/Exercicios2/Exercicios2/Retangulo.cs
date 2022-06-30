using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios2
{
    internal class Retangulo
    {
        public double width;
        public double heigth;

        public double Area() {


            return  width * heigth;
        }

        public double Perimeter()
        {
            return  2 * (width + heigth);
        }

        public double Diagonal()
        {
            return  Math.Sqrt(Math.Pow(heigth,2) + Math.Pow(width,2));
        }
}
}

