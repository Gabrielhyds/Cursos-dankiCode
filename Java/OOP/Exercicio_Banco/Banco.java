public class Banco{
    public static void main(String[] args){
        // ===== exemplo 1 ==========
        //Corrente c = new Corrente();
        //c.saldo = 100;
        //System.out.println(c.saldo);

        // ===== exemplo com a implementação de PESSOA =====
        Pessoa p = new Pessoa();
        p.nome = "João";
        p.cpf = 123;
        p.conta = new Corrente(); 
        p.conta.numero = 1;
        p.conta.saldo = 1500;
        p.poups = new Poupanca[2];
        p.pous = new Poupanca();
        p.poups[0].numero = 33;
        p.poups[0].saldo = 100;
        p.poups[0].titulo = "Formatura!";
        
        p.pous = new Poupanca();
        p.poups[1].numero = 44;
        p.poups[1].saldo = 100000000000000000000000000000000000;
        p.poups[1].titulo = "Carro novo";


    }
}