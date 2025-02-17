using ScreenSound.Models;

namespace Screensound.Models;

internal class Musica : IAvaliavel
{
    public string Nome { get; }
    public Banda Artista { get; }
    public Album Album { get; set; }
    public Genero Genero { get; }
    public int Duracao { get; }
    public bool Disponivel { get; }
    private List<Avaliacao> Notas { get; }
    public float NotaMedia => Notas.Any() ? (float)Notas.Average(a => a.Nota) : 0f;
    public string Resumo => $"A música {Nome} pertence ao artista {Artista}";

    public Musica(string nome, Banda artista, Genero genero, int duracao, bool disponivel)
    {
        Nome = nome;
        Artista = artista;
        Genero = genero;
        Duracao = duracao;
        Disponivel = disponivel;
        Notas = new List<Avaliacao>();
    }

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Música: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Gênero: {Genero}");
        Console.WriteLine($"Duração: {Duracao}");
        Console.WriteLine($"Disponível: {(Disponivel ? "Sim" : "Não")}");
    }   
    public void AdicionarNota(int n)
    {
        Avaliacao nota = Avaliacao.Parse(n);
        Notas.Add(nota);
    }
    public void DefinirAlbum(Album album)
    {
        Album = album;
    }
}
