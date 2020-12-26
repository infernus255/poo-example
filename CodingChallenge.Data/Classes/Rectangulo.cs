using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class Rectangulo : FormaGeometricaAux
    {
        private readonly decimal _base;
        private readonly decimal altura;
        public Rectangulo(Idioma idioma, decimal _base, decimal altura ) : base(idioma)
        {
            this._base = _base;
            this.altura = altura;
        }
        public override decimal CalcularArea(){
            return _base*altura;
        }
        public override decimal CalcularPerimetro(){
            return _base*2+altura*2;
        }
    }
}
