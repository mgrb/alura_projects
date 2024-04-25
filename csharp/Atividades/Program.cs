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

void PrintTitulo(string titulo)
{
    int tamanho = titulo.Length;
    string line = string.Empty.PadLeft(tamanho + 4, '+');
    Console.WriteLine($"\n{line}\n  {titulo}\n{line}\n");
}

int LerOpcao()
{
    Console.Write("Digite a opção desejada: ");
    return int.Parse(Console.ReadLine()!);
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
        case 5:
            Desafio_M03_ATV08();
            break;
        case 6:
            Desafio_M04_ATV08();
            break;
        case 7:
            Desafio_M04_ATV09();
            break;
        case 0:
            Console.WriteLine("Saindo...");
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}

void Desafio_M04_ATV09()
{
    /*
Com base na lista de super carros fornecida acima, onde a chave é o nome do carro e os valores são quantas vezes esse carro foi vendido por ano, calcule a média de uma chave específica.
    */

    Dictionary<string, List<int>> vendasCarros = new Dictionary<string, List<int>> {
        { "Bugatti Veyron", new List<int> { 10, 15, 12, 8, 5 } },
        { "Koenigsegg Agera RS", new List<int> { 2, 3, 5, 6, 7 } },
        { "Lamborghini Aventador", new List<int> { 20, 18, 22, 24, 16 } },
        { "Pagani Huayra", new List<int> { 4, 5, 6, 5, 4 } },
        { "Ferrari LaFerrari", new List<int> { 7, 6, 5, 8, 10 } }
    };

    string carro = "Lamborghini Aventador";
    
    if (vendasCarros.ContainsKey(carro))
    {
        double media = vendasCarros[carro].Average();
        Console.WriteLine($"Média de vendas por ano do {carro}: {media}");
    } else {
        Console.WriteLine("Carro não encontrado");
    }

}

void Desafio_M04_ATV08()
{
    /*
1. Criar um dicionário que represente um aluno, com uma lista de notas, e mostre a média de suas notas na tela.
    */
    Dictionary<string, List<float>> alunos = new Dictionary<string, List<float>>();
    alunos.Add("Fulano", new List<float> { 8.5f, 9.0f, 7.5f });
    alunos.Add("Ciclano", new List<float> { 6.5f, 7.0f, 8.5f });
    alunos.Add("Beltrano", new List<float> { 9.5f, 9.0f, 9.5f });

    foreach (var aluno in alunos)
    {
        if(aluno.Value.Count > 0)
        {
            Console.WriteLine($"Média de {aluno.Key}: {aluno.Value.Average()}");
        } else {
            Console.WriteLine($"Sem notas para {aluno.Key}");
        }
    }

/*
2. Criar um programa que gerencie o estoque de uma loja. Utilize um dicionário para armazenar produtos e suas quantidades em estoque e mostre, a partir do nome de um produto, sua quantidade em estoque.
*/
    Dictionary<string, int> estoque = new Dictionary<string, int>();
    estoque.Add("Camiseta", 10);
    estoque.Add("Calça", 5);
    estoque.Add("Tênis", 3);

    Console.Write("Digite o nome do produto: ");
    string produto = Console.ReadLine()!;
    if (estoque.ContainsKey(produto))
    {
        Console.WriteLine($"Quantidade em estoque de {produto}: {estoque[produto]}");
    } else {
        Console.WriteLine("Produto não encontrado");
    }
/*
3. Crie um programa que implemente um quiz simples de perguntas e respostas. Utilize um dicionário para armazenar as perguntas e as respostas corretas.
*/
    Dictionary<string, string> perguntas = new Dictionary<string, string>();
    perguntas.Add("Qual a capital do Brasil?", "Brasília");
    perguntas.Add("Quem descobriu o Brasil?", "Pedro Álvares Cabral");
    perguntas.Add("Qual é o maior planeta do sistema solar?", "Júpiter");

    int acertos = 0;
    foreach (var pergunta in perguntas)
    {
        Console.WriteLine(pergunta.Key);
        Console.Write("Resposta: ");
        string resposta = Console.ReadLine()!;
        if (pergunta.Value.ToUpper().Equals(resposta.ToUpper()))
        {
            acertos++;
        }
    }
/*
4. Criar um programa que simule um sistema de login utilizando um dicionário para armazenar nomes de usuário e senhas.
*/
    Dictionary<string, string> usuarios = new Dictionary<string, string>();
    usuarios.Add("fulano", "123456");
    usuarios.Add("ciclano", "654321");
    usuarios.Add("beltrano", "987654");

    Console.Write("Usuário: ");
    string usuario = Console.ReadLine()!;
    Console.Write("Senha: ");
    string senha = Console.ReadLine()!;
    if (usuarios.ContainsKey(usuario) && usuarios[usuario].Equals(senha))
    {
        Console.WriteLine("Login efetuado com sucesso!");
    } else {
        Console.WriteLine("Usuário ou senha inválidos");
    }
}

void Desafio_M03_ATV08()
{
    /*
Crie uma lista de inteiros utilizando o List<int> e utilize o for e o foreach para iterar sobre essa lista e exibir apenas os números pares.

No for, comece o índice em 0 e incremente a cada iteração. Defina a condição de continuação do loop como i < numeros.Count, ou seja, o loop continuará enquanto o valor de i for menor do que o número de elementos na lista. Acesse o valor de cada elemento utilizando a sintaxe numeros[i].

Já no foreach, ao invés de utilizar um loop for com um contador i e acessar os elementos da lista através do índice i, é utilizado o foreach para percorrer a lista e acessar diretamente cada elemento com a variável número. Em seguida, é verificado se o número é par utilizando o operador de módulo (%) e, caso seja, o número é impresso no console.    
    */

    PrintTitulo("Módulo 03 - Atividade 08");

    List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    Console.WriteLine("Números pares (for):");
    for (int i = 0; i < numeros.Count; i++)
    {
        if (numeros[i] % 2 == 0)
        {
            Console.WriteLine(numeros[i]);
        }
    }

    Console.WriteLine("Números pares (foreach):");
    foreach (int n in numeros)
    {
        if (n % 2 == 0)
        {
            Console.WriteLine(n);
        }
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
    "M03-AT07 :: Desafio: hora da prática",
    "M03-AT08 :: Faça como eu fiz",
    "M04-AT08 :: Desafio: hora da prática",
    "M04-AT09 :: Faça como eu fiz" };
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
// -----------------

