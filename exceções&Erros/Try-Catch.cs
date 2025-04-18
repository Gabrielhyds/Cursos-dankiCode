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

            try
            {
                TotalContasCriadas++;
                TaxaOperacao = 30 / TotalContasCriadas;
                Console.WriteLine("O resultado é: " + TaxaOperacao);
            }
            catch (DivideByZeroException)
            {

                Console.WriteLine("Não podemos dividir por 0");
            }

        }

    }
    class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente conta = new ContaCorrente(9999, 234567);
            ContaCorrente conta2 = new ContaCorrente(1234, 765432);
            ContaCorrente conta3 = new ContaCorrente(0000, 222222);

            Console.ReadKey();
        }
    }
}
