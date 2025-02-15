using Screensound.Models;

namespace ScreenSound.Views;

internal class MenuVisualizarBanda : Menu
{
    public void VisualizarBanda(Banda bandaBuscada)
    {

        Console.Clear();
        bandaBuscada.ExibirDetalhes();
        Console.WriteLine(@$"Opções:
0 - Voltar ao menu.
1 - Avaliar a banda {bandaBuscada.Nome}.
2 - Ver discografia da banda {bandaBuscada.Nome}.");

        string op = Console.ReadLine();
        if (int.TryParse(op, out int opNum))
        {
            if (opNum == 1)
            {
                MenuAvaliarBanda menu = new();
                menu.Avaliar(bandaBuscada);
            }
            if (opNum == 2)
            {
                bandaBuscada.ExibirDiscografia();
                Console.WriteLine("\nPressione enter para voltar ao menu");
                Console.ReadLine();
            }
        }
        else
        {
            Console.WriteLine("Opcao inválida");
        }

    }
}
