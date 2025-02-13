using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Screensound.Models;

namespace ScreenSound.Views;

internal class MenuVisualizarBanda : Menu
{
    public override void Executar(List<Banda> bandasRegistradas)
    {
        Console.Write("\nDigite o nome da banda que deseja visualizar: ");
        string nomeBanda = Console.ReadLine()!;
        Banda bandaBuscada = bandasRegistradas.Find(b => b.Nome == nomeBanda);
        if (bandaBuscada != null)
        {
            Console.Clear();
            bandaBuscada.ExibirDetalhes();
            Console.WriteLine($"\nPressione enter para voltar ao menu, ou 1 para avaliar a banda {bandaBuscada.Nome}.");
            string op = Console.ReadLine();
            if (int.TryParse(op, out int opNum))
            {
                if (opNum == 1)
                {
                    MenuAvaliarBanda menu = new();
                    menu.Executar(bandaBuscada);
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

        }
    }
}
