using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Screensound.Models;

namespace ScreenSound.Views
{
    internal class MenuVisualizarAlbum : Menu
    {
        public void VisualizarAlbum(Album albumBuscado)
        {
            Console.Clear();
            Console.WriteLine(@$"Opções:
0 - Voltar ao menu.
1 - Avaliar o albúm {albumBuscado.Nome}.
2 - Ver músicas do albúm {albumBuscado.Nome}.");

            string op = Console.ReadLine();
            if (int.TryParse(op, out int opNum))
            {
                if (opNum == 0) return;
                if (opNum == 1)
                {
                    MenuAvaliarAlbum menu = new();
                    menu.Avaliar(albumBuscado);
                }
                if (opNum == 2)
                {
                    albumBuscado.ExibirMusicas();
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

}
    

