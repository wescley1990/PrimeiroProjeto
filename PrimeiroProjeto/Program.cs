// Screen Sound
string mensagemBoasVindas = "Boas vindas ao Ritmo Perfeito";

void ExibirMensagemBoasVindas()
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
        case 1: Console.WriteLine("\nVoce digitou a opção " + opcaoEscolhidaNumerica);
            break;
        case 2: Console.WriteLine("\nVoce digitou a opção " + opcaoEscolhidaNumerica);
            break;
        case 3: Console.WriteLine("\nVoce digitou a opção " + opcaoEscolhidaNumerica);
            break;
        case 4: Console.WriteLine("\nVoce digitou a opção " + opcaoEscolhidaNumerica);
            break;
        default: Console.WriteLine("Opção invalida");
            break;
    }
        
    
}


ExibirMensagemBoasVindas();
ExibirOpcoesDoMenu();