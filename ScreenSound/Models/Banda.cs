using ScreenSound.Models;

namespace Screensound.Models;

internal class Banda : IAvaliavel
{
    public string Nome { get; }
    public List<Album> Albums { get; } 
    private List<Avaliacao> Notas { get; } 

    public float NotaMedia => Notas.Any() ? (float)Notas.Average(a => a.Nota) : 0f;

    public Banda(string nome)
    {
        Nome = nome;
        Albums = new List<Album>();
        Notas = new List<Avaliacao>();
    }

    public void AdicionarAlbum(Album album)
    {
        Albums.Add(album);
    }

    public void AdicionarNota(int n)
    {   
        Avaliacao nota = Avaliacao.Parse(n);
        Notas.Add(nota);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda {Nome}:\n");
        foreach (var album in Albums)
        {
            Console.WriteLine($"Álbum: {album.Nome}");
        }
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"A banda {Nome} possui atualmente a nota {NotaMedia}.\n");
    }
}
