using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Screensound.Models;

namespace ScreenSound.Views
{
    internal class MenuBuscarMusica : Menu
    {
        public List<Musica> musicasRegistradas = new List<Musica>();
        public void Executar(List<Musica> MusicasRegistradas)
        {
            Console.Clear();
            ExibirTituloDaOpcao("Albuns Registrados");
            int i = 1;
            Console.WriteLine("\nInsira o nome do album que deseja visualizar ou digite 0 para voltar ao menu.");
            string op = Console.ReadLine();

            if (int.TryParse(op, out int opNum))
            {
                if (opNum == 0) return;
            }
            else
            {
                Musica musicaBuscada = musicasRegistradas.Find(b => b.Nome == op);
                if (musicaBuscada == null)
                {
                    Console.WriteLine("Album não encontrad0");
                    Thread.Sleep(3000);
                }
                else
                {
                    MenuVisualizarAlbum menu = new();
                    //menu.VisualizarMusica(musicaBuscada);
                }


            }
        }
    }
}