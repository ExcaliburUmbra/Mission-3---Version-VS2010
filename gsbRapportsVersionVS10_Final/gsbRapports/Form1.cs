using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace gsbRapports
{
    public partial class Form1 : Form
    {
        private gsbrapportsEntities mesDonneesEF;
        public Form1()
        {
            this.InitializeComponent();
            this.mesDonneesEF = new gsbrapportsEntities();
        }

        private void fichierToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ajouterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmGerer f = new FrmGerer(mesDonneesEF);
            f.Show();
        }

        private void majToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRapportsMedecin f = new FrmRapportsMedecin(mesDonneesEF);
            f.Show();
        }
        
    }
}
