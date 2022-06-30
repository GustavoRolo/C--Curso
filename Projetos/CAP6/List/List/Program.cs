using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Gustavo");
            list.Add("Dahra");
            list.Add("Dahraaa");
            list.Insert(1, "Guimarães");

            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

            string s1 = list.Find(x => x[0] == 'G');
            Console.WriteLine("First 'G' : " + s1);

            string s2 = list.FindLast(x => x[0] == 'G');
            Console.WriteLine("Last 'G' : " + s2);

            int pos1 = list.FindIndex(x => x[0] == 'G');
            Console.WriteLine("Posição First 'G' " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'G');
            Console.WriteLine("Posição First 'G' " + pos2);

            List<string> list2 = list.FindAll(x => x.Length == 7);
            Console.WriteLine("-----------------------");
            foreach (string item in list2)
            {
                Console.WriteLine(item);
                Console.WriteLine("Fim");
            }


            
        }
    }
}
