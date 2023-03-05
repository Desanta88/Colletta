using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colletta
{
    public partial class Form1 : Form
    {
        public CollettaP colletta;
        string[] intes = { "Key", "Partecipante", "Quota" };
        Partecipante temp;
        public Form1()
        {
            InitializeComponent();
            colletta = new CollettaP();
            for(int i = 0; i < intes.Length; i++)
            {
                listView1.Columns.Add(intes[i]);
            }
        }

        private void AggiuntaQuota_Click(object sender, EventArgs e)
        {
            temp = new Partecipante(textBoxP.Text, float.Parse(textBoxQ.Text));
            if (textBoxP.Text != "" && textBoxQ.Text != "")
            {
                colletta.Aggiungi(temp);
                ListViewItem riga = new ListViewItem(colletta.Raccolta[colletta.getKey(temp)].ToString().Split(';'));
                listView1.Items.Add(riga);
                totaleQuota.Text = "Totale:"+colletta.QuotaTotale.ToString();
            }
            else
                throw new Exception("compilare tutte le textbox");
        }

        private void RimuoviQuota_Click(object sender, EventArgs e)
        {
            int selezionato = 0;
            string key;
            if (listView1.SelectedIndices.Count > 0)
                selezionato = listView1.SelectedIndices[0];
            key = listView1.SelectedItems[0].Text;
            temp = colletta.Raccolta[key];
            colletta.Rimuovi(temp);
            listView1.Items.RemoveAt(selezionato);
            totaleQuota.Text = "Totale:" + colletta.QuotaTotale.ToString();
        }

        private void ModificaQuota_Click(object sender, EventArgs e)
        {

        }
    }
}
