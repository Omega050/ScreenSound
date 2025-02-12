using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Models;

internal class Avaliacao
{
    public int Nota { get; }

    public Avaliacao(int nota)
    {
        Nota = nota;
    }

    public static Avaliacao Parse(int nota)
    {
        if (nota < 0) nota = 0;
        if (nota > 10) nota = 10;

        return new Avaliacao(nota);
    }
}
