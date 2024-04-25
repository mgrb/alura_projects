using System.Text;

namespace Atividades.POO;

/*
1. Criar uma classe que representa uma conta bancária, com um número indicador, titular, saldo e senha.

2. Criar um objeto do tipo Conta, adicionar dados e mostrar as informações titular e saldo no console, utilizando interpolação de strings.

3. Desenvolver um método da classe Conta que exibe suas informações.
*/
public class ContaBancaria
{
    public required int Numero { get; set; }
    public required string Titular { get; set; }
    public double Saldo { get; set; }
    public string? Senha { get; set; }

    public override string ToString()
    {
        return $"Titular: {Titular}\nSaldo: {Saldo}";
    }

    public string ExibirInformacoes()
    {
        StringBuilder sb = new();
        sb.AppendLine($"Titular: {Titular}");
        sb.AppendLine($"Saldo: {Saldo}");
        sb.AppendLine($"Número: {Numero}");
        sb.AppendLine($"Senha: { string.Empty.PadLeft(Senha.Length,'*')}");
        return sb.ToString();
    }
}
