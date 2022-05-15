using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace AvaliacaoSprint2.Questao8
{
    public class SentencaDancante
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                string original = Console.ReadLine();
                if (string.IsNullOrEmpty(original)) break;

                string transformada = "";
                bool minusculo = true;

                foreach (char charactere in original)
                {
                    if (minusculo & charactere != ' ')
                    {
                        minusculo = false;
                        transformada += Char.ToUpper(charactere);
                    }
                    else if (!minusculo & charactere != ' ')
                    {
                        minusculo = true;
                        transformada += Char.ToLower(charactere);
                    }
                    else
                    {
                        transformada += " ";
                    }
                }

                Console.WriteLine(transformada);
            }
        }
    }
}
