using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso
{

    public class Trabalhador
    {
        public string nome;
        protected decimal salarioBase;

        //constructor
        public Trabalhador(string nome, decimal salarioBase)
        {
            this.nome = nome;
            this.salarioBase = salarioBase;
        }
        public virtual decimal CalcularPagamento()
        {
            //metodo do tipo virtual ele pode ser reescrita
            return salarioBase;
        }
    }

    public class VendasTrabalhador : Trabalhador
    {
        //tipo decimal bastante utilizada quando se trata de "DINHEIRO"
        private decimal bonusDeVendas;

        //CONSTRUCTOR
        public VendasTrabalhador(string nome, decimal salarioBase,
            decimal bonusDeVendas) : base(nome, salarioBase)
        {
            this.bonusDeVendas = bonusDeVendas;
        }

        public override decimal CalcularPagamento()
        {
            return salarioBase + bonusDeVendas;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // atributo virtual

            //instancia da classe
            var trabalhador = new VendasTrabalhador("Anna", 1000, 500);
            var trabalhado3 = new Trabalhador("Rob", 1200);
            Console.WriteLine($"Trabalhador 1 {trabalhador.nome} ganhou: {trabalhador.CalcularPagamento()}");
            Console.WriteLine($"Trabalhador comum {trabalhado3.nome} ganhou: {trabalhado3.CalcularPagamento()}"); 
            Console.ReadKey();
        }
    }
}
