using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Screensound.Models;

namespace ScreenSound.Views;

internal class MenuBuscarBanda : Menu
{
    public override void Executar(List<Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        Console.WriteLine("\x1b[3J");
        ExibirTituloDaOpcao("Exibindo as bandas registradas");
        ExibirBandas(bandasRegistradas);
        Console.WriteLine("\nInsira o nome da banda que deseja visualizar ou digite 0 para voltar ao menu.");
        string op = Console.ReadLine();
        if (int.TryParse(op, out int opNum))
        {
            if (opNum == 0) return;
        }
        else
        {
            Banda bandaBuscada = bandasRegistradas.Find(b => b.Nome == op);
            if (bandaBuscada == null)
            {
                Console.WriteLine("Banda não encontrada");
                Thread.Sleep(3000);
            }
            else
            {
            MenuVisualizarBanda menu = new();
            menu.VisualizarBanda(bandaBuscada);
            }
        } 
    }
}
