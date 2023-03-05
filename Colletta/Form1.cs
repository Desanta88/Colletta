using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public Form1()
        {
            InitializeComponent();
            colletta = new CollettaP();
            for(int i = 0; i < intes.Length; i++)
            {
                listView1.Columns.Add(intes[i]);
            }
        }
    }
}
