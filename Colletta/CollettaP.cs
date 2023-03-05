using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colletta
{
    public class CollettaP
    {
        private Dictionary<string, Partecipante> _raccolta;
        private string key;
        private int n;
        private float _quotatotale;
        public Dictionary<string, Partecipante> Raccolta{get; private set;}
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
                p.Id = key;
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
                Raccolta.Remove(p.Id);
                QuotaTotale -= p.Quota;
                n--;
                /*foreach (KeyValuePair<string, Partecipante> kvp in Raccolta)
                {
                    if (Raccolta[kvp.Key].Nome == p.Nome)
                    {
                        Raccolta.Remove(key);
                        QuotaTotale -= p.Quota;
                        n--;
                    }
                }*/
            }
            else
                throw new Exception("il reference del partecipante è null");
        }
        public void Modifica(Partecipante p)
        {
            if (p != null)
            {
                QuotaTotale -= Raccolta[key].Quota;
                Raccolta[p.Id] = p;
                QuotaTotale += p.Quota;
                /*foreach (KeyValuePair<string, Partecipante> kvp in Raccolta)
                {
                    if (Raccolta[kvp.Key].Nome == p.Nome)
                    {
                        QuotaTotale -= Raccolta[key].Quota;
                        Raccolta[key] = p;
                        QuotaTotale += p.Quota;
                    }
                }*/
            }
            else
                throw new Exception("il reference del partecipante è null");
        }
        public int getCount()
        {
            return Raccolta.Count;
        }
        public string getKey(Partecipante p)
        {
            string temp="";
            foreach(KeyValuePair<string,Partecipante> kvp in Raccolta)
            {
                if (Raccolta[kvp.Key].Nome == p.Nome)
                {
                    temp = kvp.Key;
                }
            }
            return temp;
        }
    }
}
