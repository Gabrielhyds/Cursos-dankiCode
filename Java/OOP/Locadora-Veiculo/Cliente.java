import java.util.ArrayList;
import java.util.List;

public class Cliente extends Pessoa {
    List<Contrato> alugueis = new ArrayList<>();

    public boolean alugar(Veiculo v) {
        Contrato contrato = new Contrato();
        contrato.veiculoAlugado = v;
        contrato.dataRetirada = new java.util.Date();
        alugueis.add(contrato);
        return true;
    }

    public void devolverVeiculo(Contrato contrato) {
        contrato.setDevolvido(true);
        System.out.println("Veículo devolvido e contrato atualizado.");
    }
}