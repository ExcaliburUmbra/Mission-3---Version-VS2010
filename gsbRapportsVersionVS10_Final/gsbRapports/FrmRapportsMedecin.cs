using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using System.Xml.Linq;
using System.Xml;

namespace gsbRapports
{
    public partial class FrmRapportsMedecin : Form
    {
        private gsbrapportsEntities mesDonneesEF;
        public FrmRapportsMedecin(gsbrapportsEntities mesDonneesEF)
        {
            InitializeComponent();
            this.mesDonneesEF = mesDonneesEF;
            this.bdgRapportMed.DataSource = mesDonneesEF.medecins;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            //Récupération des critères de recherche
            string rechercheNom = cmbNomMed.Text;
            string recherchePrenom = cmbPreMed.Text;
            //Recherche via requête Linq
            var leRapport = (from rapports in mesDonneesEF.rapports
                             join medecins in mesDonneesEF.medecins on rapports.idMedecin equals medecins.id
                             join visiteurs in mesDonneesEF.visiteurs on rapports.idVisiteur equals visiteurs.id
                             orderby rapports.date descending
                             where medecins.nom == rechercheNom && medecins.prenom == recherchePrenom
                             select new
                             {
                                 NomMedecin = medecins.nom,
                                 DateRapport = rapports.date,
                                 Motif = rapports.motif,
                                 Bilan = rapports.bilan,
                                 NomVisiteur = visiteurs.nom
                             }).First();
            lblBilan.Text = leRapport.Bilan.ToString();
            lblRapport.Text = leRapport.DateRapport.ToString();
            lblMotif.Text = leRapport.Motif.ToString();
            lblNom.Text = leRapport.NomVisiteur.ToString();
        }

        private void btnValdierXml_Click(object sender, EventArgs e)
        {
            //Récupération des critères de recherche
            string rechercheNom = cmbNomMed.Text;
            string recherchePrenom = cmbPreMed.Text;
            //Récupère la date et l'heure d'aujourd'hui pour le nom du .xml
            DateTime aujourdhui = DateTime.Now;
            //Recherche via requête Linq
            var leRapport = (from rapports in mesDonneesEF.rapports
                             join medecins in mesDonneesEF.medecins on rapports.idMedecin equals medecins.id
                             join visiteurs in mesDonneesEF.visiteurs on rapports.idVisiteur equals visiteurs.id
                             orderby rapports.date descending
                             where medecins.nom == rechercheNom && medecins.prenom == recherchePrenom
                             select new
                             {
                                 NomMedecin = medecins.nom,
                                 DateRapport = rapports.date,
                                 Motif = rapports.motif,
                                 Bilan = rapports.bilan,
                                 NomVisiteur = visiteurs.nom
                             }).First();
            XElement nomMedecin = new XElement("NomMedecin", leRapport.NomMedecin);
            XElement nomVisiteur = new XElement("NomVisiteur", leRapport.NomVisiteur);
            XElement motif = new XElement("Motif", leRapport.Motif);
            XElement bilan = new XElement("Bilan", leRapport.Bilan);
            XElement date = new XElement("DateRapport", leRapport.DateRapport);
            XElement rapport = new XElement("Rapport");
            rapport.Add(nomMedecin);
            rapport.Add(nomVisiteur);
            rapport.Add(motif);
            rapport.Add(bilan);
            rapport.Add(date);
            XmlSerializer XmlSrlz = new XmlSerializer(typeof(XElement));
            using (StreamWriter sw = new StreamWriter("rapport.xml"))
            {
                XmlSrlz.Serialize(sw, rapport);
            }
            MessageBox.Show("Le fichier: rapport.xml à été enregistré.\r\nDescriptif:\n" + rapport.ToString());
        }
    }
}
