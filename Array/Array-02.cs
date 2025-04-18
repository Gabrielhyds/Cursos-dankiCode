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
            //Arrays

            //10 numeros > 0
            // vetor que armazena numeros pares
            // vetor que armazena numeros impares
            // Exibir todos os vetores em ordem crescente]


            //declarando os vetores
            int[] numeros = new int[10];
            int[] pares = new int[10];
            int[] impares = new int[10];


            //
            for (int p = 0; p < numeros.Length ; p++)
            {
                Console.WriteLine("Digite um numero maior que 0: ");
                numeros[p] = Convert.ToInt32(Console.ReadLine());
            }

            for (int p = 0; p < numeros.Length; p++)
            {
                if(numeros[p] % 2 == 0)
                {
                    pares[p] = numeros[p];
                }
                else
                {
                    impares[p] = numeros[p];
                }
            }

            //ordenar vetores
            Array.Sort(numeros);
            Array.Sort(pares);
            Array.Sort(impares);

            Console.WriteLine("Estes são os números que você digitou: ");
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }

            Console.WriteLine("\n\nEstes são os números pares: ");
            foreach (int numero in pares)
            {
                if(numero != 0) Console.WriteLine(numero);
            }

            Console.WriteLine("\n\nEstes são os números impares: ");
            foreach (int numero in impares)
            {
                if (numero != 0) Console.WriteLine(numero);
            }

            Console.ReadKey();
        }
    }
}
