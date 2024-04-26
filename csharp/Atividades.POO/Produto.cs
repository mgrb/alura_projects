namespace Atividades.POO;

public class Produto
{   
    private double preco;
    private int estoque;
    public string Nome { get; set; }
    public double Preco { 
        get => preco; 
        set{
            if(value < 0){
                preco = 0;
            }else{
                preco = value;
            }
        } 
    }
    public int Estoque { 
        get => estoque; 
        set{
            if(value < 0){
                estoque = 0;
            }else{
                estoque = value;
            }
        }
    }
    public string Marca { get; set; }
    public string Informacao => $"{Nome} - {Marca}";

}
