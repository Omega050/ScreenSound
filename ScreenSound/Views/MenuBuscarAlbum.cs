﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Screensound.Models;

namespace ScreenSound.Views;

internal class MenuBuscarAlbum : Menu
{
    public List<Album> albumsRegistrados = new List<Album>();
    public override void Executar(List<Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Albuns Registrados");
        int i = 1;

        foreach (Album album in bandasRegistradas.SelectMany(b => b.Albums))
        {
            albumsRegistrados.Add(album);
        }

        ExibirAlbuns(albumsRegistrados);
        Console.WriteLine("\nInsira o nome do album que deseja visualizar ou digite 0 para voltar ao menu.");
        string op = Console.ReadLine();

        if (int.TryParse(op, out int opNum))
        {
            if (opNum == 0) return;
        }
        else
        {
            Album albumBuscado = albumsRegistrados.Find(b => b.Nome == op);
            if (albumBuscado == null)
            {
                Console.WriteLine("Album não encontrad0");
                Thread.Sleep(3000);
            }
            else
            {
                MenuVisualizarAlbum menu = new();
                menu.VisualizarAlbum(albumBuscado);
            }
        }
    }
}
