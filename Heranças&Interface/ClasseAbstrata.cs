using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso
{
    abstract class Forma
    {
        //metodo abstrato
        public abstract int CalcularArea();

    }
    class Quadrado : Forma
    {
        //atributo
        int lado;
        
        //Metodo
        public Quadrado(int n) => lado = n;

        // o override ele fornece uma nova implementação
        public override int CalcularArea() => lado * lado;

    }

    class Program
    {
        static void Main(string[] args)
        {
            //Classe Abstrata
            // não pode ser instanciada
            // Pode ser herdada

            var qd = new Quadrado(12);
            // o $ é tipo uma formatação
            Console.WriteLine($"area do quadrado = {qd.CalcularArea()}");

            Console.ReadKey();
        }
    }
}
