using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliacaoSprint2.Questao9
{
    public class SamplesArrayList
    {
        public static void Main()
        {
            int tamanho = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[tamanho];
            var pares = new List<int>();
            var impares = new List<int>();

            for (int i = 0; i < tamanho; i++)
            {
                int dado = Convert.ToInt32(Console.ReadLine());
                arr[i] = dado;
            }

            Array.Sort(arr);
            foreach (int number in arr)
            {
                if (number % 2 == 0)
                {
                    pares.Add(number);
                }
                if (number % 2 != 0)
                {
                    impares.Add(number);
                }
            }
            impares.Reverse();

            foreach (int i in pares)
            {
                Console.WriteLine(i);
            }
            foreach (int i in impares)
            {
                Console.WriteLine(i);
            }
        }
    }
}
