// PRATICAS em video

void PrintMensagemTitulo(string mensagem)
{
    Console.WriteLine($"###\n{mensagem}\n###");
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
    
    PrintMensagemTitulo("Bem vindo!");
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
            PrintMensagemTitulo("Registrar uma banda");
            break;
        case 2:
            PrintMensagemTitulo("Mostrar todas as bandas");
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

// -----------------------------------------------------------------------------
// Inicio do programa
PrintBoasVindas();
PrintMenu();
int opcEscolhida = LerOpcao();
AvaliarOpcaoEscolhida(opcEscolhida);

