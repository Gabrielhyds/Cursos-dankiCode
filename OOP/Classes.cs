using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso
{
    public class Aluno
    {
    //Criado a classe Aluno 
        // definindo os atributos da classe
        public string nome = "Gabriel";
        public int nota_Anual  = 10;
        public int cpf = 222222;
    }


    class Program
    {
        static void Main(string[] args)
        {

            // instância da classe
            Aluno aluno = new Aluno();
            Aluno aluno2 = new Aluno();
            
            // Apresentando os atributos da classe
            Console.WriteLine(aluno.cpf);
            Console.WriteLine(aluno2.nome);

            Console.ReadKey();
        }
    }
}
