using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryClassLab04.Arbol_B
{
    class Node<T>
    {
        public T Value { get; set; }
        public Node<T> Izdo;
        public Node<T> Dcho;
        public Node<T> Padre;
        public Node(T value, Node<T> padre)
        {
            this.Value = value;
            Izdo = null;
            Dcho = null;
            Padre = padre;
        }
    }
}
