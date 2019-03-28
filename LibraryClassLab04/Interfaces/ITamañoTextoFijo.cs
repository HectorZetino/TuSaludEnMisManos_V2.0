using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryClassLab04.Interfaces
{
    interface ITamañoTextoFijo<T> where T : ITextoTamañoFijo
    {
        T Fabricar(string textoTamañoFijo);
        T FabricarNulo();
    }
}
