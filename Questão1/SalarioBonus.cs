using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliacaoSprint2.Questao1
{
    public class SalarioBonus
    {
        static void Main(string[] args)
        {
            string nomeDoVendedor = Console.ReadLine();
            double salarioFixo = double.Parse(Console.ReadLine());
            double vendasDoMes = double.Parse(Console.ReadLine());

            double comissao = vendasDoMes * 0.15;

            double salarioComComissao = (salarioFixo + comissao);

            Console.WriteLine("TOTAL = R$ {0:0.00}", salarioComComissao);


            Console.ReadKey();
        }



    }
}