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

            // 10 estudantes
            // idade dos estudantes
            // exibir o estudante mais velho e o mais novo

            //declarando array
            String[] estudantes = new String[10];
            int[] idade = new int[10];
            String[] lista = new String[10];

            Console.WriteLine("Digite o nome de 10 estudantes e sua respectiva idade");

            for (int p = 0; p < estudantes.Length; p++)
            {
                Console.WriteLine("Nome do estudante:");
                estudantes[p] = Console.ReadLine();

                Console.WriteLine("Idade do estudante:");
                idade[p] = Convert.ToInt32(Console.ReadLine());

                if (idade[p] < 10)
                {
                    lista[p] = "0" + idade[p] + " " + estudantes[p];
                }
                else
                {
                    lista[p] = idade[p] + " " + estudantes[p];
                }
            }
            Array.Sort(lista);
            foreach (String p in lista)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine("O estudante mais velho é o: " + lista[4]);

            Console.WriteLine("O estudante mais novo é o: " + lista[0]);



            Console.ReadKey();
        }
    }
}
