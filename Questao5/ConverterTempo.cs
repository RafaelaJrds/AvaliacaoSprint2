using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliacaoSprint2.Qustao5
{
    public class ConverterTempo
    {
        static void Main(string[] args)
        {
            int tempoSegundos = int.Parse(Console.ReadLine());

            int hora = (tempoSegundos / 3600);
            int minutos = (int)((tempoSegundos - (hora * 3600)) / 60);
            int segundos = (int)((tempoSegundos - (hora * 3600)) - (minutos * 60));

            Console.WriteLine(hora + ":" + minutos + ":" + segundos);

            Console.ReadKey();
        }

    }
}
