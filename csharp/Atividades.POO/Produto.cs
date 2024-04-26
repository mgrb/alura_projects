namespace Atividades.POO;

public class Produto
{
    public string Nome { get; set; }
    public double Preco { get; set; }
    public int Estoque { get; set; }
    public string Marca { get; set; }
    public string Informacao => $"{Nome} - {Marca}";

}
