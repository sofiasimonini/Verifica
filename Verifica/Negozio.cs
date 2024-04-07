using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Verifica
{
    internal class Return
    {
        public List<Famiglia> famiglie { get; set; }
        public double EtaMedia_Sport(TipoSport sport)
        {
            int counter = 0;
            int somma = 0;
            foreach (Famiglia famiglia in Famiglie)
            {
                foreach (Persona persona in famiglia.Persone) 
                { 
                    if (persona.SportPraticato == sport)
                    {
                        counter++;
                        somma += persona.Eta;
                    }
                }
            }
            return (double)somma / counter;
        }
        
    }
}
