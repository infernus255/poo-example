using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class Traductor
    {
        public Traductor()
        {
            palabras = new Dictionary<string, Dictionary<string, string>>();
        }

        //Dictionary<idiomaBase, Dictionary<nombreIdioma, traduccion>>
        private Dictionary<string, Dictionary<string, string>> palabras;
        private readonly string idiomaBase = "english";

        public void agregarTraduccion(string palabraBase, string traduccion, string idioma)
        {
            //si el idioma no es el base que le agregue traduccion
            if (idioma != idiomaBase)
            {
                //si contiene la palabra base
                if (palabras.ContainsKey(palabraBase))
                {
                    //si existe traduccion para ese idioma
                    if (palabras[palabraBase].ContainsKey(idioma))
                    {
                        //la reemplazo 
                        palabras[palabraBase][idioma] = traduccion;
                    }
                    else
                    {
                        palabras[palabraBase].Add(idioma, traduccion);
                    }
                }
                //si no contiene niguna traduccion para la palabra base
                else
                {
                    Dictionary<string, string> traducciones = new Dictionary<string, string>();
                    traducciones.Add(idioma, traduccion);
                    palabras.Add(palabraBase, traducciones);
                }
            }
            else
            {
                //si no contiene la palabra base, que la agregue con un dic nulo
                if (!palabras.ContainsKey(palabraBase))
                {
                    palabras.Add(palabraBase, null);
                }

            }
        }

        public string obtenerTraduccion(string palabraBase, string idioma)
        {
            if (palabras.ContainsKey(palabraBase))
            {
                if (palabras[palabraBase].ContainsKey(idioma))
                {
                    return palabras[palabraBase][idioma];
                }
            }
            return palabraBase;
        }
    }
}
