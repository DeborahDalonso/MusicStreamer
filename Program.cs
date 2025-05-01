string mensagemDeBoasVindas = "Bem vindo ao Music Stremear!";
List<string> bandList = new List<string> { "Green Day", "U2", "Nirvana" };

//PascalCase para funções
void ExibirLogo()
{
    // O @ aqui é o Verbatim Literal -> basicamente exibir a string no código da forma como você quer que ela apareça no terminal
    Console.WriteLine(@"   
█▀▄▀█ █░█ █▀ █ █▀▀   █▀ ▀█▀ █▀█ █▀▀ █▀▄▀█ █▀▀ ▄▀█ █▀█
█░▀░█ █▄█ ▄█ █ █▄▄   ▄█ ░█░ █▀▄ ██▄ █░▀░█ ██▄ █▀█ █▀▄
    ");
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\n1: Registrar uma banda");
    Console.WriteLine("2: Mostrar todas as banda");
    Console.WriteLine("3: Avaliar uma banda");
    Console.WriteLine("4: Exibir a media de uma banda");
    Console.WriteLine("-1: Sair");
    Console.Write("\nDigite uma opções: ");

    //O console ReadLine permite entrada nula, como nós não queremos esse comportamento, usamos !, Operador de negação de nulidade 
    string opcao = Console.ReadLine()!;
    int opcaoNumerica = int.Parse(opcao);
    switch (opcaoNumerica)
    {
        case 1:
            RegistrarBanda();
            break;
        case 2:
            ListarBandas();
            break;
        case 3:
            Console.WriteLine("Você escolheu " + opcao);
            break;
        case 4:
            Console.WriteLine("Você escolheu " + opcao);
            break;
        case -1:
            Console.WriteLine("Você escolheu " + opcao);
            break;
        default:
            Console.WriteLine("Opcao invalida");
            break;
    }
}

void RegistrarBanda()
{
    Console.Clear();
    ShowOptionTitle("Registro de Bandas:");

    Console.Write("Digite o nome da banda: ");
    string bandName = Console.ReadLine()!;
    bandList.Add(bandName);
    Console.WriteLine($"A banda {bandName} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void ListarBandas()
{
    Console.Clear();
    ShowOptionTitle("Bandas Registradas:");

    // for (int i = 0; i < bandList.Count(); i++)
    // {
    //     Console.WriteLine($"{i + 1}: {bandList[i]}");
    // }

    int i = 1;
    foreach (string band in bandList)
    {
        i++;
        Console.WriteLine($"{i}: {band}");
    }

    Console.WriteLine("\n************************");

    Console.WriteLine("\nDigite uma tecla para voltar ao meu principal:");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void ShowOptionTitle(string title)
{
    int totalCharacters = title.Length;
    //string possui funções proprias e propriedades, muito interessante que fique diretamente na tipagem.
    //usamos ' para caracteres e " para strings
    //quando usamos o string.Empty dizemos que ela começa vazia, com PadLeft vamos criar uma string com n caracteres x. "Adiciona zeros a esquerda". 
    string asteriscos = string.Empty.PadLeft(totalCharacters, '*');

    Console.WriteLine(asteriscos);
    Console.WriteLine(title);
    Console.WriteLine(asteriscos + "\n");

}

ExibirOpcoesDoMenu();
