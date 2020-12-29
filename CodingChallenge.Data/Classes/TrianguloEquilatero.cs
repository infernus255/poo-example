using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class TrianguloEquilatero : FormaGeometrica
    {
        private readonly decimal lado;
        private readonly decimal altura;

        public TrianguloEquilatero(decimal lado) : base("Triangle", "Triangles")
        {
            this.lado = lado;
            this.altura= (decimal)Math.Sqrt((double)((lado * lado) - (lado / 2) * (lado / 2)));
        }
        public override decimal CalcularArea()
        {        
            return (lado * altura) /2;
        }
        public override decimal CalcularPerimetro()
        {
            return 3 * lado;
        }
    }
}
