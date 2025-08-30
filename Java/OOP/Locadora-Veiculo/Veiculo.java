import java.util.Date;

public abstract class Veiculo {
    String nome;
    Date dataProducao;
    double potencia;

    public int deslocar() {
        return 0;
    }

    public abstract void transporte();
}