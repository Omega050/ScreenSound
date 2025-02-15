using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Screensound.Models;

namespace ScreenSound.Views;

internal class Menu
{
    public void ExibirTituloDaOpcao(string titulo)
    {
        int quantidadeDeLetras = titulo.Length;
        string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
        Console.WriteLine(asteriscos);
        Console.WriteLine(titulo);
        Console.WriteLine(asteriscos + "\n");
    }

    public void ExibirBandas(List<Banda> bandasRegistradas)
    {
        int i = 1;
        foreach (Banda banda in bandasRegistradas)
        {
            Console.WriteLine($"Banda {i} - {banda.Nome}");
            i++;
        }
        Console.WriteLine();
    }

    public void ExibirAlbuns(List<Album> albunsRegistrados)
    {
        int i = 1;
        foreach (Album album in albunsRegistrados)
        {
            Console.WriteLine($"{i} - {album.Nome}, {album.Banda.Nome} ({album.NotaMedia})");
            i++;
        }
        Console.WriteLine();
    }
    public virtual void Executar(List<Banda> bandasRegistradas)
    {
        Console.Clear();
    }
}
