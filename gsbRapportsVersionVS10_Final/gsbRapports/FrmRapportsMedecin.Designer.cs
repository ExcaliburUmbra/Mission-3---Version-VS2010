namespace gsbRapports
{
    partial class FrmRapportsMedecin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnValdierXml = new System.Windows.Forms.Button();
            this.lblBilan = new System.Windows.Forms.Label();
            this.lblMotif = new System.Windows.Forms.Label();
            this.lblRapport = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.Bilan = new System.Windows.Forms.Label();
            this.Motif = new System.Windows.Forms.Label();
            this.dateRapport = new System.Windows.Forms.Label();
            this.nom = new System.Windows.Forms.Label();
            this.cmbPreMed = new System.Windows.Forms.ComboBox();
            this.cmbNomMed = new System.Windows.Forms.ComboBox();
            this.prenomMed = new System.Windows.Forms.Label();
            this.nomMed = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.bdgRapportMed = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdgRapportMed)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnValdierXml);
            this.groupBox1.Controls.Add(this.lblBilan);
            this.groupBox1.Controls.Add(this.lblMotif);
            this.groupBox1.Controls.Add(this.lblRapport);
            this.groupBox1.Controls.Add(this.lblNom);
            this.groupBox1.Controls.Add(this.Bilan);
            this.groupBox1.Controls.Add(this.Motif);
            this.groupBox1.Controls.Add(this.dateRapport);
            this.groupBox1.Controls.Add(this.nom);
            this.groupBox1.Location = new System.Drawing.Point(50, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 177);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dernier rapport";
            // 
            // btnValdierXml
            // 
            this.btnValdierXml.Location = new System.Drawing.Point(254, 148);
            this.btnValdierXml.Name = "btnValdierXml";
            this.btnValdierXml.Size = new System.Drawing.Size(121, 23);
            this.btnValdierXml.TabIndex = 6;
            this.btnValdierXml.Text = "Exporter le rapport";
            this.btnValdierXml.UseVisualStyleBackColor = true;
            this.btnValdierXml.Click += new System.EventHandler(this.btnValdierXml_Click);
            // 
            // lblBilan
            // 
            this.lblBilan.AutoSize = true;
            this.lblBilan.Location = new System.Drawing.Point(170, 113);
            this.lblBilan.Name = "lblBilan";
            this.lblBilan.Size = new System.Drawing.Size(123, 13);
            this.lblBilan.TabIndex = 7;
            this.lblBilan.Text = "En attente d\'une valeur..";
            // 
            // lblMotif
            // 
            this.lblMotif.AutoSize = true;
            this.lblMotif.Location = new System.Drawing.Point(170, 76);
            this.lblMotif.Name = "lblMotif";
            this.lblMotif.Size = new System.Drawing.Size(123, 13);
            this.lblMotif.TabIndex = 6;
            this.lblMotif.Text = "En attente d\'une valeur..";
            // 
            // lblRapport
            // 
            this.lblRapport.AutoSize = true;
            this.lblRapport.Location = new System.Drawing.Point(170, 46);
            this.lblRapport.Name = "lblRapport";
            this.lblRapport.Size = new System.Drawing.Size(123, 13);
            this.lblRapport.TabIndex = 5;
            this.lblRapport.Text = "En attente d\'une valeur..";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(170, 19);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(123, 13);
            this.lblNom.TabIndex = 4;
            this.lblNom.Text = "En attente d\'une valeur..";
            // 
            // Bilan
            // 
            this.Bilan.AutoSize = true;
            this.Bilan.Location = new System.Drawing.Point(6, 113);
            this.Bilan.Name = "Bilan";
            this.Bilan.Size = new System.Drawing.Size(30, 13);
            this.Bilan.TabIndex = 3;
            this.Bilan.Text = "Bilan";
            // 
            // Motif
            // 
            this.Motif.AutoSize = true;
            this.Motif.Location = new System.Drawing.Point(6, 76);
            this.Motif.Name = "Motif";
            this.Motif.Size = new System.Drawing.Size(30, 13);
            this.Motif.TabIndex = 2;
            this.Motif.Text = "Motif";
            // 
            // dateRapport
            // 
            this.dateRapport.AutoSize = true;
            this.dateRapport.Location = new System.Drawing.Point(6, 46);
            this.dateRapport.Name = "dateRapport";
            this.dateRapport.Size = new System.Drawing.Size(81, 13);
            this.dateRapport.TabIndex = 1;
            this.dateRapport.Text = "Date du rapport";
            // 
            // nom
            // 
            this.nom.AutoSize = true;
            this.nom.Location = new System.Drawing.Point(7, 20);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(73, 13);
            this.nom.TabIndex = 0;
            this.nom.Text = "Nom Médecin";
            // 
            // cmbPreMed
            // 
            this.cmbPreMed.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbPreMed.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPreMed.DisplayMember = "prenom";
            this.cmbPreMed.Enabled = false;
            this.cmbPreMed.FormattingEnabled = true;
            this.cmbPreMed.Location = new System.Drawing.Point(294, 64);
            this.cmbPreMed.Name = "cmbPreMed";
            this.cmbPreMed.Size = new System.Drawing.Size(121, 21);
            this.cmbPreMed.TabIndex = 16;
            // 
            // cmbNomMed
            // 
            this.cmbNomMed.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbNomMed.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbNomMed.DisplayMember = "nom";
            this.cmbNomMed.FormattingEnabled = true;
            this.cmbNomMed.Location = new System.Drawing.Point(294, 22);
            this.cmbNomMed.Name = "cmbNomMed";
            this.cmbNomMed.Size = new System.Drawing.Size(121, 21);
            this.cmbNomMed.TabIndex = 15;
            // 
            // prenomMed
            // 
            this.prenomMed.AutoSize = true;
            this.prenomMed.Location = new System.Drawing.Point(60, 72);
            this.prenomMed.Name = "prenomMed";
            this.prenomMed.Size = new System.Drawing.Size(49, 13);
            this.prenomMed.TabIndex = 14;
            this.prenomMed.Text = "Prénom :";
            // 
            // nomMed
            // 
            this.nomMed.AutoSize = true;
            this.nomMed.Location = new System.Drawing.Point(60, 25);
            this.nomMed.Name = "nomMed";
            this.nomMed.Size = new System.Drawing.Size(35, 13);
            this.nomMed.TabIndex = 13;
            this.nomMed.Text = "Nom :";
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(340, 116);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 12;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // bdgRapportMed
            // 
            this.bdgRapportMed.DataSource = typeof(gsbRapports.medecin);
            // 
            // FrmRapportsMedecin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::gsbRapports.Properties.Resources.logo_gsb;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(475, 353);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbPreMed);
            this.Controls.Add(this.cmbNomMed);
            this.Controls.Add(this.prenomMed);
            this.Controls.Add(this.nomMed);
            this.Controls.Add(this.btnValider);
            this.DoubleBuffered = true;
            this.Name = "FrmRapportsMedecin";
            this.Text = "FrmRapportsMedecin";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdgRapportMed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnValdierXml;
        private System.Windows.Forms.Label lblBilan;
        private System.Windows.Forms.Label lblMotif;
        private System.Windows.Forms.Label lblRapport;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label Bilan;
        private System.Windows.Forms.Label Motif;
        private System.Windows.Forms.Label dateRapport;
        private System.Windows.Forms.Label nom;
        private System.Windows.Forms.ComboBox cmbPreMed;
        private System.Windows.Forms.ComboBox cmbNomMed;
        private System.Windows.Forms.Label prenomMed;
        private System.Windows.Forms.Label nomMed;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.BindingSource bdgRapportMed;
    }
}