namespace IHMWindows
{
    partial class AnimalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnimalForm));
            this.GBoxNavigation = new System.Windows.Forms.GroupBox();
            this.butAnnuler = new System.Windows.Forms.Button();
            this.butValider = new System.Windows.Forms.Button();
            this.butDossierMed = new System.Windows.Forms.Button();
            this.GBoxClient = new System.Windows.Forms.GroupBox();
            this.txtClient = new System.Windows.Forms.TextBox();
            this.txtcode = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtCouleur = new System.Windows.Forms.TextBox();
            this.txtTatouage = new System.Windows.Forms.TextBox();
            this.comboBoxEspece = new System.Windows.Forms.ComboBox();
            this.comboBoxRace = new System.Windows.Forms.ComboBox();
            this.comboBoxSexe = new System.Windows.Forms.ComboBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblCouleur = new System.Windows.Forms.Label();
            this.lblEspece = new System.Windows.Forms.Label();
            this.lblRace = new System.Windows.Forms.Label();
            this.lblSexe = new System.Windows.Forms.Label();
            this.lblTatouage = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.GBoxNavigation.SuspendLayout();
            this.GBoxClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // GBoxNavigation
            // 
            this.GBoxNavigation.Controls.Add(this.butAnnuler);
            this.GBoxNavigation.Controls.Add(this.butValider);
            this.GBoxNavigation.Controls.Add(this.butDossierMed);
            this.GBoxNavigation.Location = new System.Drawing.Point(26, 12);
            this.GBoxNavigation.Name = "GBoxNavigation";
            this.GBoxNavigation.Size = new System.Drawing.Size(520, 76);
            this.GBoxNavigation.TabIndex = 0;
            this.GBoxNavigation.TabStop = false;
            this.GBoxNavigation.Text = "Navigation";
            // 
            // butAnnuler
            // 
            this.butAnnuler.Location = new System.Drawing.Point(378, 19);
            this.butAnnuler.Name = "butAnnuler";
            this.butAnnuler.Size = new System.Drawing.Size(119, 43);
            this.butAnnuler.TabIndex = 2;
            this.butAnnuler.Text = "Annuler";
            this.butAnnuler.UseVisualStyleBackColor = true;
            this.butAnnuler.Click += new System.EventHandler(this.butAnnuler_Click);
            // 
            // butValider
            // 
            this.butValider.Location = new System.Drawing.Point(237, 19);
            this.butValider.Name = "butValider";
            this.butValider.Size = new System.Drawing.Size(119, 43);
            this.butValider.TabIndex = 1;
            this.butValider.Text = "Valider";
            this.butValider.UseVisualStyleBackColor = true;
            this.butValider.Click += new System.EventHandler(this.butValider_Click);
            // 
            // butDossierMed
            // 
            this.butDossierMed.Location = new System.Drawing.Point(15, 19);
            this.butDossierMed.Name = "butDossierMed";
            this.butDossierMed.Size = new System.Drawing.Size(119, 43);
            this.butDossierMed.TabIndex = 0;
            this.butDossierMed.Text = "Dossier Médical";
            this.butDossierMed.UseVisualStyleBackColor = true;
            this.butDossierMed.Click += new System.EventHandler(this.butDossierMed_Click);
            // 
            // GBoxClient
            // 
            this.GBoxClient.Controls.Add(this.txtClient);
            this.GBoxClient.Location = new System.Drawing.Point(28, 104);
            this.GBoxClient.Name = "GBoxClient";
            this.GBoxClient.Size = new System.Drawing.Size(517, 53);
            this.GBoxClient.TabIndex = 1;
            this.GBoxClient.TabStop = false;
            this.GBoxClient.Text = "Informations Client :";
            // 
            // txtClient
            // 
            this.txtClient.Location = new System.Drawing.Point(13, 19);
            this.txtClient.Name = "txtClient";
            this.txtClient.ReadOnly = true;
            this.txtClient.Size = new System.Drawing.Size(479, 20);
            this.txtClient.TabIndex = 0;
            // 
            // txtcode
            // 
            this.txtcode.Location = new System.Drawing.Point(134, 174);
            this.txtcode.Name = "txtcode";
            this.txtcode.ReadOnly = true;
            this.txtcode.Size = new System.Drawing.Size(246, 20);
            this.txtcode.TabIndex = 2;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(134, 200);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(246, 20);
            this.txtNom.TabIndex = 3;
            // 
            // txtCouleur
            // 
            this.txtCouleur.Location = new System.Drawing.Point(134, 226);
            this.txtCouleur.Name = "txtCouleur";
            this.txtCouleur.Size = new System.Drawing.Size(246, 20);
            this.txtCouleur.TabIndex = 4;
            // 
            // txtTatouage
            // 
            this.txtTatouage.Location = new System.Drawing.Point(134, 334);
            this.txtTatouage.Name = "txtTatouage";
            this.txtTatouage.Size = new System.Drawing.Size(186, 20);
            this.txtTatouage.TabIndex = 5;
            // 
            // comboBoxEspece
            // 
            this.comboBoxEspece.FormattingEnabled = true;
            this.comboBoxEspece.Location = new System.Drawing.Point(133, 273);
            this.comboBoxEspece.Name = "comboBoxEspece";
            this.comboBoxEspece.Size = new System.Drawing.Size(91, 21);
            this.comboBoxEspece.TabIndex = 6;
            // 
            // comboBoxRace
            // 
            this.comboBoxRace.FormattingEnabled = true;
            this.comboBoxRace.Location = new System.Drawing.Point(288, 273);
            this.comboBoxRace.Name = "comboBoxRace";
            this.comboBoxRace.Size = new System.Drawing.Size(94, 21);
            this.comboBoxRace.TabIndex = 7;
            // 
            // comboBoxSexe
            // 
            this.comboBoxSexe.FormattingEnabled = true;
            this.comboBoxSexe.Location = new System.Drawing.Point(441, 199);
            this.comboBoxSexe.Name = "comboBoxSexe";
            this.comboBoxSexe.Size = new System.Drawing.Size(82, 21);
            this.comboBoxSexe.TabIndex = 8;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(53, 177);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(72, 13);
            this.lblCode.TabIndex = 9;
            this.lblCode.Text = "Code Animal :";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(53, 202);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(35, 13);
            this.lblNom.TabIndex = 10;
            this.lblNom.Text = "Nom :";
            // 
            // lblCouleur
            // 
            this.lblCouleur.AutoSize = true;
            this.lblCouleur.Location = new System.Drawing.Point(53, 229);
            this.lblCouleur.Name = "lblCouleur";
            this.lblCouleur.Size = new System.Drawing.Size(49, 13);
            this.lblCouleur.TabIndex = 11;
            this.lblCouleur.Text = "Couleur :";
            // 
            // lblEspece
            // 
            this.lblEspece.AutoSize = true;
            this.lblEspece.Location = new System.Drawing.Point(55, 276);
            this.lblEspece.Name = "lblEspece";
            this.lblEspece.Size = new System.Drawing.Size(49, 13);
            this.lblEspece.TabIndex = 12;
            this.lblEspece.Text = "Espèce :";
            // 
            // lblRace
            // 
            this.lblRace.AutoSize = true;
            this.lblRace.Location = new System.Drawing.Point(240, 276);
            this.lblRace.Name = "lblRace";
            this.lblRace.Size = new System.Drawing.Size(42, 13);
            this.lblRace.TabIndex = 13;
            this.lblRace.Text = "Race  :";
            // 
            // lblSexe
            // 
            this.lblSexe.AutoSize = true;
            this.lblSexe.Location = new System.Drawing.Point(401, 203);
            this.lblSexe.Name = "lblSexe";
            this.lblSexe.Size = new System.Drawing.Size(37, 13);
            this.lblSexe.TabIndex = 14;
            this.lblSexe.Text = "Sexe :";
            // 
            // lblTatouage
            // 
            this.lblTatouage.AutoSize = true;
            this.lblTatouage.Location = new System.Drawing.Point(56, 337);
            this.lblTatouage.Name = "lblTatouage";
            this.lblTatouage.Size = new System.Drawing.Size(59, 13);
            this.lblTatouage.TabIndex = 15;
            this.lblTatouage.Text = "Tatouage :";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AnimalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(574, 366);
            this.Controls.Add(this.lblTatouage);
            this.Controls.Add(this.lblSexe);
            this.Controls.Add(this.lblRace);
            this.Controls.Add(this.lblEspece);
            this.Controls.Add(this.lblCouleur);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.comboBoxSexe);
            this.Controls.Add(this.comboBoxRace);
            this.Controls.Add(this.comboBoxEspece);
            this.Controls.Add(this.txtTatouage);
            this.Controls.Add(this.txtCouleur);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtcode);
            this.Controls.Add(this.GBoxClient);
            this.Controls.Add(this.GBoxNavigation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AnimalForm";
            this.Text = "Formulaire Animal";
            this.GBoxNavigation.ResumeLayout(false);
            this.GBoxClient.ResumeLayout(false);
            this.GBoxClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GBoxNavigation;
        private System.Windows.Forms.Button butAnnuler;
        private System.Windows.Forms.Button butValider;
        private System.Windows.Forms.Button butDossierMed;
        private System.Windows.Forms.GroupBox GBoxClient;
        private System.Windows.Forms.TextBox txtClient;
        private System.Windows.Forms.TextBox txtcode;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtCouleur;
        private System.Windows.Forms.TextBox txtTatouage;
        private System.Windows.Forms.ComboBox comboBoxEspece;
        private System.Windows.Forms.ComboBox comboBoxRace;
        private System.Windows.Forms.ComboBox comboBoxSexe;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblCouleur;
        private System.Windows.Forms.Label lblEspece;
        private System.Windows.Forms.Label lblRace;
        private System.Windows.Forms.Label lblSexe;
        private System.Windows.Forms.Label lblTatouage;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}