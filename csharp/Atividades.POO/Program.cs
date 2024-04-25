using Atividades.POO;

Console.WriteLine("Módulo 01 - Atividade 07 - Desafio: hora da prática");
Console.WriteLine(@"
1. Criar uma classe que representa uma conta bancária, com um número indicador, titular, saldo e senha.

2. Criar um objeto do tipo Conta, adicionar dados e mostrar as informações titular e saldo no console, utilizando interpolação de strings.

3. Desenvolver um método da classe Conta que exibe suas informações.
");

ContaBancaria conta = new()
{
    Numero = 1234,
    Titular = "João da Silva",
    Saldo = 1000.00,
    Senha = "1234"
};

Console.WriteLine(conta);
Console.WriteLine(conta.ExibirInformacoes());