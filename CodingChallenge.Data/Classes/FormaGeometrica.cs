/*
 * Refactorear la clase para respetar principios de programación orientada a objetos. Qué pasa si debemos soportar un nuevo idioma para los reportes, o
 * agregar más formas geométricas?
 *
 * Se puede hacer cualquier cambio que se crea necesario tanto en el código como en los tests. La única condición es que los tests pasen OK.
 *
 * TODO: Implementar Trapecio/Rectangulo, agregar otro idioma a reporting.
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public abstract class FormaGeometrica
    {
        public string nombre;
        public string nombrePlural;
        public FormaGeometrica(string nombre, string nombrePlural) {
            this.nombre = nombre;
            this.nombrePlural = nombrePlural;
        }
        public abstract decimal CalcularArea();

        public abstract decimal CalcularPerimetro();

    }
}
