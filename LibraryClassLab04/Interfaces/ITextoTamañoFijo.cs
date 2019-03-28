using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryClassLab04.Interfaces
{
    interface ITextoTamañoFijo
    {
        int FixedSizeText { get; }
        string ToFixedSizeString();
    }
}
