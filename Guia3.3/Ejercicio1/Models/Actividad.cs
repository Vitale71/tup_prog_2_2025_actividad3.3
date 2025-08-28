using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public abstract class Actividad
    {
        public int Periodo { get; set; }
        public string Descripcion { get; set; }
        public List<Parcela> LotesAsignados = new List<Parcela>();
        public Actividad(int periodo, string descripcion, Parcela p) 
        { 
        
        }

        abstract public double CalcularRendimiento();

        abstract public double CalcularProduccion();

    }
}
