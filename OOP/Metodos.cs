using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso
{
    abstract class Motocicleta
    {
        //Criando os metodos

        //quando for publico qualquer um pode chamar o metodo
        public void LigarMoto() { }

        //somente classes derivadas conseguem chamar
        protected void AdicionarGasolina(int galoes) { }
        
        public abstract double ChegarNaVelocidadeX();

        public virtual int Drive(int quilometros, int velocidade) { }

    }

    class Program
    {
        static void Main(string[] args)
        {


        }
    }
}
