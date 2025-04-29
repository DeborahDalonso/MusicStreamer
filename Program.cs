
//PascalCase para funções
void ExibirMensagemDeBoasVindas()
{
    string mensagemDeBoasVindas = "Bem vindo ao Music Stremear!";
    // O @ aqui é o Verbatim Literal -> basicamente exibir a string no código da forma como você quer que ela apareça no terminal
    Console.WriteLine(@"   
█▀▄▀█ █░█ █▀ █ █▀▀   █▀ ▀█▀ █▀█ █▀▀ █▀▄▀█ █▀▀ ▄▀█ █▀█
█░▀░█ █▄█ ▄█ █ █▄▄   ▄█ ░█░ █▀▄ ██▄ █░▀░█ ██▄ █▀█ █▀▄
    ");
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesDoMenu()
{
    Console.WriteLine("\n1: Registrar uma banda");
    Console.WriteLine("2: Mostrar todas as banda");
    Console.WriteLine("3: Avaliar uma banda");
    Console.WriteLine("4: Exibir a media de uma banda");
    Console.WriteLine("-1: Sair");
    Console.Write("\nDigite uma opções: ");

    //O console ReadLine permite entrada nula, como nós não queremos esse comportamento, usamos ! 
    string opcao = Console.ReadLine()!;
    int opcaoNumerica = int.Parse(opcao);
    switch (opcaoNumerica)
    {
        case 1:
            //$ aqui é sinal de interpolação (mesclagem de texto)
            Console.WriteLine($"Você escolheu {opcao}");
            break;
        case 2:
            Console.WriteLine("Você escolheu " + opcao);
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

ExibirMensagemDeBoasVindas();
ExibirOpcoesDoMenu();
