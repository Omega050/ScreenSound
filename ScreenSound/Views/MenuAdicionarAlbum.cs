using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Screensound.Models;

namespace ScreenSound.Views;

internal class MenuAdicionarAlbum : Menu
{
    public override void Executar(List<Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Adicionando um novo Album");
        Console.Write("Insira o nome do album que deseja cadastrar: ");
        string nomeDoAlbum = Console.ReadLine()!;

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
            else Console.WriteLine("Não foi possível adicionar o álbum");
        }
        
        else 
        {
            Console.Clear();
            ExibirTituloDaOpcao("Selecionar Banda");
            ExibirBandas(bandasRegistradas);
            Console.Write($"A qual banda o álbum {nomeDoAlbum} será vinculado? ");
            string nomeDaBanda = Console.ReadLine()!;
            Banda bandaBuscada = bandasRegistradas.Find(b => b.Nome == nomeDaBanda);
            if (bandaBuscada != null)
            {
                bandaBuscada.AdicionarAlbum(new Album(nomeDoAlbum, bandaBuscada));
                Console.Clear();
                Console.WriteLine($"O álbum {nomeDoAlbum} foi adicionado à discografia da banda {bandaBuscada.Nome}");
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