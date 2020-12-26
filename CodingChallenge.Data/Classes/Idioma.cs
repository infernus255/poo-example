using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Apis.Translate;

namespace CodingChallenge.Data.Classes
{
    public abstract class Idioma
    {   //nombreForma
        //nombreFormaPlural
        Google.Apis.Translate.v3.Data.Translation
        public abstract string traducir(string texto);
    }
}
