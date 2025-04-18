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

                //declarando o array
                string[] nomes;
                nomes = new string[5];

                //adionando elementos ao array
                nomes[0] = "jose";
                nomes[1] = "jessica";
                nomes[2] = "janaina";
                nomes[3] = "julia";
                nomes[4] = "julio";
                
                //Apresentando o array para o usuário atraves do index
                Console.WriteLine(nomes[0]);



            Console.ReadKey();
        }
    }
}
