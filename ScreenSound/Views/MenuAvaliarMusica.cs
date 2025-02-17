using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Screensound.Models;

namespace ScreenSound.Views
{
    internal class MenuAvaliarMusica
    {
        public void Avaliar(Musica musica)
        {
            Console.Clear();
            Console.WriteLine($"Qual nota deseja atribuir à musica {musica.Nome}?");
            string n = Console.ReadLine()!;
            if (int.TryParse(n, out int nota))
            {
                musica.AdicionarNota(nota);
                Console.WriteLine($"\nA banda {musica.Nome} recebeu a nota {nota}");
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
