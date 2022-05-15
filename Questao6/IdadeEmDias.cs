using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliacaoSprint2.Questao6
{
    public class IdadeEmDias
    {
        static void Main(string[] args)
        {
            int idadeEmDias = int.Parse(Console.ReadLine());

            int anos = (idadeEmDias / 365);
            int meses = (int)((idadeEmDias - (anos * 365)) / 30);
            int dias = (int)((idadeEmDias - (anos * 365)) - (meses * 30));

            Console.WriteLine(anos + " ano(s)");
            Console.WriteLine(meses + " mes(es)");
            Console.WriteLine(dias + " dia(s)");

            Console.ReadKey();

        }
    }
}
