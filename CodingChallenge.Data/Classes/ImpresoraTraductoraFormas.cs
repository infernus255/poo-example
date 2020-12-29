using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class ImpresoraTraductoraFormas
    {
        private List<FormaGeometrica> formas;

        public ImpresoraTraductoraFormas() {
            formas = new List<FormaGeometrica>();
        }

        public string imprimir(Traductor traductor, string idioma)
        {
            StringBuilder sb = new StringBuilder();
            if (formas.Count > 0)
            {
                //agrego header
                addHeader(sb, traductor, idioma);
                //contador para cada forma 
                Dictionary<string, FormaGeometricaImpresion> cantFormas = new Dictionary<string, FormaGeometricaImpresion>();
                foreach (FormaGeometrica forma in formas)
                {
                    //si contiene la forma le suma 1
                    if (cantFormas.ContainsKey(forma.nombre))
                    {
                        FormaGeometricaImpresion formaConKey = cantFormas[forma.nombre];
                        formaConKey.cantidad++;
                        formaConKey.area += forma.CalcularArea();
                        formaConKey.perimetro += forma.CalcularPerimetro();
                    }
                    else
                    {
                        //sino la crea con 1 
                        FormaGeometricaImpresion formaSinKey = new FormaGeometricaImpresion(1, forma.CalcularArea(), forma.CalcularPerimetro(), forma.nombrePlural);
                        cantFormas.Add(forma.nombre, formaSinKey);
                    }
                }
                addBodyAndFooter(sb, traductor, idioma, cantFormas);
            }
            else
            {
                //imprimo vacia
                addVacio(sb, traductor, idioma);
            }

            return sb.ToString();
        }

        public void agregarForma(FormaGeometrica forma)
        {
            formas.Add(forma);
        }

        private void addVacio(StringBuilder sb, Traductor traductor, string idioma)
        {
            sb.Append("<h1>");
            sb.Append(traductor.obtenerTraduccion("List", idioma));
            sb.Append(" ");
            sb.Append(traductor.obtenerTraduccion("empty", idioma));
            sb.Append(" ");
            sb.Append(traductor.obtenerTraduccion("of", idioma));
            sb.Append(" ");
            sb.Append(traductor.obtenerTraduccion("shapes", idioma));
            sb.Append("!");
            sb.Append("</h1>");
        }

        private void addHeader(StringBuilder sb, Traductor traductor, string idioma)
        {
            sb.Append("<h1>");
            sb.Append(traductor.obtenerTraduccion("Report", idioma));
            sb.Append(" ");
            sb.Append(traductor.obtenerTraduccion("of", idioma));
            sb.Append(" ");
            sb.Append(traductor.obtenerTraduccion("Shapes", idioma));
            sb.Append("</h1>");
        }

        private void addBodyAndFooter(StringBuilder sb, Traductor traductor, string idioma, Dictionary<string, FormaGeometricaImpresion> cantFormas)
        {
            int cantTotalFormas = 0;
            decimal cantTotalPerimetro = 0;
            decimal cantTotalArea = 0;
            int conteoFormas = cantFormas.Count;
            //recorro cada forma distinta y añado a sb
            foreach (KeyValuePair<string, FormaGeometricaImpresion> entry in cantFormas)
            {

                sb.Append(entry.Value.cantidad);
                sb.Append(" ");
                //si es plural o singular
                if (entry.Value.cantidad > 1)
                {
                    sb.Append(traductor.obtenerTraduccion(entry.Value.plural, idioma));
                }
                else
                {
                    sb.Append(traductor.obtenerTraduccion(entry.Key, idioma));
                }
                sb.Append(" | ");
                sb.Append(traductor.obtenerTraduccion("Area", idioma));
                sb.Append(" ");
                sb.Append(entry.Value.area);
                sb.Append(" | ");
                sb.Append(traductor.obtenerTraduccion("Perimeter", idioma));
                sb.Append(" ");
                sb.Append(entry.Value.perimetro);
                sb.Append(" ");
                //Si hay mas de un tipo de forma pongo br
                if (conteoFormas > 1)
                {
                    sb.Append("< br />");
                }
                
                //contadores footer
                cantTotalFormas += entry.Value.cantidad;
                cantTotalPerimetro += entry.Value.perimetro;
                cantTotalArea += entry.Value.area;
            }
            //footer
            sb.Append($"<br/>{traductor.obtenerTraduccion("TOTAL", idioma)}:<br/>");
            sb.Append(cantTotalFormas);
            sb.Append(" ");
            sb.Append(traductor.obtenerTraduccion("shapes", idioma));
            sb.Append(" ");
            sb.Append(traductor.obtenerTraduccion("Perimeter", idioma));
            sb.Append(" ");
            sb.Append(cantTotalPerimetro);
            sb.Append(" ");
            sb.Append(traductor.obtenerTraduccion("Area", idioma));
            sb.Append(" ");
            sb.Append(cantTotalArea);
            sb.Append(" ");
        }
    }
}
