using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Screensound.Models;

namespace ScreenSound.Views
{
    internal class MenuAvaliarBanda : Menu
    {
        public void Executar(Banda banda)
        {
            Console.Clear();
            Console.WriteLine($"Qual nota deseja atribuir à banda {banda.Nome}?");
            string n = Console.ReadLine()!;
            if (int.TryParse(n, out int nota))
            {
                banda.AdicionarNota(nota);
                Console.WriteLine($"\nA banda {banda.Nome} recebeu a nota {nota}");
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
