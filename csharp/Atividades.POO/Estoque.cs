using System.Text;

namespace Atividades.POO;

public class Estoque
{
    public List<Produto> Produtos { get; set; } = [];

    public void AdicionarProduto(Produto produto)
    {
        Produtos.Add(produto);
    }

    public String ExibirProdutos()
    {
        StringBuilder sb = new();
        foreach (var produto in Produtos)
        {
            sb.Append($"Nome: {produto.Nome} |");
            sb.Append($"Preço: {produto.Preco} |");
            sb.Append($"Quantidade: {produto.Estoque} |");
            sb.AppendLine();
        }
        return sb.ToString();
    }
}
