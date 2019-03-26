using LibraryClassLab04.Arbol_B;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LibraryClassLab04.Interfaces
{

    public interface IEntry<TKey, T>
    {
        bool Equals(Entry<TKey, T> other);
    }
}
