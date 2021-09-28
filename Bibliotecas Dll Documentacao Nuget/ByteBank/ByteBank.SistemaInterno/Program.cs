using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaInterno
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaCorrente = new ContaCorrente(847, 489754);
            Console.WriteLine(contaCorrente.Saldo);
            Console.ReadLine();


        }
    }
}
