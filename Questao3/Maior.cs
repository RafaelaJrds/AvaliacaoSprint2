using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliacaoSprint2.Questao3
{
    internal class Maior
    {
        static void Main(string[] args)
        {
            string[] Maior = Console.ReadLine().Split(' ');
            int A = int.Parse(Maior[0]), B = int.Parse(Maior[1]), C = int.Parse(Maior[2]);

            int maiorAB = (A + B + Math.Abs(A - B)) / 2;
            int maiorABC = (maiorAB + C + Math.Abs(maiorAB - C)) / 2;

            Console.WriteLine(maiorABC + " eh o maior");

            Console.ReadKey();
        }
    }
}