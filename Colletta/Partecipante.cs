using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colletta
{
    public class Partecipante
    {
        private string _nome;
        private float _quota;
        public string Nome { get; set; }
        public float Quota { get; set; }
        public Partecipante(string nome, float quota)
        {
            Nome = nome;
            Quota = quota;
        }
        public Partecipante():this("N/A",0)
        {

        }
        public override string ToString()
        {
            return Nome + " " + Quota.ToString();
        }
    }
}
