using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class Trapecio : FormaGeometricaAux
    {
        private readonly decimal baseSuperior;
        private readonly decimal baseInferior;
        private readonly decimal altura;
        public Trapecio(Idioma idioma,decimal baseSuperior, decimal baseInferior) : base(idioma)
        {
            this.baseSuperior = baseSuperior;
            this.baseInferior = baseInferior;
        }
        public override decimal CalcularArea() {
            return ((baseInferior+baseSuperior)*altura)/2;
        }
        public override decimal CalcularPerimetro(){
            return baseInferior+baseSuperior+altura*2;
        }
    }
}
