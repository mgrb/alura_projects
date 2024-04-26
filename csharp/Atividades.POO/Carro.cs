namespace Atividades.POO;

public class Carro
{
    private int ano;
    public string Fabricante { get; set; }
    public string Modelo { get; set; }
    public int Ano { 
        get=> ano; 
        set{
            if(value < 1960 || value > 2023){
                throw new ArgumentException("Ano inválido");
            }
            ano = value;
        } 
    }
    public string DescricaoDetalhada => $"{Fabricante} - {Modelo} - {Ano}";


}
