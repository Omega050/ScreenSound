namespace Screensound.Models;

internal class Musica
{
    public string Nome { get; }
    public Banda Artista { get; }
    public Genero Genero { get; }
    public int Duracao { get; }
    public bool Disponivel { get; }

    public string Resumo => $"A música {Nome} pertence ao artista {Artista}";

    public Musica(string nome, Banda artista, Genero genero, int duracao, bool disponivel)
    {
        Nome = nome;
        Artista = artista;
        Genero = genero;
        Duracao = duracao;
        Disponivel = disponivel;
    }

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Música: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Gênero: {Genero}");
        Console.WriteLine($"Duração: {Duracao}");
        Console.WriteLine($"Disponível: {(Disponivel ? "Sim" : "Não")}");
    }
}
