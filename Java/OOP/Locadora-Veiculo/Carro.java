public class Carro extends Veiculo {
    int numPassageiro;

    @Override
    public void transporte() {
        System.out.println("O Carro está transportando" + numPassageiro + " passageiros.");
    }

}
