using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Screensound.Models;

namespace ScreenSound.Views
{
    internal class MenuAdicionarMusica : Menu
    {
        public void AdicionarMusica(List<Banda> bandasRegistradas, List<Musica> musicasRegistradas)
        {
                base.Executar(bandasRegistradas);
                ExibirTituloDaOpcao("Adicionando uma nova Música");
                Console.Write("Insira o nome da música que deseja cadastrar: ");
                string nomeDaMusica = Console.ReadLine()!;

                if (bandasRegistradas.Count == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Nenhuma banda cadastrada, deseja realizar o registro de uma banda (S/N)?");
                    string op = Console.ReadLine()!;
                    if (op == "S")
                    {
                        Menu menuRegistrarBanda = new MenuRegistrarBanda();
                        menuRegistrarBanda.Executar(bandasRegistradas);
                    }
                    else Console.WriteLine("Não foi possível adicionar a música");
                }

                else
                {
                    Console.Clear();
                    Console.Write("Gênero da música: ");
                    Genero genero = new Genero();
                    int duracao = 0;
                    bool disponivel = true;
                    ExibirTituloDaOpcao("Selecionar Banda");
                    ExibirBandas(bandasRegistradas);
                    Console.WriteLine($"A qual banda a música {nomeDaMusica} será vinculada? ");
                    string nomeDaBanda = Console.ReadLine()!;
                    Banda bandaBuscada = bandasRegistradas.Find(b => b.Nome == nomeDaBanda);
                    if (bandaBuscada != null)
                    {
                    Musica musica = new(nomeDaMusica, bandaBuscada, genero, duracao, disponivel);
                        musicasRegistradas.Add(musica);
                        Console.Clear();
                        Console.WriteLine($"A música {nomeDaMusica} da banda {bandaBuscada.Nome} foi adicionada com sucesso.");
                        Thread.Sleep(2000);
                        Console.Clear();
                        Console.WriteLine($"Deseja cadastrar a música {nomeDaMusica} a um album?(S/N)?");
                        string op = Console.ReadLine()!;
                        if (op == "S")
                        {
                            MenuAdicionarMusicaAoAlbum menu = new MenuAdicionarMusicaAoAlbum();
                            menu.AdicionarMusicaAoAlbum(musica, bandaBuscada);
                        }
                        else return;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada");
                        Console.WriteLine("\nPressione enter para voltar ao menu");
                        Console.ReadLine();
                    }
                }
            
        }
    }
}
