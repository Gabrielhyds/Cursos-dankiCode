using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso
{
    public class ContaCorrente
    {
        private int Agencia;
        private int Numero;
        public static double TaxaOperacao { get; private set; } 
        public static int TotalContasCriadas { get; private set; }
        
        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;

            TaxaOperacao = 30 / TotalContasCriadas;
            
            TotalContasCriadas++;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente conta = new ContaCorrente(9999, 234567);
            Console.WriteLine(ContaCorrente.TotalContasCriadas);
            Console.ReadLine();
           Console.ReadKey();
        }
    }
}
