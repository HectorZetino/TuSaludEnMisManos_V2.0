using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryClassLab04.Arbol_B;

namespace LibraryClassLab04.Interfaces
{
    interface INonLinearStructure<T>
    {
        void Insertar(ref Node<T> arbol, T value, Delegate comparer, Node<T> padre);
        T Mostrar();
        bool Buscar(Node<T> arbol, T value, Delegate comparer);
        T DevolverValor();
        void Eliminar(Node<T> Arbol, T value, Delegate comparer);
    }
}
