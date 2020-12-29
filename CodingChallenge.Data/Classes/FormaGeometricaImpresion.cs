using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class FormaGeometricaImpresion
    {
        public FormaGeometricaImpresion(int cantidad,decimal area, decimal perimetro, string plural ) {
            this.cantidad = cantidad;
            this.area = area;
            this.perimetro = perimetro;
            this.plural = plural;
        }
        public int cantidad { get; set; }
        public decimal area { get; set; }
        public decimal perimetro { get; set; }
        public readonly string plural;

    }
}
