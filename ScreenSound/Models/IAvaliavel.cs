using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Models;

internal interface IAvaliavel
{
    float NotaMedia { get; }
    void AdicionarNota(int nota);
}
