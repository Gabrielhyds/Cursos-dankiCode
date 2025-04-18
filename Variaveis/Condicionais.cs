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
            int numero = 8; // o sinal de " = " é atribuição

            //Estrutura condicional { if(){} , else{} elif(){} }
            if (numero == 8)// se isso for verdade 
            { 
                // apresenta a msg ao usuário
                Console.WriteLine("é verdade");
            }
            else{
               // senão apresenta essa mensagem ao usuário
               Console.WriteLine("É mentira");    
            }

            Console.ReadKey();


        }
    }
}