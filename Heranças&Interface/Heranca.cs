using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso
{
    public class Mae
    {
        //atributo privado
        private int valor = 10;

        public class Filho : Mae
        {
            // O filho está herdando todos os valores q Mãe tem
            public int PegarValor()
            {
                return this.valor;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Herança 
            //pai
            //mae
            //você herda as caracteristicas etc dos seus pais

            //instancindo a classe
            var jose = new Mae.Filho();
            Console.WriteLine(jose.PegarValor());
            Console.ReadKey();
        }
    }
}
