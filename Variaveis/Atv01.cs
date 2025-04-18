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
            // jogo de perguntas
            // Console.WriteLine -> imprimir as perguntas na tela
            // Recolher os dados
            // Atribuir esses dados a algumas variaveis
            // mostrar uma pontuação para o usuário

            //declarando as variaveis
            int pontuacao = 0;

            //pergunta 1
            Console.WriteLine("Quanto é 5 + 5?\nEscreva sua resposta abaixo: ");
            int resposta_1 = int.Parse(Console.ReadLine());
            if (resposta_1 == 10)
            {
                pontuacao++;
            }

            //pergunta 2
            Console.WriteLine("Quanto é 10 + 5?\nEscreva sua resposta abaixo: ");
            int resposta_2 = int.Parse(Console.ReadLine());
            if (resposta_2 == 15)
            {
                pontuacao++;
            }

            //pergunta 3
            Console.WriteLine("Qual a cor do céu?\nEscreva sua resposta abaixo: ");
            string resposta_3 = Console.ReadLine();
            if (resposta_3 == "AZUL")
            {
                pontuacao++;
            }
            
            //pergunta 4
            Console.WriteLine("Qual a capital do BRASIL?\nEscreva sua resposta abaixo: ");
            string resposta_4 = Console.ReadLine();
            if (resposta_4 == "brasilia")
            {
                pontuacao++;
            }

            //pontuação total
            Console.WriteLine("sua pontuação é: " + pontuacao);

            Console.ReadKey();


        }
    }
}s