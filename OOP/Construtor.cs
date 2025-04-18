using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso
{
    public class Aluno
    {
        //Criando o construtor
        public Aluno(String nome)
        {
            nomeAluno = nome;
        }
        public string nomeAluno { get; }
    }


    class Program
    {
        static void Main(string[] args)
        {


            // instanciando a classe e usando o construtor para gerar varios nomes
            Aluno aluno = new Aluno("jose");
            Console.WriteLine(aluno.nomeAluno);
            Aluno aluno2 = new Aluno("Mara");
            Console.WriteLine(aluno2.nomeAluno);

            Console.ReadKey();



        }
    }
}
