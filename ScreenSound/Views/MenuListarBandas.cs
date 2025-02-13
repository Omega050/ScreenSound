using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Screensound.Models;

namespace ScreenSound.Views;

internal class MenuListarBandas : Menu
{
    public override void Executar(List<Banda> bandasRegistradas)
    {
        Console.Clear();
        Console.WriteLine("\x1b[3J");
        ExibirTituloDaOpcao("Exibindo as bandas registradas");
        ExibirBandas(bandasRegistradas);
        Console.WriteLine("\nDigite 0 para voltar ao menu, ou 1 para visualizar detalhes de uma banda");
        string op = Console.ReadLine();
        if (int.TryParse(op, out int opNum))
        {
            if (opNum == 0) ;
            if (opNum == 1)
            {
                MenuVisualizarBanda menu3 = new();
                menu3.Executar(bandasRegistradas);
            }
        }
        else
        {
            Console.WriteLine("Opção inválida");
            Thread.Sleep(1500);
        }
    }
}
