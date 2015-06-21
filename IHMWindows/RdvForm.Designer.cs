namespace IHMWindows
{
    partial class RdvForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RdvForm));
            this.gbxPour = new System.Windows.Forms.GroupBox();
            this.btnAjoutAnimal = new System.Windows.Forms.Button();
            this.btnAjoutClient = new System.Windows.Forms.Button();
            this.cbxAnimal = new System.Windows.Forms.ComboBox();
            this.lblAnimal = new System.Windows.Forms.Label();
            this.cbxClient = new System.Windows.Forms.ComboBox();
            this.lblClient = new System.Windows.Forms.Label();
            this.gbxPar = new System.Windows.Forms.GroupBox();
            this.cbxVeterinaire = new System.Windows.Forms.ComboBox();
            this.lblVeterinaire = new System.Windows.Forms.Label();
            this.gbxQuand = new System.Windows.Forms.GroupBox();
            this.lblUrgence = new System.Windows.Forms.Label();
            this.btnUrgence = new System.Windows.Forms.Button();
            this.lblH = new System.Windows.Forms.Label();
            this.cbxMinutes = new System.Windows.Forms.ComboBox();
            this.cbxHeures = new System.Windows.Forms.ComboBox();
            this.lblHeure = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpRdv = new System.Windows.Forms.DateTimePicker();
            this.dgvRdv = new System.Windows.Forms.DataGridView();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.gbxPour.SuspendLayout();
            this.gbxPar.SuspendLayout();
            this.gbxQuand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRdv)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxPour
            // 
            this.gbxPour.Controls.Add(this.btnAjoutAnimal);
            this.gbxPour.Controls.Add(this.btnAjoutClient);
            this.gbxPour.Controls.Add(this.cbxAnimal);
            this.gbxPour.Controls.Add(this.lblAnimal);
            this.gbxPour.Controls.Add(this.cbxClient);
            this.gbxPour.Controls.Add(this.lblClient);
            this.gbxPour.Location = new System.Drawing.Point(10, 11);
            this.gbxPour.Name = "gbxPour";
            this.gbxPour.Size = new System.Drawing.Size(262, 129);
            this.gbxPour.TabIndex = 1;
            this.gbxPour.TabStop = false;
            this.gbxPour.Text = "Pour";
            // 
            // btnAjoutAnimal
            // 
            this.btnAjoutAnimal.Image = global::IHMWindows.Properties.Resources.ajouter;
            this.btnAjoutAnimal.Location = new System.Drawing.Point(222, 88);
            this.btnAjoutAnimal.Margin = new System.Windows.Forms.Padding(2);
            this.btnAjoutAnimal.Name = "btnAjoutAnimal";
            this.btnAjoutAnimal.Size = new System.Drawing.Size(34, 32);
            this.btnAjoutAnimal.TabIndex = 5;
            this.btnAjoutAnimal.UseVisualStyleBackColor = true;
            this.btnAjoutAnimal.Click += new System.EventHandler(this.btnAjoutAnimal_Click);
            // 
            // btnAjoutClient
            // 
            this.btnAjoutClient.Image = global::IHMWindows.Properties.Resources.ajouter;
            this.btnAjoutClient.Location = new System.Drawing.Point(222, 32);
            this.btnAjoutClient.Margin = new System.Windows.Forms.Padding(2);
            this.btnAjoutClient.Name = "btnAjoutClient";
            this.btnAjoutClient.Size = new System.Drawing.Size(34, 32);
            this.btnAjoutClient.TabIndex = 4;
            this.btnAjoutClient.UseVisualStyleBackColor = true;
            this.btnAjoutClient.Click += new System.EventHandler(this.btnAjoutClient_Click);
            // 
            // cbxAnimal
            // 
            this.cbxAnimal.FormattingEnabled = true;
            this.cbxAnimal.Location = new System.Drawing.Point(26, 95);
            this.cbxAnimal.Name = "cbxAnimal";
            this.cbxAnimal.Size = new System.Drawing.Size(192, 21);
            this.cbxAnimal.TabIndex = 3;
            // 
            // lblAnimal
            // 
            this.lblAnimal.AutoSize = true;
            this.lblAnimal.Location = new System.Drawing.Point(23, 78);
            this.lblAnimal.Name = "lblAnimal";
            this.lblAnimal.Size = new System.Drawing.Size(38, 13);
            this.lblAnimal.TabIndex = 2;
            this.lblAnimal.Text = "Animal";
            // 
            // cbxClient
            // 
            this.cbxClient.FormattingEnabled = true;
            this.cbxClient.Location = new System.Drawing.Point(26, 41);
            this.cbxClient.Name = "cbxClient";
            this.cbxClient.Size = new System.Drawing.Size(192, 21);
            this.cbxClient.TabIndex = 1;
            this.cbxClient.SelectedIndexChanged += new System.EventHandler(this.cbxClient_SelectedIndexChanged);
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Location = new System.Drawing.Point(23, 20);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(33, 13);
            this.lblClient.TabIndex = 0;
            this.lblClient.Text = "Client";
            // 
            // gbxPar
            // 
            this.gbxPar.Controls.Add(this.cbxVeterinaire);
            this.gbxPar.Controls.Add(this.lblVeterinaire);
            this.gbxPar.Location = new System.Drawing.Point(278, 11);
            this.gbxPar.Name = "gbxPar";
            this.gbxPar.Size = new System.Drawing.Size(238, 129);
            this.gbxPar.TabIndex = 2;
            this.gbxPar.TabStop = false;
            this.gbxPar.Text = "Par";
            // 
            // cbxVeterinaire
            // 
            this.cbxVeterinaire.FormattingEnabled = true;
            this.cbxVeterinaire.Location = new System.Drawing.Point(25, 41);
            this.cbxVeterinaire.Name = "cbxVeterinaire";
            this.cbxVeterinaire.Size = new System.Drawing.Size(192, 21);
            this.cbxVeterinaire.TabIndex = 3;
            this.cbxVeterinaire.SelectedIndexChanged += new System.EventHandler(this.SelectionVeterinaireOuDate);
            // 
            // lblVeterinaire
            // 
            this.lblVeterinaire.AutoSize = true;
            this.lblVeterinaire.Location = new System.Drawing.Point(22, 20);
            this.lblVeterinaire.Name = "lblVeterinaire";
            this.lblVeterinaire.Size = new System.Drawing.Size(57, 13);
            this.lblVeterinaire.TabIndex = 0;
            this.lblVeterinaire.Text = "Vétérinaire";
            // 
            // gbxQuand
            // 
            this.gbxQuand.Controls.Add(this.lblUrgence);
            this.gbxQuand.Controls.Add(this.btnUrgence);
            this.gbxQuand.Controls.Add(this.lblH);
            this.gbxQuand.Controls.Add(this.cbxMinutes);
            this.gbxQuand.Controls.Add(this.cbxHeures);
            this.gbxQuand.Controls.Add(this.lblHeure);
            this.gbxQuand.Controls.Add(this.lblDate);
            this.gbxQuand.Controls.Add(this.dtpRdv);
            this.gbxQuand.Location = new System.Drawing.Point(542, 11);
            this.gbxQuand.Name = "gbxQuand";
            this.gbxQuand.Size = new System.Drawing.Size(247, 129);
            this.gbxQuand.TabIndex = 3;
            this.gbxQuand.TabStop = false;
            this.gbxQuand.Text = "Quand";
            // 
            // lblUrgence
            // 
            this.lblUrgence.AutoSize = true;
            this.lblUrgence.Location = new System.Drawing.Point(164, 106);
            this.lblUrgence.Name = "lblUrgence";
            this.lblUrgence.Size = new System.Drawing.Size(48, 13);
            this.lblUrgence.TabIndex = 8;
            this.lblUrgence.Text = "Urgence";
            // 
            // btnUrgence
            // 
            this.btnUrgence.Image = ((System.Drawing.Image)(resources.GetObject("btnUrgence.Image")));
            this.btnUrgence.Location = new System.Drawing.Point(166, 68);
            this.btnUrgence.Margin = new System.Windows.Forms.Padding(2);
            this.btnUrgence.Name = "btnUrgence";
            this.btnUrgence.Size = new System.Drawing.Size(34, 32);
            this.btnUrgence.TabIndex = 6;
            this.btnUrgence.UseVisualStyleBackColor = true;
            this.btnUrgence.Click += new System.EventHandler(this.btnUrgence_Click);
            // 
            // lblH
            // 
            this.lblH.AutoSize = true;
            this.lblH.Location = new System.Drawing.Point(62, 98);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(13, 13);
            this.lblH.TabIndex = 7;
            this.lblH.Text = "h";
            // 
            // cbxMinutes
            // 
            this.cbxMinutes.FormattingEnabled = true;
            this.cbxMinutes.Location = new System.Drawing.Point(80, 95);
            this.cbxMinutes.Name = "cbxMinutes";
            this.cbxMinutes.Size = new System.Drawing.Size(36, 21);
            this.cbxMinutes.TabIndex = 6;
            // 
            // cbxHeures
            // 
            this.cbxHeures.FormattingEnabled = true;
            this.cbxHeures.Location = new System.Drawing.Point(22, 95);
            this.cbxHeures.Name = "cbxHeures";
            this.cbxHeures.Size = new System.Drawing.Size(34, 21);
            this.cbxHeures.TabIndex = 4;
            // 
            // lblHeure
            // 
            this.lblHeure.AutoSize = true;
            this.lblHeure.Location = new System.Drawing.Point(20, 78);
            this.lblHeure.Name = "lblHeure";
            this.lblHeure.Size = new System.Drawing.Size(36, 13);
            this.lblHeure.TabIndex = 5;
            this.lblHeure.Text = "Heure";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(20, 22);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Date";
            // 
            // dtpRdv
            // 
            this.dtpRdv.Location = new System.Drawing.Point(22, 42);
            this.dtpRdv.Name = "dtpRdv";
            this.dtpRdv.Size = new System.Drawing.Size(200, 20);
            this.dtpRdv.TabIndex = 2;
            this.dtpRdv.ValueChanged += new System.EventHandler(this.SelectionVeterinaireOuDate);
            // 
            // dgvRdv
            // 
            this.dgvRdv.AllowUserToAddRows = false;
            this.dgvRdv.AllowUserToDeleteRows = false;
            this.dgvRdv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRdv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRdv.Location = new System.Drawing.Point(10, 155);
            this.dgvRdv.Name = "dgvRdv";
            this.dgvRdv.ReadOnly = true;
            this.dgvRdv.Size = new System.Drawing.Size(778, 337);
            this.dgvRdv.TabIndex = 4;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnnuler.Image = global::IHMWindows.Properties.Resources.annuler;
            this.btnAnnuler.Location = new System.Drawing.Point(696, 499);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(92, 37);
            this.btnAnnuler.TabIndex = 21;
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnValider
            // 
            this.btnValider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnValider.Image = global::IHMWindows.Properties.Resources.valider;
            this.btnValider.Location = new System.Drawing.Point(597, 499);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(92, 37);
            this.btnValider.TabIndex = 20;
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSupprimer.Image = global::IHMWindows.Properties.Resources.supprimer;
            this.btnSupprimer.Location = new System.Drawing.Point(498, 499);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(92, 37);
            this.btnSupprimer.TabIndex = 22;
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // RdvForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 547);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.dgvRdv);
            this.Controls.Add(this.gbxQuand);
            this.Controls.Add(this.gbxPar);
            this.Controls.Add(this.gbxPour);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RdvForm";
            this.Text = "Prise de rendez-vous";
            this.Load += new System.EventHandler(this.RdvForm_Load);
            this.gbxPour.ResumeLayout(false);
            this.gbxPour.PerformLayout();
            this.gbxPar.ResumeLayout(false);
            this.gbxPar.PerformLayout();
            this.gbxQuand.ResumeLayout(false);
            this.gbxQuand.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRdv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxPour;
        private System.Windows.Forms.ComboBox cbxClient;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.GroupBox gbxPar;
        private System.Windows.Forms.Label lblVeterinaire;
        private System.Windows.Forms.GroupBox gbxQuand;
        private System.Windows.Forms.DateTimePicker dtpRdv;
        private System.Windows.Forms.Label lblAnimal;
        private System.Windows.Forms.ComboBox cbxAnimal;
        private System.Windows.Forms.ComboBox cbxVeterinaire;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnAjoutAnimal;
        private System.Windows.Forms.Button btnAjoutClient;
        private System.Windows.Forms.Label lblH;
        private System.Windows.Forms.ComboBox cbxMinutes;
        private System.Windows.Forms.ComboBox cbxHeures;
        private System.Windows.Forms.Label lblHeure;
        private System.Windows.Forms.Label lblUrgence;
        private System.Windows.Forms.Button btnUrgence;
        private System.Windows.Forms.DataGridView dgvRdv;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnSupprimer;
    }
}