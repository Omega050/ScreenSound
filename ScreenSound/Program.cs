using Screensound.Models;

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
            Console.WriteLine("Digite 3 para avaliar uma banda");
            Console.WriteLine("Digite 4 para exibir a média de uma banda");
            Console.WriteLine("Digite -1 para sair");
            Console.Write("\nDigite a sua opção: ");
            string opcaoEscolhida = Console.ReadLine()!;
            if (int.TryParse(opcaoEscolhida, out int opcaoEscolhidaNumerica))
            {
                switch (opcaoEscolhidaNumerica)
                {
                    case 1:
                        RegistrarBanda();
                        break;
                    case 2:
                        ListarBandas();
                        ExibirOpcoesDoMenu();
                        break;
                    case 3:
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
                //ExibirTituloDaOpcao("Opção inválida");
                Thread.Sleep(2000);
                ExibirOpcoesDoMenu();
            }
        }

        void RegistrarBanda()
        {
            Console.Clear();
            Console.WriteLine("\x1b[3J");
            //ExibirTituloDaOpcao("Registro de bandas");
            Console.Write("Nome da banda: ");
            string nomeDaBanda = Console.ReadLine()!;
            if (bandasRegistradas.Any(b => b.Nome == nomeDaBanda))
            {
                Console.WriteLine("A banda já está registrada.");
            }
            else
            {
                bandasRegistradas.Add(new Banda(nomeDaBanda));
                Console.WriteLine("Banda registrada com sucesso.");
            }
            Thread.Sleep(2000);
            ExibirOpcoesDoMenu();
        }

        void ExibirBandas()
        {
            int i = 1;
            foreach (Banda banda in bandasRegistradas)
            {
                Console.WriteLine($"Banda {i} - {banda.Nome}");
                i++;
            }
        }

        void ListarBandas()
        {
            Console.Clear();
            Console.WriteLine("\x1b[3J");
            //ExibirTituloDaOpcao("Exibindo as bandas registradas");
            ExibirBandas();
            Console.WriteLine("\nDigite 0 para voltar ao menu, ou 1 para visualizar detalhes de uma banda");
            string op = Console.ReadLine();
            if (int.TryParse(op, out int opNum))
            {
                if (opNum == 0) ExibirOpcoesDoMenu();
                if (opNum == 1) VisualizarBanda();
            }
            else
            {
                Console.WriteLine("Opção inválida");
                Thread.Sleep(1500);
            }
        }

        void VisualizarBanda()
        {
            Console.Write("\nDigite o nome da banda que deseja visualizar: ");
            string nomeBanda = Console.ReadLine()!;
            Banda bandaBuscada = bandasRegistradas.Find(b => b.Nome == nomeBanda);
            if (bandaBuscada != null)
            {
                Console.Clear();
                bandaBuscada.ExibirDetalhes();
                Console.WriteLine($"\nDigite 0 para voltar ao menu, ou 1 para avaliar a banda {bandaBuscada.Nome}.");
                string op = Console.ReadLine();
                if (int.TryParse(op, out int opNum))
                {
                    if (opNum == 0) ExibirOpcoesDoMenu();
                    if (opNum == 1)
                    {
                        //MenuAvaliarBanda menu = new();
                        //menu.Executar(bandaBuscada);
                        AvaliarBanda(bandaBuscada);
                    }
                }
                else
                {
                    Console.WriteLine("Opcao inválida");
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine($"\nA banda {nomeBanda} não foi encontrada");
                Console.WriteLine("\nPressione enter para voltar ao menu");
                Console.ReadLine();
                ExibirOpcoesDoMenu();
            }
        }

        void AvaliarBanda(Banda banda)
        {
            Console.Clear();
            Console.WriteLine($"Qual nota deseja atribuir à banda {banda.Nome}?");
            string n = Console.ReadLine()!;
            if (int.TryParse(n, out int nota))
            {
                banda.AdicionarNota(nota);
                Console.WriteLine($"\nA banda {banda.Nome} recebeu a nota {nota}");
                Thread.Sleep(1500);
            }
            else
            {
                Console.WriteLine("Valor inválido");
                Thread.Sleep(1500);
            }
        }
        ExibirOpcoesDoMenu();
    }
}