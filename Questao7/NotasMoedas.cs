using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace AvaliacaoSprint2.Questao7
{
    public class NotasMoedas
    {
        static void Main(string[] args)
        {
            decimal valor = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            int nota100 = 0, nota50 = 0, nota20 = 0, nota10 = 0, nota5 = 0, nota2 = 0;
            int moeda1 = 0, moeda50 = 0, moeda25 = 0, moeda10 = 0, moeda5 = 0, moeda01 = 0;

            while (valor >= 100)
            {
                valor -= 100;
                nota100++;
            }

            while (valor >= 50)
            {
                valor -= 50;
                nota50++;
            }

            while (valor >= 20)
            {
                valor -= 20;
                nota20++;
            }

            while (valor >= 10)
            {
                valor -= 10;
                nota10++;
            }

            while (valor >= 5)
            {
                valor -= 5;
                nota5++;
            }

            while (valor >= 2)
            {
                valor -= 2;
                nota2++;
            }


            while (valor >= 1)
            {
                valor -= 1;
                moeda1++;
            }


            while (valor >= 0.50m)
            {
                valor -= 0.50m;
                moeda50++;
            }

            while (valor >= 0.25m)
            {
                valor -= 0.25m;
                moeda25++;
            }

            while (valor >= 0.10m)
            {
                valor -= 0.10m;
                moeda10++;
            }

            while (valor >= 0.05m)
            {
                valor -= 0.05m;
                moeda5++;
            }

            while (valor >= 0.01m)
            {
                valor -= 0.01m;
                moeda01++;
            }


            Console.WriteLine("NOTAS:");


            Console.WriteLine(nota100 + " nota(s) de R$ 100.00");

            Console.WriteLine(nota50 + " nota(s) de R$ 50.00");

            Console.WriteLine(nota20 + " nota(s) de R$ 20.00");

            Console.WriteLine(nota10 + " nota(s) de R$ 10.00");

            Console.WriteLine(nota5 + " nota(s) de R$ 5.00");

            Console.WriteLine(nota2 + " nota(s) de R$ 2.00");

            Console.WriteLine("MOEDAS:");

            Console.WriteLine(moeda1 + " moeda(s) de R$ 1.00");

            Console.WriteLine(moeda50 + " moeda(s) de R$ 0.50");

            Console.WriteLine(moeda25 + " moeda(s) de R$ 0.25");

            Console.WriteLine(moeda10 + " moeda(s) de R$ 0.10");

            Console.WriteLine(moeda5 + " moeda(s) de R$ 0.05");

            Console.WriteLine(moeda01 + " moeda(s) de R$ 0.01");
            Console.ReadKey();
        }
    }
}
