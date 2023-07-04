// Screen Sound
string mensagemBoasVindas = "Boas vindas ao Ritmo Perfeito";
//List<string> Bandas = new List<string> { "U2", "The Beatles", "Rei da Cacimbinha","Pink Floyd"};

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Link Park", new List<int> { 10,08,06});
bandasRegistradas.Add("Joao Gomes", new List<int>());
void ExibindoLogo()
{
    Console.WriteLine(@"
██████╗░██╗████████╗███╗░░░███╗░█████╗░  ██████╗░███████╗██████╗░███████╗███████╗██╗████████╗░█████╗░
██╔══██╗██║╚══██╔══╝████╗░████║██╔══██╗  ██╔══██╗██╔════╝██╔══██╗██╔════╝██╔════╝██║╚══██╔══╝██╔══██╗
██████╔╝██║░░░██║░░░██╔████╔██║██║░░██║  ██████╔╝█████╗░░██████╔╝█████╗░░█████╗░░██║░░░██║░░░██║░░██║
██╔══██╗██║░░░██║░░░██║╚██╔╝██║██║░░██║  ██╔═══╝░██╔══╝░░██╔══██╗██╔══╝░░██╔══╝░░██║░░░██║░░░██║░░██║
██║░░██║██║░░░██║░░░██║░╚═╝░██║╚█████╔╝  ██║░░░░░███████╗██║░░██║██║░░░░░███████╗██║░░░██║░░░╚█████╔╝
╚═╝░░╚═╝╚═╝░░░╚═╝░░░╚═╝░░░░░╚═╝░╚════╝░  ╚═╝░░░░░╚══════╝╚═╝░░╚═╝╚═╝░░░░░╚══════╝╚═╝░░░╚═╝░░░░╚════╝░");
    Console.WriteLine(mensagemBoasVindas);
}
void ExibirOpcoesDoMenu()
{
    ExibindoLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 exibir a média de uma banda");
    Console.WriteLine("Digite 0 para Sair ");


    Console.Write("\nDigite sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);
    
    switch(opcaoEscolhidaNumerica)
    {
        case 0: Console.WriteLine("Até logo! :( ");
            break;
        case 1:  RegistrarBandas();
            break;
        case 2: MostrarBandasRegistradas();
            break;
        case 3: AvaliarUmaBanda();
            break;
        case 4: Console.WriteLine("\nVoce digitou a opção " + opcaoEscolhidaNumerica);
            break;
        default: Console.WriteLine("Opção invalida");
            break;
    }
        
    
}
void RegistrarBandas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro de Bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    //Bandas.Add(nomeDaBanda);
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    
    ExibirOpcoesDoMenu();
}
void MostrarBandasRegistradas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Bandas registradas:");
    
    //for (int i = 0; i < Bandas.Count; i++)
    //{
    //    Console.WriteLine($"Banda: {Bandas[i]}");
    //}

    foreach(string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }

    Console.WriteLine("\nDigite uma tecla para voltar ao Menu ");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

void AvaliarUmaBanda()
{
    //digite qual banda deseja avaliar
    // saber se a banda existe >> sim >> atribuir nota >> nao >> voltar menu principal

    Console.Clear();
    ExibirTituloDaOpcao("Avaliando Bandas");
    Console.Write("Digite o nome da Banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {

    } else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada");
        Console.WriteLine("Digite uma tecla para voltar ao Menu Principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}



ExibirOpcoesDoMenu();