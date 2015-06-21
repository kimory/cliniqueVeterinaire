namespace IHMWindows
{
    partial class PrincipalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.secrétariatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.priseDeRendezousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dossierClientAnimauxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relancesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miseAJourDuStockDeVaccinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vétérinaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dossiersMedicauxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paramétrageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vétérinairesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miseÀJourDuBarèmeDeTarificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ButtRendezVous = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ButtClientAnimal = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ButRelance = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ButAgenda = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.ButDossierMedical = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.secrétariatToolStripMenuItem,
            this.vétérinaireToolStripMenuItem,
            this.paramétrageToolStripMenuItem,
            this.aProposToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1190, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // secrétariatToolStripMenuItem
            // 
            this.secrétariatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.priseDeRendezousToolStripMenuItem,
            this.dossierClientAnimauxToolStripMenuItem,
            this.relancesToolStripMenuItem,
            this.miseAJourDuStockDeVaccinToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.secrétariatToolStripMenuItem.Name = "secrétariatToolStripMenuItem";
            this.secrétariatToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.secrétariatToolStripMenuItem.Text = "Secrétariat";
            // 
            // priseDeRendezousToolStripMenuItem
            // 
            this.priseDeRendezousToolStripMenuItem.Image = global::IHMWindows.Properties.Resources.evolution_calendrier_icone_5221_48;
            this.priseDeRendezousToolStripMenuItem.Name = "priseDeRendezousToolStripMenuItem";
            this.priseDeRendezousToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.priseDeRendezousToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.priseDeRendezousToolStripMenuItem.Text = "Prise de rendez-vous";
            this.priseDeRendezousToolStripMenuItem.Click += new System.EventHandler(this.priseDeRendezousToolStripMenuItem_Click);
            // 
            // dossierClientAnimauxToolStripMenuItem
            // 
            this.dossierClientAnimauxToolStripMenuItem.Image = global::IHMWindows.Properties.Resources.animal_chat_icone_4095_48;
            this.dossierClientAnimauxToolStripMenuItem.Name = "dossierClientAnimauxToolStripMenuItem";
            this.dossierClientAnimauxToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.dossierClientAnimauxToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.dossierClientAnimauxToolStripMenuItem.Text = "Dossier Client/Animaux";
            this.dossierClientAnimauxToolStripMenuItem.Click += new System.EventHandler(this.dossierClientAnimauxToolStripMenuItem_Click);
            // 
            // relancesToolStripMenuItem
            // 
            this.relancesToolStripMenuItem.Image = global::IHMWindows.Properties.Resources.brown_enveloppe_lettre_message_icone_5321_48;
            this.relancesToolStripMenuItem.Name = "relancesToolStripMenuItem";
            this.relancesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.relancesToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.relancesToolStripMenuItem.Text = "Relances";
            this.relancesToolStripMenuItem.Click += new System.EventHandler(this.relancesToolStripMenuItem_Click);
            // 
            // miseAJourDuStockDeVaccinToolStripMenuItem
            // 
            this.miseAJourDuStockDeVaccinToolStripMenuItem.Image = global::IHMWindows.Properties.Resources.ajouter;
            this.miseAJourDuStockDeVaccinToolStripMenuItem.Name = "miseAJourDuStockDeVaccinToolStripMenuItem";
            this.miseAJourDuStockDeVaccinToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.miseAJourDuStockDeVaccinToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.miseAJourDuStockDeVaccinToolStripMenuItem.Text = "Mise à jour du stock de vaccins";
            this.miseAJourDuStockDeVaccinToolStripMenuItem.Click += new System.EventHandler(this.miseAJourDuStockDeVaccinToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Image = global::IHMWindows.Properties.Resources.supprimer;
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // vétérinaireToolStripMenuItem
            // 
            this.vétérinaireToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agendaToolStripMenuItem,
            this.dossiersMedicauxToolStripMenuItem});
            this.vétérinaireToolStripMenuItem.Name = "vétérinaireToolStripMenuItem";
            this.vétérinaireToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.vétérinaireToolStripMenuItem.Text = "Vétérinaire";
            // 
            // agendaToolStripMenuItem
            // 
            this.agendaToolStripMenuItem.Image = global::IHMWindows.Properties.Resources.evolution_calendrier_icone_5221_48;
            this.agendaToolStripMenuItem.Name = "agendaToolStripMenuItem";
            this.agendaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.agendaToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.agendaToolStripMenuItem.Text = "Agenda";
            this.agendaToolStripMenuItem.Click += new System.EventHandler(this.agendaToolStripMenuItem_Click);
            // 
            // dossiersMedicauxToolStripMenuItem
            // 
            this.dossiersMedicauxToolStripMenuItem.Image = global::IHMWindows.Properties.Resources.ajouter;
            this.dossiersMedicauxToolStripMenuItem.Name = "dossiersMedicauxToolStripMenuItem";
            this.dossiersMedicauxToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.dossiersMedicauxToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.dossiersMedicauxToolStripMenuItem.Text = "Dossiers Médicaux";
            this.dossiersMedicauxToolStripMenuItem.Click += new System.EventHandler(this.dossiersMedicauxToolStripMenuItem_Click);
            // 
            // paramétrageToolStripMenuItem
            // 
            this.paramétrageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vétérinairesToolStripMenuItem,
            this.miseÀJourDuBarèmeDeTarificationToolStripMenuItem});
            this.paramétrageToolStripMenuItem.Name = "paramétrageToolStripMenuItem";
            this.paramétrageToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.paramétrageToolStripMenuItem.Text = "Paramétrage";
            // 
            // vétérinairesToolStripMenuItem
            // 
            this.vétérinairesToolStripMenuItem.Image = global::IHMWindows.Properties.Resources.femme_groupe_male_utilisateurs_icone_7201_48;
            this.vétérinairesToolStripMenuItem.Name = "vétérinairesToolStripMenuItem";
            this.vétérinairesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.vétérinairesToolStripMenuItem.Size = new System.Drawing.Size(323, 22);
            this.vétérinairesToolStripMenuItem.Text = "Vétérinaires";
            this.vétérinairesToolStripMenuItem.Click += new System.EventHandler(this.vétérinairesToolStripMenuItem_Click);
            // 
            // miseÀJourDuBarèmeDeTarificationToolStripMenuItem
            // 
            this.miseÀJourDuBarèmeDeTarificationToolStripMenuItem.Image = global::IHMWindows.Properties.Resources.pilule_icone_4522_32;
            this.miseÀJourDuBarèmeDeTarificationToolStripMenuItem.Name = "miseÀJourDuBarèmeDeTarificationToolStripMenuItem";
            this.miseÀJourDuBarèmeDeTarificationToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.miseÀJourDuBarèmeDeTarificationToolStripMenuItem.Size = new System.Drawing.Size(323, 22);
            this.miseÀJourDuBarèmeDeTarificationToolStripMenuItem.Text = "Mise à jour du barème de tarification";
            // 
            // aProposToolStripMenuItem
            // 
            this.aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            this.aProposToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.aProposToolStripMenuItem.Text = "A propos";
            this.aProposToolStripMenuItem.Click += new System.EventHandler(this.aProposToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStrip1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ButtRendezVous,
            this.toolStripLabel5,
            this.toolStripSeparator1,
            this.ButtClientAnimal,
            this.toolStripLabel3,
            this.toolStripSeparator2,
            this.ButRelance,
            this.toolStripLabel4,
            this.toolStripSeparator3,
            this.ButAgenda,
            this.toolStripLabel2,
            this.toolStripSeparator4,
            this.ButDossierMedical,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(1065, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(125, 847);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ButtRendezVous
            // 
            this.ButtRendezVous.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButtRendezVous.Image = global::IHMWindows.Properties.Resources.horloge_rouge_icone_5335_32;
            this.ButtRendezVous.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtRendezVous.Name = "ButtRendezVous";
            this.ButtRendezVous.Size = new System.Drawing.Size(122, 44);
            this.ButtRendezVous.Text = "Rendez-vous";
            this.ButtRendezVous.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.ButtRendezVous.Click += new System.EventHandler(this.ButtRendezVous_Click);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(122, 14);
            this.toolStripLabel5.Text = "Rendez-Vous";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(122, 6);
            // 
            // ButtClientAnimal
            // 
            this.ButtClientAnimal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButtClientAnimal.Image = global::IHMWindows.Properties.Resources.animal_chat_icone_4095_48;
            this.ButtClientAnimal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtClientAnimal.Name = "ButtClientAnimal";
            this.ButtClientAnimal.Size = new System.Drawing.Size(122, 44);
            this.ButtClientAnimal.Text = "Formulaire Clients/Animaux";
            this.ButtClientAnimal.Click += new System.EventHandler(this.ButtClientAnimal_Click);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(122, 14);
            this.toolStripLabel3.Text = "Dossier Client/Animaux";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(122, 6);
            // 
            // ButRelance
            // 
            this.ButRelance.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButRelance.Image = global::IHMWindows.Properties.Resources.brown_enveloppe_lettre_message_icone_5321_48;
            this.ButRelance.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButRelance.Name = "ButRelance";
            this.ButRelance.Size = new System.Drawing.Size(122, 44);
            this.ButRelance.Text = "Relances";
            this.ButRelance.Click += new System.EventHandler(this.ButRelance_Click);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(122, 14);
            this.toolStripLabel4.Text = "Relances";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(122, 6);
            // 
            // ButAgenda
            // 
            this.ButAgenda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButAgenda.Image = global::IHMWindows.Properties.Resources.evolution_calendrier_icone_5221_48;
            this.ButAgenda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButAgenda.Name = "ButAgenda";
            this.ButAgenda.Size = new System.Drawing.Size(122, 44);
            this.ButAgenda.Text = "Agenda";
            this.ButAgenda.Click += new System.EventHandler(this.ButAgenda_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(122, 14);
            this.toolStripLabel2.Text = "Agenda";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(122, 6);
            // 
            // ButDossierMedical
            // 
            this.ButDossierMedical.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ButDossierMedical.Image = global::IHMWindows.Properties.Resources.dossier_ouvrez_icone_6032_48;
            this.ButDossierMedical.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButDossierMedical.Name = "ButDossierMedical";
            this.ButDossierMedical.Size = new System.Drawing.Size(122, 44);
            this.ButDossierMedical.Text = "Dossier Médicaux";
            this.ButDossierMedical.Click += new System.EventHandler(this.ButDossierMedical_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(122, 14);
            this.toolStripLabel1.Text = "Dossier Médical";
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 871);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1200, 900);
            this.MinimumSize = new System.Drawing.Size(1200, 900);
            this.Name = "PrincipalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clinique Vétérinaire";
            this.Shown += new System.EventHandler(this.PrincipalForm_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem secrétariatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem priseDeRendezousToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dossierClientAnimauxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relancesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miseAJourDuStockDeVaccinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vétérinaireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dossiersMedicauxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paramétrageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vétérinairesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miseÀJourDuBarèmeDeTarificationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ButtRendezVous;
        private System.Windows.Forms.ToolStripButton ButtClientAnimal;
        private System.Windows.Forms.ToolStripButton ButRelance;
        private System.Windows.Forms.ToolStripButton ButAgenda;
        private System.Windows.Forms.ToolStripButton ButDossierMedical;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}