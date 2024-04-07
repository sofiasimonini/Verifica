using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verifica
{
    enum TipoSport
    {
        Pallavolo,
        Calcio,
        Nuoto,
    }
    internal class Persona
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public int Eta { get; set; }
        public TipoSport SportPraticato { get; set; }
    }
}
