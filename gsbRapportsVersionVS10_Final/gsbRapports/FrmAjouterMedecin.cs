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
    public partial class FrmAjouterMedecin : Form
    {
        private gsbrapportsEntities mesDonneesEF;
        public FrmAjouterMedecin(gsbrapportsEntities mesDonneesEF)
        {
            InitializeComponent();
            for (int i = 0; i <= 9; i++)
                this.cmbDep.Items.Add(i);
            this.mesDonneesEF = mesDonneesEF;
            this.bdgSourceMedecin.DataSource = mesDonneesEF.medecins;
            this.txtId.Text = this.getNumMed().ToString();
        }

        private int getNumMed()
        {
            //requete linq
            var reqDernier = (from el in this.mesDonneesEF.medecins
                              orderby el.id descending
                              select el);
            medecin dernierMed = reqDernier.First();
            int n = dernierMed.id + 1;
            return n;
        }

        private medecin nouveauMed()
        {
            int id = getNumMed();
            string nom = txtNom.Text;
            string prenom = txtPrenom.Text;
            string adresse = txtAdresse.Text;
            string tel = txtTel.Text;
            string spe = txtSpe.Text;
            int dept = Convert.ToInt32(cmbDep.Text);
            medecin m = new medecin();

            m.id = id;
            m.nom = nom;
            m.prenom = prenom;
            m.adresse = adresse;
            m.tel = tel;
            m.specialiteComplementaire = spe;
            m.departement = dept;
            return m;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (txtAdresse.Text == "" || txtNom.Text == "" || txtPrenom.Text == "" || txtTel.Text == "" || txtSpe.Text == "")
            {
                MessageBox.Show("Il faut remplir tous les champs du nouveau medecin");
                bdgSourceMedecin.CancelEdit();
            }
            else
            {
                this.mesDonneesEF.medecins.AddObject(nouveauMed());
                this.mesDonneesEF.SaveChanges(); //enregistre 
                //MessageBox.Show("Le medecin a bien été ajouté : " + txtNom.Text);
                MessageBox.Show("id : " + txtId.Text + " nom : " + txtNom.Text + " prenom : " + txtPrenom.Text + " tel : " + txtTel.Text + " dept : " + cmbDep.Text + "Le médecin a bien était ajouter.");
                Refresh();

            }
        }
    }
}
