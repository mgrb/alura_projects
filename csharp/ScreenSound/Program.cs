// PRATICAS em video
Dictionary<string, List<int>> bandas = new Dictionary<string, List<int>>();

void PrintMensagemTitulo(string mensagem)
{
    string line = string.Empty.PadLeft(mensagem.Length + 4, '+');
    Console.WriteLine($"\n{line}\n  {mensagem}\n{line}\n");
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
    0 - Sair");
}

int LerOpcao()
{
    Console.Write("\nDigite a opção desejada:");
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
            AvaliarBanda();
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
    bandas.Add(nomeDaBanda, new List<int>());
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
        foreach (var banda in bandas.Keys)
        {
            Console.WriteLine(banda);
        }
    }
    Console.WriteLine("\nPressione qualquer tecla para continuar...");
    Console.ReadKey();
}

void AvaliarBanda()
{
    Console.Clear();
    PrintBoasVindas();
    PrintMensagemTitulo("Avaliar uma banda");

    Console.WriteLine("Informe o nome da banda a ser avaliada:");
    string nomeBanda = Console.ReadLine()!;
    if (!bandas.ContainsKey(nomeBanda))
    {
        Console.WriteLine("Banda não encontrada.");
        Thread.Sleep(2000);
        return;
    }
    Console.WriteLine("Informe a avaliação da banda [0 - 10]:");
    int nota = int.Parse(Console.ReadLine()!);

    if (nota < 0 || nota > 10)
    {
        Console.WriteLine("Nota inválida.");
        Thread.Sleep(2000);
        return;
    }

    bandas[nomeBanda].Add(nota);
    Console.WriteLine("Avaliação registrada com sucesso.");
    Thread.Sleep(2000);
}

void Main(){
    Init();
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

void Init() {
    bandas.Add("Led Zeppelin", new List<int> { 10, 9, 8 });
    bandas.Add("Pink Floyd", new List<int> { 2, 3, 8 });
    bandas.Add("Queen", new List<int> { 4, 5, 3 });
    bandas.Add("The Beatles", new List<int> { 7, 9, 1 });
    bandas.Add("The Rolling Stones", new List<int> ());
}

// Inicio do programa
Main();
// -----------------------------------------------------------------------------

