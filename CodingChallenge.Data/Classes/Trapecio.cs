using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class Trapecio : FormaGeometrica
    {
        private readonly decimal baseSuperior;
        private readonly decimal baseInferior;
        private readonly decimal altura;
        public Trapecio(decimal baseSuperior, decimal baseInferior, decimal altura) : base("Trapeze", "Trapezoids")
        {
            this.baseSuperior = baseSuperior;
            this.baseInferior = baseInferior;
            this.altura = altura;
        }
        public override decimal CalcularArea() {
            return ((baseInferior+baseSuperior)*altura)/2;
        }
        public override decimal CalcularPerimetro(){
            return baseInferior+baseSuperior+altura*2;
        }
    }
}
