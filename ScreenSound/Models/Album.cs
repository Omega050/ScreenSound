namespace Screensound.Models;

internal class Album
{
    public string Nome { get; }
    private List<Musica> Musicas { get; }
    public Banda Banda { get; }
    public int DuracaoTotal => Musicas.Sum(m => m.Duracao);

    public Album(string nome, Banda banda)
    {
        Nome = nome;
        Banda = banda;
        Musicas = new List<Musica>();
    }

    public void AdicionarMusica(Musica musica)
    {
        Musicas.Add(musica);
    }

    public void ExibirMusicas()
    {
        Console.WriteLine($"\nO álbum {Nome}, pertencente à banda {Banda.Nome}, possui duração total de {DuracaoTotal} segundos e contém as seguintes músicas:\n");

        if (Musicas.Count == 0)
        {
            Console.WriteLine("Nenhuma música adicionada ainda.");
            return;
        }

        for (int i = 0; i < Musicas.Count; i++)
        {
            Console.WriteLine($"{i + 1} - {Musicas[i].Nome}");
        }
    }
}
