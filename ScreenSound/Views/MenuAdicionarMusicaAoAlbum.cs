using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Screensound.Models;

namespace ScreenSound.Views
{
    internal class MenuAdicionarMusicaAoAlbum : Menu
    {
        public void AdicionarMusicaAoAlbum(Musica musica, Banda banda)
        {
            Console.Clear();
            banda.ExibirDiscografia();
            Console.Write($"\nInsira o álbum ao qual deseja adicionar a música {musica.Nome}: ");
            string albumEscolhido = Console.ReadLine();
            Album albumBuscado = banda.Albums.Find(a => a.Nome == albumEscolhido);
            if (albumBuscado != null)
            {
                albumBuscado.AdicionarMusica(musica);
                musica.DefinirAlbum(albumBuscado);
                Console.WriteLine($"A música {musica.Nome} foi cadastrado ao album {albumBuscado.Nome}");
                Thread.Sleep(2000);
            }
            else 
            {
                Console.WriteLine("Banda não encontrada");
                Thread.Sleep(2000);
            }
        }
    }
}
