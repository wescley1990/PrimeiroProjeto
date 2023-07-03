// Screen Sound
string mensagemBoasVindas = "Boas vindas ao Ritmo Perfeito";
List<string> Bandas = new List<string> { "U2", "The Beatles", "Rei da Cacimbinha","Pink Floyd"};

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
        case 3: Console.WriteLine("\nVoce digitou a opção " + opcaoEscolhidaNumerica);
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
    Console.WriteLine("Registro de Bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    Bandas.Add(nomeDaBanda);
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    
    ExibirOpcoesDoMenu();
}
void MostrarBandasRegistradas()
{
    Console.Clear();
    Console.WriteLine("Bandas registradas:\n");
    for (int i = 0; i < Bandas.Count; i++)
    {
        Console.WriteLine($"Banda: {Bandas[i]}");
    }
    Console.WriteLine("\nDigite uma tecla para voltar ao Menu ");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

ExibindoLogo();
ExibirOpcoesDoMenu();