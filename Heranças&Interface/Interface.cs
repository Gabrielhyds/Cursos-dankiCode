using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso
{
    interface IControle
    {
        void ApertarBotao();
        //void JogarControleNaParede();

    }
    interface ITela
    {
        void Pintar();
    }

    class ClasseBase : IControle, ITela
    {
        public void ApertarBotao()
        {

        }
        public void Pintar()
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //interface só tem as assinaturas dos metodos, atributos...

           Console.ReadKey();
        }
    }
}
