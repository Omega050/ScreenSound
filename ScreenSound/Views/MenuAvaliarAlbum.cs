using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Screensound.Models;

namespace ScreenSound.Views
{
    internal class MenuAvaliarAlbum
    {
        public void Avaliar(Album album)
        {
            Console.Clear();
            Console.WriteLine($"Qual nota deseja atribuir à banda {album.Nome}?");
            string n = Console.ReadLine()!;
            if (int.TryParse(n, out int nota))
            {
                album.AdicionarNota(nota);
                Console.WriteLine($"\nA banda {album.Nome} recebeu a nota {nota}");
                Thread.Sleep(1500);
            }
            else
            {
                Console.WriteLine("Valor inválido");
                Thread.Sleep(1500);
            }
        }
    }
}
