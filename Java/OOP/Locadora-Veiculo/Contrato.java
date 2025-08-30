import java.util.Date;

public class Contrato {
    Veiculo veiculoAlugado;
    Date dataRetirada;
    Date dataDevolucao;
    boolean devolvido = false;

    public void setDevolvido(boolean devolvido) {
        this.devolvido = devolvido;
        this.dataDevolucao = new Date();
    }
}