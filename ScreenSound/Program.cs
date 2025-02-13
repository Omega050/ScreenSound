using Screensound.Models;
using ScreenSound.Views;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Banda> bandasRegistradas = new List<Banda>();

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
                switch (opcaoEscolhidaNumerica)
                {
                    case 1:
                        Menu menu1 = new MenuRegistrarBanda();
                        menu1.Executar(bandasRegistradas);
                        ExibirOpcoesDoMenu();
                        break;
                    case 2:
                        Menu menu2 = new MenuListarBandas();
                        menu2.Executar(bandasRegistradas);
                        ExibirOpcoesDoMenu();
                        break;
                    case 3:
                        Menu menu3 = new MenuAdicionarAlbum();
                        menu3.Executar(bandasRegistradas);
                        ExibirOpcoesDoMenu();
                        ;
                        break;
                    case 4:
                        ;
                        break;
                    case -1:
                        Console.WriteLine("Tchau tchau :)");
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        ExibirOpcoesDoMenu();
                        break;
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