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
    public partial class FrmModifierMedecin : Form
    {
        private gsbrapportsEntities mesDonneesEF;
        private string nom;
        private int dept;
        public FrmModifierMedecin(gsbrapportsEntities mesDonneesEF, string nom, int dept)
        {
            InitializeComponent();
            for (int i = 0; i <= 9; i++)
                this.cmbDep.Items.Add(i);
            this.mesDonneesEF = mesDonneesEF;
            this.nom = nom;
            this.dept = dept;
            var result = (from c in mesDonneesEF.medecins
                              where c.nom == nom && c.departement == dept
                              select c).First();
            txtId.Text = result.id.ToString();
            txtNom.Text = result.nom;
            txtPrenom.Text = result.prenom;
            txtAdresse.Text = result.adresse;
            txtTel.Text = result.tel;
            txtSpe.Text = result.specialiteComplementaire;
            cmbDep.Text = result.departement.ToString();
            //bdgModif.DataSource = query;
            /*this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.adresse = adresse;
            this.tel = tel;
            this.specialitéComplementaire = specialitéComplementaire;
            this.dept = dept;
            bdgModif.DataSource = mesDonneesEF.medecins;
            txtId.Text = Convert.ToString(id);
            txtNom.Text = nom;
            txtPrenom.Text = prenom;
            txtAdresse.Text = adresse;
            txtTel.Text = Convert.ToString(tel);
            txtSpe.Text = Convert.ToString(specialitéComplementaire);
            cmbDep.Text = Convert.ToString(dept);*/
        }
        //Résoudre le probleme - Modification non sauvegarder
        private void btnValider_Click(object sender, EventArgs e)
        {
            var modif = mesDonneesEF.medecins.First();
            modif.nom = txtNom.Text;
            modif.prenom = txtPrenom.Text;
            modif.adresse = txtAdresse.Text;
            modif.tel = txtTel.Text;
            modif.specialiteComplementaire = txtSpe.Text;
            modif.departement = Convert.ToInt32(cmbDep.Text);
            MessageBox.Show("Les modifications ont bien était prise en compte.");
            this.mesDonneesEF.SaveChanges();
            this.Close();
            /*medecin m = new medecin();
            m.nom = txtNom.Text;
            m.prenom = txtPrenom.Text;
            m.adresse = txtAdresse.Text;
            m.tel = txtTel.Text;
            m.specialiteComplementaire = txtSpe.Text;
            m.departement = Convert.ToInt32(cmbDep.Text);
            MessageBox.Show("La modification a bien étais prise en compte.");
            bdgModif.EndEdit();
            this.mesDonneesEF.SaveChanges();*/
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
