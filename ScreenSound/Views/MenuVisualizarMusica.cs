using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Screensound.Models;

namespace ScreenSound.Views
{
    internal class MenuVisualizarMusica : Menu
    {
        public void Executar(Musica musica)
        {
            Console.Clear();
            ExibirTituloDaOpcao("Exição detalhada da música");
            musica.ExibirFichaTecnica();

            Console.WriteLine();
            Console.WriteLine(@$"Opções:
0 - Voltar ao menu.
1 - Avaliar a música {musica.Nome}.");

            string op = Console.ReadLine();

            if (int.TryParse(op, out int opNum))
            {
                if (opNum == 0) return;
                if (opNum == 1)
                {
                    MenuAvaliarMusica menu = new();
                    menu.Avaliar(musica);
                }
            }
            else
            {
                Console.WriteLine("Opcao inválida");
            }
        }
    }
}
