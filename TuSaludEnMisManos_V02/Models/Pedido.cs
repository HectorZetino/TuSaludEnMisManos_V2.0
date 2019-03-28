using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using LibraryClassLab04.Arbol_B;

namespace TuSaludEnMisManos_V02.Models
{
    public class Pedido
    {
        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "Debe ingresar un nombre válido")]
        public string Nombre { get; set; }

        [Display(Name = "Dirección")]
        [DataType(DataType.Text)]
        public string Direccion { get; set; }

        [Display(Name = "NIT")]
        public long Nit { get; set; }

        public List<Medicamento> Medicinas { get; set; }

        [Display(Name = "Total")]
        [DataType(DataType.Currency)]
        public double Total { get; set; }

        public Pedido(string nombre, string direccion, string nit, List<Medicamento> listado)
        {
            Nombre = nombre;
            Direccion = direccion;
            Nit = long.Parse(nit);
            Medicinas = listado;
            Total = CalcularTotal();
        }
        private double CalcularTotal()
        {
            var total = 0.00;

            foreach (var Item in Medicinas)
            {
                total += Item.Precio;
            }
            return total;
        }
        private bool BuscarMedicinas(BArbol<Indice> indice, List<string> nombresMedicina)
        {
            var existen = true;

            foreach (var item in nombresMedicina)
            {
                var medicina = new Indice(0, item);
                if (indice.Buscar(indice.Raiz, medicina, Indice.OrdenarPorNombre) == false)
                {
                    existen = false;
                }
            }
            return existen;
        }
    }
}