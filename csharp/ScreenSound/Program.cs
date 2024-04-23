// PRATICAS em video
List<string> bandas = new List<string>();

void PrintMensagemTitulo(string mensagem)
{
    Console.WriteLine(@$"
+++++++++++++++++++++++++++++++++
{mensagem}
---------------------------------

");
}

void PrintBoasVindas()
{
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░    
    ");
}

void PrintMenu()
{
    Console.WriteLine(@"
    1 - Registrar uma banda
    2 - Mostrar todas as bandas
    3 - Avaliar uma banda
    4 - Mostrar média de avaliações de uma banda
    0 - Sair

    ");
}

int LerOpcao()
{
    Console.Write("Digite a opção desejada:");
    return int.Parse(Console.ReadLine()!);
}

void AvaliarOpcaoEscolhida(int opc)
{
    switch (opc)
    {
        case 1:
            RegistrarBanda();
            break;
        case 2:
            MostrarTodasAsBandas();
            break;
        case 3:
            PrintMensagemTitulo("Avaliar uma banda");
            break;
        case 4:
            PrintMensagemTitulo("Mostrar média de avaliações de uma banda");
            break;
        case 0:
            PrintMensagemTitulo("Saindo...");
            break;
        default:
            PrintMensagemTitulo("Opção inválida");
            break;
    }

}

void RegistrarBanda()
{
    Console.Clear();
    PrintBoasVindas();
    PrintMensagemTitulo("Registrar uma banda");
    Console.Write("Digite o nome da banda: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandas.Add(nomeDaBanda);
    Console.Write($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);

}

void MostrarTodasAsBandas()
{
    Console.Clear();
    PrintBoasVindas();
    PrintMensagemTitulo("Mostrar todas as bandas");
    if (bandas.Count == 0)
    {
        Console.WriteLine("Nenhuma banda foi registrada ainda.");
    }
    else
    {
        foreach (var banda in bandas)
        {
            Console.WriteLine(banda);
        }
    }
    Console.WriteLine("\nPressione qualquer tecla para continuar...");
    Console.ReadKey();
}

void Main(){
while (true)
{
    Console.Clear();
    PrintBoasVindas();
    PrintMensagemTitulo("Bem vindo!");
    PrintMenu();
    int opcEscolhida = LerOpcao();
    AvaliarOpcaoEscolhida(opcEscolhida);
    if (opcEscolhida == 0)
    {
        break;
    }
}

}
// -----------------------------------------------------------------------------
// Inicio do programa
Main();

