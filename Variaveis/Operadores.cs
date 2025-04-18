using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Operadores 
                //  + (adicão)
                //  - (subtração)
                //  / (Divisão)
                //  * (multiplicação)

            // EXEMPLO:
                // int soma = 10 + 2;
                // System.console.WriteLine(soma);

                Console.Write("Escreva um número: ");
                int numero_1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Escreva outro número: ");
                int numero_2 = Convert.ToInt32(Console.ReadLine());

                int total = (numero_1 + numero_2);
                System.Console.WriteLine("O total é: " + total); //Concatenação

                Console.ReadKey();

            //incremento X decremento
                // soma++
                // soma--
                // ++soma
                // --soma



        }
    }
}