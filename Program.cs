string mensagemDeBoasVindas = "Bem vindo ao Music Stremear!";

//Criando dicionario, primeiro a chave e depois os valores ou lista de valores;
Dictionary<string, List<int>> bands = new Dictionary<string, List<int>>();

bands.Add("Nirvana", new List<int> { 10, 2, 8 });
bands.Add("U2", new List<int>());

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
            RegisterBand();
            break;
        case 2:
            ListBands();
            break;
        case 3:
            RateTheBand();
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

void RegisterBand()
{
    Console.Clear();
    ShowOptionTitle("Registro de Bandas:");

    Console.Write("Digite o nome da banda: ");
    string bandName = Console.ReadLine()!;
    //Assim adicionamos usando dicionario, colocamos a chave primeiro e iniciamos os valore atribuidos a essa chave vazio
    bands.Add(bandName, new List<int>());
    Console.WriteLine($"A banda {bandName} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void ListBands()
{
    Console.Clear();
    ShowOptionTitle("Bandas Registradas:");

    // for (int i = 0; i < bandList.Count(); i++)
    // {
    //     Console.WriteLine($"{i + 1}: {bandList[i]}");
    // }

    int i = 1;
    //usamos a propriedade Keys do dicionario, pq é o que queremos percorrer com o foreach
    foreach (string band in bands.Keys)
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

void RateTheBand()
{
    Console.Clear();
    ShowOptionTitle("Avalie uma banda:");
}

//Code Smell: O código funciona mas daquele jeitinho,por isso refatoramos o código pra ter essa função e evitar repetição de uma parte do código
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
