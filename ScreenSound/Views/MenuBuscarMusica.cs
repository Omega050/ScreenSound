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
            int i = 0;
            ExibirTituloDaOpcao("Musicas Registradas");
            foreach (Musica musica in MusicasRegistradas)
            {
                i++;
                if(musica.Album!=null) Console.WriteLine($"Música {i}: {musica.Nome} - {musica.Artista.Nome}, {musica.Album.Nome} ({musica.NotaMedia}");
                else Console.WriteLine($"Música {i}: {musica.Nome} - {musica.Artista.Nome}, sem album, ({musica.NotaMedia}");
                Console.WriteLine();
            }
            Console.WriteLine("\nInsira o nome da música que deseja visualizar ou digite 0 para voltar ao menu.");
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
                    Console.WriteLine("Música não encontrada");
                    Thread.Sleep(3000);
                }
                else
                {
                    MenuVisualizarAlbum menu = new();
                    musicaBuscada.ExibirFichaTecnica();
                }

            }
        }
    }
}