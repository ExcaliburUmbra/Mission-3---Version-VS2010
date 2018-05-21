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
    public partial class FrmGerer : Form
    {
        private gsbrapportsEntities mesDonneesEF;
        public FrmGerer(gsbrapportsEntities mesDonneesEF)
        {
            InitializeComponent();
            this.mesDonneesEF = mesDonneesEF;
            this.bdgRapports.DataSource = mesDonneesEF.medecins;
            var query = (from c in mesDonneesEF.medecins
                         orderby c.nom
                         select c.nom).Distinct();
            cmbNom.DataSource = query;
            var query2 = (from c in mesDonneesEF.medecins
                          orderby c.departement
                          select c.departement).Distinct();
            cmbDept.DataSource = query2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string nom = cmbNom.Text;
            int dept = Convert.ToInt32(cmbDept.Text);
            var query = (from c in mesDonneesEF.medecins
                         where nom == c.nom && dept == c.departement
                         select c);
            dataGridView1.DataSource = query;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var query1 = (from c in mesDonneesEF.medecins
                          select c);
            dataGridView1.DataSource = query1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAjouterMedecin f = new FrmAjouterMedecin(mesDonneesEF);
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["idDataGridViewTextBoxColumn"].Value);
            string nom = cmbNom.Text;//Convert.ToString(dataGridView1.CurrentRow.Cells["nomDataGridViewTextBoxColumn"].Value);
            //string prenom = Convert.ToString(dataGridView1.CurrentRow.Cells["prenomDataGridViewTextBoxColumn"].Value);
            //string adresse = Convert.ToString(dataGridView1.CurrentRow.Cells["adresseDataGridViewTextBoxColumn"].Value);
            //double tel = Convert.ToDouble(dataGridView1.CurrentRow.Cells["telDataGridViewTextBoxColumn"].Value);
            //string specialitéComplementaire = Convert.ToString(dataGridView1.CurrentRow.Cells["specialiteComplementaireDataGridViewTextBoxColumn"].Value);
            int dept = Convert.ToInt32(cmbDept.Text);//Convert.ToInt32(dataGridView1.CurrentRow.Cells["departementDataGridViewTextBoxColumn"].Value);
            FrmModifierMedecin f = new FrmModifierMedecin(mesDonneesEF, nom, dept);
            f.Show();
        }
        //Resoudre le probleme - Contrainte clé étrangere medecin -> rapport, requete linq a changer ou trouver une autre solution - <!>Résolue<!>
        private void button3_Click(object sender, EventArgs e)
        {
            string nom = cmbNom.Text;
            int dept = Convert.ToInt32(cmbDept.Text);
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["idDataGridViewTextBoxColumn"].Value);
            //Requete linq original
            /*var supprimer = (from c in mesDonneesEF.medecins
                             where nom == c.nom && dept == c.departement
                             select c);*/

            //Tentative requete linq n°1 - Fonctionne!
            var supprimer = mesDonneesEF.medecins.First(x => x.nom == nom && x.departement == dept);

            //Solution original
            /*foreach (var valeur in supprimer)
            {
                mesDonneesEF.medecins.DeleteObject(valeur);
            }*/

            //Tentative foreach n°1 - Fonctionne!
            foreach (var m in mesDonneesEF.rapports.Where(f => f.idMedecin == id))
            {
                mesDonneesEF.rapports.DeleteObject(m);
                this.mesDonneesEF.SaveChanges();
            }

            try
            {
                mesDonneesEF.medecins.DeleteObject(supprimer);
                MessageBox.Show("Le médecin a bien était supprimer");
                this.mesDonneesEF.SaveChanges();
                this.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex.InnerException));
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cmbNom.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["nomDataGridViewTextBoxColumn"].Value);
            cmbDept.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["departementDataGridViewTextBoxColumn"].Value);
        }
    }
}
