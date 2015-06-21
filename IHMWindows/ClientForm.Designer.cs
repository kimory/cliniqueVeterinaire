namespace IHMWindows
{
    partial class ClientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientForm));
            this.pnlBoutons = new System.Windows.Forms.Panel();
            this.cbxRechercher = new System.Windows.Forms.CheckBox();
            this.tbxRechercher = new System.Windows.Forms.TextBox();
            this.btnSupprimerClient = new System.Windows.Forms.Button();
            this.btnAjouterClient = new System.Windows.Forms.Button();
            this.btnDernier = new System.Windows.Forms.Button();
            this.btnSuivant = new System.Windows.Forms.Button();
            this.btnPrecedent = new System.Windows.Forms.Button();
            this.btnPremier = new System.Windows.Forms.Button();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblVille = new System.Windows.Forms.Label();
            this.lblCodePostal = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.tbxCode = new System.Windows.Forms.TextBox();
            this.tbxNom = new System.Windows.Forms.TextBox();
            this.tbxPrenom = new System.Windows.Forms.TextBox();
            this.tbxAdresse1 = new System.Windows.Forms.TextBox();
            this.tbxCodePostal = new System.Windows.Forms.TextBox();
            this.tbxVille = new System.Windows.Forms.TextBox();
            this.btnEditerAnimal = new System.Windows.Forms.Button();
            this.dgvAnimaux = new System.Windows.Forms.DataGridView();
            this.tbxAdresse2 = new System.Windows.Forms.TextBox();
            this.btnAnnulerAjout = new System.Windows.Forms.Button();
            this.btnValiderAjout = new System.Windows.Forms.Button();
            this.btnSupprimerAnimal = new System.Windows.Forms.Button();
            this.btnAjouterAnimal = new System.Windows.Forms.Button();
            this.erpClients = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlBoutons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimaux)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpClients)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBoutons
            // 
            this.pnlBoutons.Controls.Add(this.cbxRechercher);
            this.pnlBoutons.Controls.Add(this.tbxRechercher);
            this.pnlBoutons.Controls.Add(this.btnSupprimerClient);
            this.pnlBoutons.Controls.Add(this.btnAjouterClient);
            this.pnlBoutons.Controls.Add(this.btnDernier);
            this.pnlBoutons.Controls.Add(this.btnSuivant);
            this.pnlBoutons.Controls.Add(this.btnPrecedent);
            this.pnlBoutons.Controls.Add(this.btnPremier);
            this.pnlBoutons.Location = new System.Drawing.Point(8, 3);
            this.pnlBoutons.Name = "pnlBoutons";
            this.pnlBoutons.Size = new System.Drawing.Size(709, 43);
            this.pnlBoutons.TabIndex = 0;
            // 
            // cbxRechercher
            // 
            this.cbxRechercher.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbxRechercher.AutoSize = true;
            this.cbxRechercher.Image = global::IHMWindows.Properties.Resources.rechercher;
            this.cbxRechercher.Location = new System.Drawing.Point(493, 2);
            this.cbxRechercher.Name = "cbxRechercher";
            this.cbxRechercher.Size = new System.Drawing.Size(38, 38);
            this.cbxRechercher.TabIndex = 5;
            this.cbxRechercher.UseVisualStyleBackColor = true;
            this.cbxRechercher.CheckedChanged += new System.EventHandler(this.cbxRechercher_CheckedChanged);
            // 
            // tbxRechercher
            // 
            this.tbxRechercher.Location = new System.Drawing.Point(537, 12);
            this.tbxRechercher.Name = "tbxRechercher";
            this.tbxRechercher.Size = new System.Drawing.Size(169, 20);
            this.tbxRechercher.TabIndex = 4;
            // 
            // btnSupprimerClient
            // 
            this.btnSupprimerClient.Image = global::IHMWindows.Properties.Resources.supprimer;
            this.btnSupprimerClient.Location = new System.Drawing.Point(426, 2);
            this.btnSupprimerClient.Name = "btnSupprimerClient";
            this.btnSupprimerClient.Size = new System.Drawing.Size(45, 37);
            this.btnSupprimerClient.TabIndex = 2;
            this.btnSupprimerClient.UseVisualStyleBackColor = true;
            this.btnSupprimerClient.Click += new System.EventHandler(this.btnSupprimerClient_Click);
            // 
            // btnAjouterClient
            // 
            this.btnAjouterClient.Image = global::IHMWindows.Properties.Resources.ajouter;
            this.btnAjouterClient.Location = new System.Drawing.Point(374, 3);
            this.btnAjouterClient.Name = "btnAjouterClient";
            this.btnAjouterClient.Size = new System.Drawing.Size(46, 37);
            this.btnAjouterClient.TabIndex = 3;
            this.btnAjouterClient.UseVisualStyleBackColor = true;
            this.btnAjouterClient.Click += new System.EventHandler(this.btnAjouterClient_Click);
            // 
            // btnDernier
            // 
            this.btnDernier.Image = global::IHMWindows.Properties.Resources.dernier;
            this.btnDernier.Location = new System.Drawing.Point(186, 3);
            this.btnDernier.Name = "btnDernier";
            this.btnDernier.Size = new System.Drawing.Size(55, 37);
            this.btnDernier.TabIndex = 1;
            this.btnDernier.UseVisualStyleBackColor = true;
            this.btnDernier.Click += new System.EventHandler(this.btnDernier_Click);
            // 
            // btnSuivant
            // 
            this.btnSuivant.Image = global::IHMWindows.Properties.Resources.suivant;
            this.btnSuivant.Location = new System.Drawing.Point(125, 3);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(55, 37);
            this.btnSuivant.TabIndex = 2;
            this.btnSuivant.UseVisualStyleBackColor = true;
            this.btnSuivant.Click += new System.EventHandler(this.btnSuivant_Click);
            // 
            // btnPrecedent
            // 
            this.btnPrecedent.Image = global::IHMWindows.Properties.Resources.precedent;
            this.btnPrecedent.Location = new System.Drawing.Point(64, 3);
            this.btnPrecedent.Name = "btnPrecedent";
            this.btnPrecedent.Size = new System.Drawing.Size(55, 37);
            this.btnPrecedent.TabIndex = 3;
            this.btnPrecedent.UseVisualStyleBackColor = true;
            this.btnPrecedent.Click += new System.EventHandler(this.btnPrecedent_Click);
            // 
            // btnPremier
            // 
            this.btnPremier.Image = global::IHMWindows.Properties.Resources.premier;
            this.btnPremier.Location = new System.Drawing.Point(3, 3);
            this.btnPremier.Name = "btnPremier";
            this.btnPremier.Size = new System.Drawing.Size(55, 37);
            this.btnPremier.TabIndex = 0;
            this.btnPremier.UseVisualStyleBackColor = true;
            this.btnPremier.Click += new System.EventHandler(this.btnPremier_Click);
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(42, 40);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(32, 13);
            this.lblCode.TabIndex = 1;
            this.lblCode.Text = "Code";
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Location = new System.Drawing.Point(48, 247);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(26, 13);
            this.lblVille.TabIndex = 2;
            this.lblVille.Text = "Ville";
            // 
            // lblCodePostal
            // 
            this.lblCodePostal.AutoSize = true;
            this.lblCodePostal.Location = new System.Drawing.Point(13, 216);
            this.lblCodePostal.Name = "lblCodePostal";
            this.lblCodePostal.Size = new System.Drawing.Size(63, 13);
            this.lblCodePostal.TabIndex = 3;
            this.lblCodePostal.Text = "Code postal";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(33, 119);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(43, 13);
            this.lblPrenom.TabIndex = 4;
            this.lblPrenom.Text = "Prénom";
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Location = new System.Drawing.Point(31, 154);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(45, 13);
            this.lblAdresse.TabIndex = 5;
            this.lblAdresse.Text = "Adresse";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(45, 78);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(29, 13);
            this.lblNom.TabIndex = 6;
            this.lblNom.Text = "Nom";
            // 
            // tbxCode
            // 
            this.tbxCode.Location = new System.Drawing.Point(80, 37);
            this.tbxCode.Name = "tbxCode";
            this.tbxCode.Size = new System.Drawing.Size(157, 20);
            this.tbxCode.TabIndex = 7;
            // 
            // tbxNom
            // 
            this.tbxNom.Location = new System.Drawing.Point(80, 78);
            this.tbxNom.Name = "tbxNom";
            this.tbxNom.Size = new System.Drawing.Size(157, 20);
            this.tbxNom.TabIndex = 8;
            // 
            // tbxPrenom
            // 
            this.tbxPrenom.Location = new System.Drawing.Point(80, 119);
            this.tbxPrenom.Name = "tbxPrenom";
            this.tbxPrenom.Size = new System.Drawing.Size(157, 20);
            this.tbxPrenom.TabIndex = 9;
            // 
            // tbxAdresse1
            // 
            this.tbxAdresse1.Location = new System.Drawing.Point(80, 154);
            this.tbxAdresse1.Name = "tbxAdresse1";
            this.tbxAdresse1.Size = new System.Drawing.Size(157, 20);
            this.tbxAdresse1.TabIndex = 10;
            // 
            // tbxCodePostal
            // 
            this.tbxCodePostal.Location = new System.Drawing.Point(80, 213);
            this.tbxCodePostal.Name = "tbxCodePostal";
            this.tbxCodePostal.Size = new System.Drawing.Size(157, 20);
            this.tbxCodePostal.TabIndex = 11;
            // 
            // tbxVille
            // 
            this.tbxVille.Location = new System.Drawing.Point(80, 247);
            this.tbxVille.Name = "tbxVille";
            this.tbxVille.Size = new System.Drawing.Size(157, 20);
            this.tbxVille.TabIndex = 12;
            // 
            // btnEditerAnimal
            // 
            this.btnEditerAnimal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditerAnimal.Location = new System.Drawing.Point(656, 342);
            this.btnEditerAnimal.Name = "btnEditerAnimal";
            this.btnEditerAnimal.Size = new System.Drawing.Size(55, 37);
            this.btnEditerAnimal.TabIndex = 15;
            this.btnEditerAnimal.Text = "Modifier";
            this.btnEditerAnimal.UseVisualStyleBackColor = true;
            this.btnEditerAnimal.Click += new System.EventHandler(this.btnEditerAnimal_Click);
            // 
            // dgvAnimaux
            // 
            this.dgvAnimaux.AllowUserToAddRows = false;
            this.dgvAnimaux.AllowUserToDeleteRows = false;
            this.dgvAnimaux.AllowUserToOrderColumns = true;
            this.dgvAnimaux.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAnimaux.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvAnimaux.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnimaux.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvAnimaux.GridColor = System.Drawing.SystemColors.ControlText;
            this.dgvAnimaux.Location = new System.Drawing.Point(281, 53);
            this.dgvAnimaux.Name = "dgvAnimaux";
            this.dgvAnimaux.ReadOnly = true;
            this.dgvAnimaux.Size = new System.Drawing.Size(429, 283);
            this.dgvAnimaux.TabIndex = 16;
            // 
            // tbxAdresse2
            // 
            this.tbxAdresse2.Location = new System.Drawing.Point(80, 180);
            this.tbxAdresse2.Name = "tbxAdresse2";
            this.tbxAdresse2.Size = new System.Drawing.Size(157, 20);
            this.tbxAdresse2.TabIndex = 17;
            // 
            // btnAnnulerAjout
            // 
            this.btnAnnulerAjout.Image = global::IHMWindows.Properties.Resources.annuler;
            this.btnAnnulerAjout.Location = new System.Drawing.Point(154, 344);
            this.btnAnnulerAjout.Name = "btnAnnulerAjout";
            this.btnAnnulerAjout.Size = new System.Drawing.Size(44, 37);
            this.btnAnnulerAjout.TabIndex = 19;
            this.btnAnnulerAjout.UseVisualStyleBackColor = true;
            this.btnAnnulerAjout.Visible = false;
            this.btnAnnulerAjout.Click += new System.EventHandler(this.btnAnnulerAjout_Click);
            // 
            // btnValiderAjout
            // 
            this.btnValiderAjout.Image = global::IHMWindows.Properties.Resources.valider;
            this.btnValiderAjout.Location = new System.Drawing.Point(109, 344);
            this.btnValiderAjout.Name = "btnValiderAjout";
            this.btnValiderAjout.Size = new System.Drawing.Size(39, 37);
            this.btnValiderAjout.TabIndex = 18;
            this.btnValiderAjout.UseVisualStyleBackColor = true;
            this.btnValiderAjout.Visible = false;
            this.btnValiderAjout.Click += new System.EventHandler(this.btnValiderAjout_Click);
            // 
            // btnSupprimerAnimal
            // 
            this.btnSupprimerAnimal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSupprimerAnimal.Image = global::IHMWindows.Properties.Resources.supprimer;
            this.btnSupprimerAnimal.Location = new System.Drawing.Point(608, 342);
            this.btnSupprimerAnimal.Name = "btnSupprimerAnimal";
            this.btnSupprimerAnimal.Size = new System.Drawing.Size(42, 37);
            this.btnSupprimerAnimal.TabIndex = 14;
            this.btnSupprimerAnimal.UseVisualStyleBackColor = true;
            this.btnSupprimerAnimal.Click += new System.EventHandler(this.btnSupprimerAnimal_Click);
            // 
            // btnAjouterAnimal
            // 
            this.btnAjouterAnimal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAjouterAnimal.Image = global::IHMWindows.Properties.Resources.ajouter;
            this.btnAjouterAnimal.Location = new System.Drawing.Point(559, 342);
            this.btnAjouterAnimal.Name = "btnAjouterAnimal";
            this.btnAjouterAnimal.Size = new System.Drawing.Size(43, 37);
            this.btnAjouterAnimal.TabIndex = 6;
            this.btnAjouterAnimal.UseVisualStyleBackColor = true;
            this.btnAjouterAnimal.Click += new System.EventHandler(this.btnAjouterAnimal_Click);
            // 
            // erpClients
            // 
            this.erpClients.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNom);
            this.groupBox1.Controls.Add(this.lblAdresse);
            this.groupBox1.Controls.Add(this.lblPrenom);
            this.groupBox1.Controls.Add(this.tbxAdresse2);
            this.groupBox1.Controls.Add(this.lblCodePostal);
            this.groupBox1.Controls.Add(this.lblVille);
            this.groupBox1.Controls.Add(this.lblCode);
            this.groupBox1.Controls.Add(this.tbxCode);
            this.groupBox1.Controls.Add(this.tbxNom);
            this.groupBox1.Controls.Add(this.tbxVille);
            this.groupBox1.Controls.Add(this.tbxPrenom);
            this.groupBox1.Controls.Add(this.tbxCodePostal);
            this.groupBox1.Controls.Add(this.tbxAdresse1);
            this.groupBox1.Location = new System.Drawing.Point(8, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 285);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informations Client :";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 404);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAnnulerAjout);
            this.Controls.Add(this.dgvAnimaux);
            this.Controls.Add(this.btnEditerAnimal);
            this.Controls.Add(this.btnValiderAjout);
            this.Controls.Add(this.btnSupprimerAnimal);
            this.Controls.Add(this.btnAjouterAnimal);
            this.Controls.Add(this.pnlBoutons);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClientForm";
            this.Text = "Clients";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.pnlBoutons.ResumeLayout(false);
            this.pnlBoutons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimaux)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpClients)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBoutons;
        private System.Windows.Forms.Button btnDernier;
        private System.Windows.Forms.Button btnSuivant;
        private System.Windows.Forms.Button btnPrecedent;
        private System.Windows.Forms.Button btnPremier;
        private System.Windows.Forms.CheckBox cbxRechercher;
        private System.Windows.Forms.TextBox tbxRechercher;
        private System.Windows.Forms.Button btnSupprimerClient;
        private System.Windows.Forms.Button btnAjouterClient;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.Label lblCodePostal;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox tbxCode;
        private System.Windows.Forms.TextBox tbxNom;
        private System.Windows.Forms.TextBox tbxPrenom;
        private System.Windows.Forms.TextBox tbxAdresse1;
        private System.Windows.Forms.TextBox tbxCodePostal;
        private System.Windows.Forms.TextBox tbxVille;
        private System.Windows.Forms.Button btnAjouterAnimal;
        private System.Windows.Forms.Button btnSupprimerAnimal;
        private System.Windows.Forms.Button btnEditerAnimal;
        private System.Windows.Forms.DataGridView dgvAnimaux;
        private System.Windows.Forms.TextBox tbxAdresse2;
        private System.Windows.Forms.Button btnValiderAjout;
        private System.Windows.Forms.Button btnAnnulerAjout;
        private System.Windows.Forms.ErrorProvider erpClients;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}