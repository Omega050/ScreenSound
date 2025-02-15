using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Screensound.Models;

namespace ScreenSound.Views;

internal class MenuRegistrarBanda : Menu
{
    public override void Executar(List<Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        Console.WriteLine("\x1b[3J");
        ExibirTituloDaOpcao("Registro de bandas");
        Console.Write("Nome da banda: ");
        string nomeDaBanda = Console.ReadLine()!;
        if (bandasRegistradas.Any(b => b.Nome == nomeDaBanda))
        {
            Console.WriteLine("A banda já está registrada.");
        }
        else
        {
            bandasRegistradas.Add(new Banda(nomeDaBanda));
            Console.WriteLine("Banda registrada com sucesso.");
        }
        Thread.Sleep(2000);
    }
}
