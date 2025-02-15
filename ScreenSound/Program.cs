using Screensound.Models;
using ScreenSound.Views;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Banda> bandasRegistradas = new List<Banda>();
        Dictionary<int, Menu> opcoes = new Dictionary<int, Menu>();
        opcoes.Add(1, new MenuRegistrarBanda());
        opcoes.Add(2, new MenuBuscarBanda());
        opcoes.Add(3, new MenuAdicionarAlbum());
        opcoes.Add(-1, new MenuSair());


        void ExibirLogo()
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

        void ExibirOpcoesDoMenu()
        {
            Console.Clear();
            Console.WriteLine("\x1b[3J");
            ExibirLogo();
            Console.WriteLine("\nDigite 1 para registrar uma banda");
            Console.WriteLine("Digite 2 para mostrar todas as bandas");
            Console.WriteLine("Digite 3 para adicionar um álbum");
            Console.WriteLine("Digite 4 para exibir a média de uma banda");
            Console.WriteLine("Digite -1 para sair");
            Console.Write("\nDigite a sua opção: ");
            string opcaoEscolhida = Console.ReadLine()!;

            if (int.TryParse(opcaoEscolhida, out int opcaoEscolhidaNumerica))
            {
                if (opcoes.ContainsKey(opcaoEscolhidaNumerica))
                {
                    Menu menuExibido = opcoes[opcaoEscolhidaNumerica];
                    menuExibido.Executar(bandasRegistradas);
                    if (opcaoEscolhidaNumerica > 0) ExibirOpcoesDoMenu();
                }
                else
                {
                    Console.WriteLine("Opção inválida");
                    ExibirOpcoesDoMenu();
                }
            }
            else
            {
                Menu menu = new();
                menu.ExibirTituloDaOpcao("Opção inválida");
                Thread.Sleep(2000);
                ExibirOpcoesDoMenu();
            }
        }
        ExibirOpcoesDoMenu();
    }
}