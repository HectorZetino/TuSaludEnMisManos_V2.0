using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TuSaludEnMisManos_V02.Models
{
    public class Medicamento : IComparable
    {
        [Display(Name = "ID")]
        public int Id { get; set; }

        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }

        [Display(Name = "Precio")]
        [DataType(DataType.Currency)]
        public double Precio { get; set; }

        [Display(Name = "Casa médica")]
        public string Casa { get; set; }

        [Display(Name = "Existecias")]
        public int Existencia { get; set; }

        public Medicamento(string id, string nombre, string descripcion, string casa, string precio, string existencia)
        {
            Id = Int32.Parse(id);
            Nombre = nombre;
            Descripcion = descripcion;
            Casa = casa;

            var aux = precio.Substring(1);

            Precio = Double.Parse(aux);
            Existencia = Int32.Parse(existencia);
        }
        public int CompareTo(object obj)
        {
            var comparer = (Medicamento)obj;

            return Nombre.CompareTo(comparer.Nombre);
        }
        public static Comparison<Medicamento> OrdenarPorNombre = delegate (Medicamento Med1, Medicamento Med2)
        {
            return Med1.CompareTo(Med2);
        };
    }
}