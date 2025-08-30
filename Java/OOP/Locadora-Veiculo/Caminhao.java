public class Caminhao extends Veiculo {
    int capacidade;

    @Override
    public void transporte() {
        System.out.println("Caminhão transportando carga.");
    }

    public void transporte(int capacidade) {
        System.out.println("Caminhão transportando carga de " + capacidade + " kg.");
    }
}