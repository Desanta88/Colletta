using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colletta
{
    public class CollettaP
    {
        Dictionary<string, Partecipante> Raccolta;
        private string key;
        private int n;
        private float _quotatotale;
        public float QuotaTotale{get;private set;}
        public CollettaP()
        {
            QuotaTotale = 0;
            Raccolta = new Dictionary<string, Partecipante>();
            n = 1;
        }
        public void Aggiungi(Partecipante p)
        {
            if (p != null)
            {
                key = "P" + n.ToString();
                Raccolta.Add(key, p);
                QuotaTotale += p.Quota;
                n++;
            }
            else
                throw new Exception("il reference del partecipante è null");
        }
        public void Rimuovi(Partecipante p)
        {
            if (p != null)
            {
                Raccolta.Remove(key);
                QuotaTotale -= p.Quota;
                n--;
            }
            else
                throw new Exception("il reference del partecipante è null");
        }
        public void Modifica(Partecipante p)
        {
            if (p != null)
            {
                QuotaTotale -= Raccolta[key].Quota;
                Raccolta[key] = p;
                QuotaTotale += p.Quota;
            }
            else
                throw new Exception("il reference del partecipante è null");
        }
    }
}
