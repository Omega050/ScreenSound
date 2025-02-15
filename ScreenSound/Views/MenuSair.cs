using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Screensound.Models;

namespace ScreenSound.Views;

internal class MenuSair : Menu
{
    public override void Executar(List<Banda> bandasRegistradas)
    {
        Console.WriteLine("Tchau tchau :)");
    }                   
}
