using Screensound.Models;
using ScreenSound.Models;
using ScreenSound.Views;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Banda> bandasRegistradas = new List<Banda>();
        List<Musica> musicasRegistradas = new List<Musica>();
    Dictionary<int, Menu> opcoes = new Dictionary<int, Menu>();

        Banda ira = new Banda("Ira!");
        ira.AdicionarNota(10);
        ira.AdicionarNota(8);
        ira.AdicionarNota(6);
        Banda beatles = new("The Beatles");
        Banda linkin = new("Linkin Park");
        linkin.AdicionarAlbum(new Album("Hybrid", linkin));
        linkin.AdicionarAlbum(new Album("From Zero", linkin));

        opcoes.Add(1, new MenuRegistrarBanda());
        opcoes.Add(2, new MenuBuscarBanda());
        opcoes.Add(3, new MenuAdicionarAlbum());
        opcoes.Add(4, new MenuBuscarAlbum());
        //opcoes.add(5, new menuadicionaralbum());
        //opcoes.add(6, new menuadicionaralbum());
        opcoes.Add(-1, new MenuSair());

        bandasRegistradas.Add(ira);
        bandasRegistradas.Add(linkin);
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
            Console.WriteLine("Digite 4 para buscar um álbum");
            Console.WriteLine("Digite 5 para adicionar uma música");
            Console.WriteLine("Digite 6 para buscar uma música");
            Console.WriteLine("Digite -1 para sair");
            Console.Write("\nDigite a sua opção: ");

            string opcaoEscolhida = Console.ReadLine()!;
            if (int.TryParse(opcaoEscolhida, out int opcaoEscolhidaNumerica))
            {
                switch (opcaoEscolhidaNumerica)
                {
                    case 1:
                        new MenuRegistrarBanda().Executar(bandasRegistradas);
                        break;
                    case 2:
                        new MenuBuscarBanda().Executar(bandasRegistradas);
                        break;
                    case 3:
                        new MenuAdicionarAlbum().Executar(bandasRegistradas);
                        break;
                    case 4:
                        new MenuBuscarAlbum().Executar(bandasRegistradas);
                        break;
                    case 5:
                        new MenuAdicionarMusica().AdicionarMusica(bandasRegistradas, musicasRegistradas);
                        break;
                    case 6:
                        new MenuBuscarMusica().Executar(musicasRegistradas);
                        break;
                    case -1:
                        new MenuSair().Executar(bandasRegistradas);
                        return;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            }
            else
            {
                Menu menu = new();
                menu.ExibirTituloDaOpcao("Opção inválida");
                Thread.Sleep(2000);
            }

            ExibirOpcoesDoMenu();
        }

        ExibirOpcoesDoMenu();
    }
}