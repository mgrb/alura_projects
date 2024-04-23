using System.Reflection.Emit;

void PrintSplashScreen()
{
    Console.WriteLine(@"
█▀▄ █▀▀ █▀ ▄▀█ █▀▀ █ █▀█ █▀ ▀   █░█ █▀█ █▀█ ▄▀█   █▀▄ ▄▀█   █▀█ █▀█ ▄▀█ ▀█▀ █ █▀▀ ▄▀█
█▄▀ ██▄ ▄█ █▀█ █▀░ █ █▄█ ▄█ ▄   █▀█ █▄█ █▀▄ █▀█   █▄▀ █▀█   █▀▀ █▀▄ █▀█ ░█░ █ █▄▄ █▀█
    ");
}

void PrintListaDesafios(List<string> desafios)
{
    Console.WriteLine("Desafios disponíveis:");
    for (int i = 0; i < desafios.Count; i++)
    {
        Console.WriteLine($"{i + 1} - {desafios[i]}");
    }
    Console.WriteLine("0 - Sair");
}

int LerOpcao()
{
    Console.Write("Digite a opção desejada: ");
    return int.Parse(Console.ReadLine()!);
}

void PrintTitulo(string titulo)
{
    Console.WriteLine($"\n###\n{titulo}\n###");
}

void ChamarDesafio(int opc)
{
    switch (opc)
    {
        case 1:
            Atividade_M01_ATV06();
            break;
        case 2:
            Atividade_M02_ATV08();
            break;
        case 3:
            Desafio_M02_ATV09();
            break;
        case 4:
            Desafio_M03_ATV07();
            break;
        case 0:
            Console.WriteLine("Saindo...");
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}

void Desafio_M03_ATV07()
{
    /*
1. Escrever uma função que a partir de dois números de ponto flutuante a e b exiba no console o resultado de suas quatro operações básicas (adição, subtração, divisão e multiplicação), utilizando interpolação de strings.

2. Criar uma lista de bandas vazia e adicionar suas bandas prediletas em seguida.

3. Utilizar a estrutura 'for' para mostrar todas as suas bandas preferidas, listadas na lista do exercício anterior, no console.

4. Criar um programa que calcula a soma de todos os elementos inteiros em uma lista.    
    */

    PrintTitulo("Módulo 03 - Atividade 07");
    // 01.
    float a = 10.5f;
    float b = 5.5f;
    ExibirOperacoes(a, b);

    // 02.
    List<string> bandas = new List<string>();
    bandas.Add("Led Zeppelin");
    bandas.Add("Pink Floyd");
    bandas.Add("The Beatles");

    // 03.
    for (int i = 0; i < bandas.Count; i++)
    {
        Console.WriteLine(bandas[i]);
    }

    // 04.
    List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };
    int soma = 0;
    foreach (int n in numeros)
    {
        soma += n;
    }
    Console.WriteLine($"Soma dos elementos da lista: {soma}");

}

void ExibirOperacoes(float a, float b)
{
    Console.WriteLine($"Adição: {a + b}");
    Console.WriteLine($"Subtração: {a - b}");
    Console.WriteLine($"Multiplicação: {a * b}");
    Console.WriteLine($"Divisão: {a / b}");
}

void Desafio_M02_ATV09()
{
    /*
Neste jogo, o programa gera um número aleatório entre 1 e 100 e o usuário deve adivinhar qual é esse número. O programa utiliza o if-else e switch case para verificar se o número digitado pelo usuário é maior ou menor do que o número gerado pelo programa.

O programa também utiliza o conceito de laço de repetição do-while para permitir que o usuário faça várias tentativas até acertar o número. Quando o usuário acertar o número, o jogo acaba e o programa exibe uma mensagem indicando que o jogo acabou.
    */

    PrintTitulo("Faça como eu fiz: primeiro jogo com C#");
    Random random = new Random();
    int numeroAleatorio = random.Next(1, 101);
    int tentativas = 10;
    int numeroUsuario = 0;
    Console.WriteLine(@"
    Bem-vindo ao jogo de adivinhação!
    Tente adivinhar o número gerado pelo programa.
    Você terá 10 tentativas para acertar o número.
    ");

    do
    {   
        if (tentativas == 0)
        {
            Console.WriteLine("Você perdeu! Suas tentativas acabaram.");
            Console.WriteLine($"O número correto era {numeroAleatorio}");
            return;
        }
        Console.WriteLine($"Você tem {tentativas} tentativas restantes.");
        Console.Write("Digite um número entre 1 e 100: ");
        numeroUsuario = int.Parse(Console.ReadLine()!);
        tentativas--;
        if (numeroUsuario < numeroAleatorio)
        {
            Console.WriteLine("O número é maior");
        } else if (numeroUsuario > numeroAleatorio)
        {
            Console.WriteLine("O número é menor");
        }
    } while (numeroUsuario != numeroAleatorio);

    if (numeroUsuario == numeroAleatorio)
    {
        Console.WriteLine("Parabéns! Você acertou o número!");
    }
}

void Atividade_M02_ATV08()
{
    /*
1. Criar uma variável chamada notaMedia e atribua um valor inteiro a ela. Caso seu valor seja maior ou igual a 5, escreva na tela "Nota suficiente para aprovação".
2. Criar uma lista de linguagens de programação, com as linguagens C#, Java e JavaScript.
3. Exibir o valor "C#" no console, utilizando a lista criada no exercício anterior.
4. Criar um programa que, dado a entrada de dados de um número n inteiro, a partir do teclado, exibir a n-ésima posição de uma lista.    
    */

    PrintTitulo("Módulo 02 - Atividade 08");
    int notaMedia = 6;
    if (notaMedia >= 5)
    {
        Console.WriteLine("Nota suficiente para aprovação");
    } else {
        Console.WriteLine("Nota insuficiente para aprovação");
    }

    List<string> linguagens = new List<string> { "C#", "Java", "JavaScript" };
    Console.WriteLine(linguagens[0]);
    linguagens.ForEach(l => Console.WriteLine(l));
    Console.Write("Digite um posição da lista exibida: ");
    int opc = int.Parse(Console.ReadLine()!);
    if (opc >= linguagens.Count || opc < 0)
    {
        Console.WriteLine("Posição inválida");
        return;
    } else {
        Console.WriteLine(linguagens[opc]);
    }

}

void Atividade_M01_ATV06()
{
    /*
1. Criar uma variável chamada curso, e guarde nela o nome do curso estudado.
2. Mostrar o conteúdo da variável curso no console.
3. Criar uma variável chamada nome e outra chamada sobrenome e guardar nelas seu nome e sobrenome.
4. Mostrar na tela o nome dos instrutores do curso.    
    */
    PrintTitulo("Módulo 01 - Atividade 06");
    string curso = "C# Fundamentos";
    Console.WriteLine($"Curso: {curso}");
    string nome = "Fuloano";
    string sobrenome = "da Silva";
    Console.WriteLine($"Nome: {nome} {sobrenome}");
    Console.WriteLine("Instrutores: Guilherme Lima e Daniel Portugal");
}

// Main program
// -----------------
List<string> desafios = new List<string> { 
    "M01-AT06 :: Desafio: hora da prática", 
    "M02-AT08 :: Desafio: hora da prática",
    "M02-AT09 :: Faça como eu fiz: primeiro jogo com C#" ,
    "M03-AT07 :: Desafio: hora da prática" };
// -----------------

while (true)
{
    Console.Clear();
    PrintSplashScreen();
    PrintListaDesafios(desafios);
    int opc = LerOpcao();
    ChamarDesafio(opc);
    if (opc == 0)
    {
        break;
    } else {
        Console.WriteLine("Pressione qualquer tecla para continuar...");
        Console.ReadKey();
    }
}