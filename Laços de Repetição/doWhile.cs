using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // do while() - executa pelo menos 1 vez e depois testa a condiçã
            int numero = 1;
            do
            {
                Console.WriteLine(numero);
                numero++;
            } while (numero < 10); 
            
            Console.ReadKey();



        }
    }
}
