using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            //ContaCorrente contaCorrente = new ContaCorrente(128, 29233);
            //Console.WriteLine(contaCorrente.Numero);
            //Console.ReadLine();

            DateTime dataFimPagamento = new DateTime(2021, 10, 18);
            DateTime dataCorrente = DateTime.Now;
            TimeSpan diferenca = dataFimPagamento - dataCorrente;

            Console.WriteLine(Humanizer.TimeSpanHumanizeExtensions.Humanize(diferenca));
            Console.ReadLine();
        }

        static string getIntervaloDeTempoLegivel(TimeSpan timeSpan)
        {
            return timeSpan.Days + " dias ";
        }

    }

}
