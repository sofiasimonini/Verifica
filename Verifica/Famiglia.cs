using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verifica
{
    internal class Famiglia
    {
        public string Cognome { get; set; }
        public List <Persona> Persone { get; set; }   
        public double EtaMedia()
        {
            int somma = 0;
            foreach (Persona persona in Persone)
            {
                somma += persona.Eta;
            }
            return (double)somma/Persone.Count;
        }
    }
}
