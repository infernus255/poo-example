using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class Circulo : FormaGeometrica
    {
        private readonly decimal diametro;
        private readonly decimal radio;

        public Circulo(decimal diametro) : base("Circle", "Circles")
        {
            this.diametro = diametro;
            this.radio = diametro / 2;
        }
        public override decimal CalcularArea()
        {
            return (decimal) Math.PI * radio * radio;
        }
        public override decimal CalcularPerimetro()
        {
            return  2 * (decimal)Math.PI * radio;
        }
    }
}
