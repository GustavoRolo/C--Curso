using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios2
{
    internal class Alunos
    {
        public string name;
        public double nota1;
        public double nota2;
        public double nota3;


        public double Soma()
        {
            return nota1 + nota2 + nota3;
        }

        public string Resultado()
        {
            string resultado;
            double faltaram;

            if (Soma() >= 60)
            {
                return resultado = "Aprovado!";
            }
            else
            {
                faltaram = 60 - Soma();
                return resultado = "Reprovado!\nFaltaram " + faltaram + " pontos.";

                
            }
        }

    }
}
