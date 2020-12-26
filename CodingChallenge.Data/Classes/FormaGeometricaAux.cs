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
    public abstract class FormaGeometricaAux
    {
        //ReadOnly es similar a final en java, solo se puede asignar una vez 
        //protected readonly decimal tamanoLados;
        //protected readonly int cantLados;
        protected readonly Idioma idioma;

        public FormaGeometricaAux(Idioma idioma)
        {
            //this.tamanoLados = tamanoLados;
            //this.cantLados = cantLados;
            this.idioma = idioma;
        }

        public abstract decimal CalcularArea();

        public abstract decimal CalcularPerimetro();

        public override string ToString() {
            return "";
        }

        //analizar como hacer, capaz inyeccion de dependencia
        //protected abstract static string TraducirForma(int tipo, int cantidad, int idioma);
        //private static string ObtenerLinea(int cantidad, decimal area, decimal perimetro, int tipo, int idioma)
        //{
        //}
        //public static string Imprimir(List<FormaGeometrica> formas, int idioma)
        //{
        //}
    }
}
