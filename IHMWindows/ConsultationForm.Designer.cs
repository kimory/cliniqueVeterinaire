namespace IHMWindows
{
    partial class ConsultationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultationForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.butenregistrer = new System.Windows.Forms.Button();
            this.butAnnuler = new System.Windows.Forms.Button();
            this.butValider = new System.Windows.Forms.Button();
            this.butDossierMedical = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.butTatouage = new System.Windows.Forms.Button();
            this.lblSEX = new System.Windows.Forms.Label();
            this.lblCouleur = new System.Windows.Forms.Label();
            this.lblRace = new System.Windows.Forms.Label();
            this.lblTatouage = new System.Windows.Forms.Label();
            this.lblEspèce = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.txtCouleur = new System.Windows.Forms.TextBox();
            this.txtsexe = new System.Windows.Forms.TextBox();
            this.txtRace = new System.Windows.Forms.TextBox();
            this.txtTatouage = new System.Windows.Forms.TextBox();
            this.textEspece = new System.Windows.Forms.TextBox();
            this.textNom = new System.Windows.Forms.TextBox();
            this.textCode = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.butAnnul = new System.Windows.Forms.Button();
            this.ButAjouterActe = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl = new System.Windows.Forms.Label();
            this.lblMaxi = new System.Windows.Forms.Label();
            this.lblMini = new System.Windows.Forms.Label();
            this.textBoxPrix = new System.Windows.Forms.TextBox();
            this.textBoxMaxi = new System.Windows.Forms.TextBox();
            this.textBoxMini = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lbllibelle = new System.Windows.Forms.Label();
            this.comboBoxLibelle = new System.Windows.Forms.ComboBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblVeto = new System.Windows.Forms.Label();
            this.txtVeto = new System.Windows.Forms.TextBox();
            this.dGVListeActes = new System.Windows.Forms.DataGridView();
            this.lblCommentaire = new System.Windows.Forms.Label();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVListeActes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.butenregistrer);
            this.groupBox1.Controls.Add(this.butAnnuler);
            this.groupBox1.Controls.Add(this.butValider);
            this.groupBox1.Controls.Add(this.butDossierMedical);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(682, 77);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // butenregistrer
            // 
            this.butenregistrer.Enabled = false;
            this.butenregistrer.Location = new System.Drawing.Point(512, 19);
            this.butenregistrer.Name = "butenregistrer";
            this.butenregistrer.Size = new System.Drawing.Size(66, 39);
            this.butenregistrer.TabIndex = 3;
            this.butenregistrer.Text = "Enregistrer";
            this.butenregistrer.UseVisualStyleBackColor = true;
            // 
            // butAnnuler
            // 
            this.butAnnuler.Location = new System.Drawing.Point(598, 19);
            this.butAnnuler.Name = "butAnnuler";
            this.butAnnuler.Size = new System.Drawing.Size(66, 39);
            this.butAnnuler.TabIndex = 2;
            this.butAnnuler.Text = "Annuler";
            this.butAnnuler.UseVisualStyleBackColor = true;
            this.butAnnuler.Click += new System.EventHandler(this.butAnnuler_Click);
            // 
            // butValider
            // 
            this.butValider.Location = new System.Drawing.Point(402, 19);
            this.butValider.Name = "butValider";
            this.butValider.Size = new System.Drawing.Size(88, 39);
            this.butValider.TabIndex = 1;
            this.butValider.Text = "Valider la consultation";
            this.butValider.UseVisualStyleBackColor = true;
            this.butValider.Click += new System.EventHandler(this.butValider_Click);
            // 
            // butDossierMedical
            // 
            this.butDossierMedical.Location = new System.Drawing.Point(21, 19);
            this.butDossierMedical.Name = "butDossierMedical";
            this.butDossierMedical.Size = new System.Drawing.Size(104, 39);
            this.butDossierMedical.TabIndex = 0;
            this.butDossierMedical.Text = "Dossier Medical";
            this.butDossierMedical.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.butTatouage);
            this.groupBox2.Controls.Add(this.lblSEX);
            this.groupBox2.Controls.Add(this.lblCouleur);
            this.groupBox2.Controls.Add(this.lblRace);
            this.groupBox2.Controls.Add(this.lblTatouage);
            this.groupBox2.Controls.Add(this.lblEspèce);
            this.groupBox2.Controls.Add(this.lblNom);
            this.groupBox2.Controls.Add(this.lblCode);
            this.groupBox2.Controls.Add(this.txtCouleur);
            this.groupBox2.Controls.Add(this.txtsexe);
            this.groupBox2.Controls.Add(this.txtRace);
            this.groupBox2.Controls.Add(this.txtTatouage);
            this.groupBox2.Controls.Add(this.textEspece);
            this.groupBox2.Controls.Add(this.textNom);
            this.groupBox2.Controls.Add(this.textCode);
            this.groupBox2.Location = new System.Drawing.Point(13, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(682, 122);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Animal";
            // 
            // butTatouage
            // 
            this.butTatouage.Location = new System.Drawing.Point(96, 64);
            this.butTatouage.Name = "butTatouage";
            this.butTatouage.Size = new System.Drawing.Size(100, 23);
            this.butTatouage.TabIndex = 14;
            this.butTatouage.Text = "Ajouter tatouage";
            this.butTatouage.UseVisualStyleBackColor = true;
            this.butTatouage.Click += new System.EventHandler(this.butTatouage_Click);
            // 
            // lblSEX
            // 
            this.lblSEX.AutoSize = true;
            this.lblSEX.Location = new System.Drawing.Point(594, 45);
            this.lblSEX.Name = "lblSEX";
            this.lblSEX.Size = new System.Drawing.Size(37, 13);
            this.lblSEX.TabIndex = 13;
            this.lblSEX.Text = "Sexe :";
            // 
            // lblCouleur
            // 
            this.lblCouleur.AutoSize = true;
            this.lblCouleur.Location = new System.Drawing.Point(417, 23);
            this.lblCouleur.Name = "lblCouleur";
            this.lblCouleur.Size = new System.Drawing.Size(49, 13);
            this.lblCouleur.TabIndex = 12;
            this.lblCouleur.Text = "Couleur :";
            // 
            // lblRace
            // 
            this.lblRace.AutoSize = true;
            this.lblRace.Location = new System.Drawing.Point(427, 63);
            this.lblRace.Name = "lblRace";
            this.lblRace.Size = new System.Drawing.Size(39, 13);
            this.lblRace.TabIndex = 11;
            this.lblRace.Text = "Race :";
            // 
            // lblTatouage
            // 
            this.lblTatouage.AutoSize = true;
            this.lblTatouage.Location = new System.Drawing.Point(17, 96);
            this.lblTatouage.Name = "lblTatouage";
            this.lblTatouage.Size = new System.Drawing.Size(59, 13);
            this.lblTatouage.TabIndex = 10;
            this.lblTatouage.Text = "Tatouage :";
            // 
            // lblEspèce
            // 
            this.lblEspèce.AutoSize = true;
            this.lblEspèce.Location = new System.Drawing.Point(233, 56);
            this.lblEspèce.Name = "lblEspèce";
            this.lblEspèce.Size = new System.Drawing.Size(49, 13);
            this.lblEspèce.TabIndex = 9;
            this.lblEspèce.Text = "Espèce :";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(247, 23);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(35, 13);
            this.lblNom.TabIndex = 8;
            this.lblNom.Text = "Nom :";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(6, 26);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(38, 13);
            this.lblCode.TabIndex = 7;
            this.lblCode.Text = "Code :";
            // 
            // txtCouleur
            // 
            this.txtCouleur.Location = new System.Drawing.Point(477, 20);
            this.txtCouleur.Name = "txtCouleur";
            this.txtCouleur.ReadOnly = true;
            this.txtCouleur.Size = new System.Drawing.Size(100, 20);
            this.txtCouleur.TabIndex = 6;
            // 
            // txtsexe
            // 
            this.txtsexe.Location = new System.Drawing.Point(637, 42);
            this.txtsexe.Name = "txtsexe";
            this.txtsexe.ReadOnly = true;
            this.txtsexe.Size = new System.Drawing.Size(35, 20);
            this.txtsexe.TabIndex = 5;
            // 
            // txtRace
            // 
            this.txtRace.Location = new System.Drawing.Point(477, 60);
            this.txtRace.Name = "txtRace";
            this.txtRace.ReadOnly = true;
            this.txtRace.Size = new System.Drawing.Size(100, 20);
            this.txtRace.TabIndex = 4;
            // 
            // txtTatouage
            // 
            this.txtTatouage.Location = new System.Drawing.Point(96, 93);
            this.txtTatouage.Name = "txtTatouage";
            this.txtTatouage.ReadOnly = true;
            this.txtTatouage.Size = new System.Drawing.Size(100, 20);
            this.txtTatouage.TabIndex = 3;
            // 
            // textEspece
            // 
            this.textEspece.Location = new System.Drawing.Point(302, 56);
            this.textEspece.Name = "textEspece";
            this.textEspece.ReadOnly = true;
            this.textEspece.Size = new System.Drawing.Size(100, 20);
            this.textEspece.TabIndex = 2;
            // 
            // textNom
            // 
            this.textNom.Location = new System.Drawing.Point(302, 20);
            this.textNom.Name = "textNom";
            this.textNom.ReadOnly = true;
            this.textNom.Size = new System.Drawing.Size(100, 20);
            this.textNom.TabIndex = 1;
            // 
            // textCode
            // 
            this.textCode.Location = new System.Drawing.Point(50, 23);
            this.textCode.Name = "textCode";
            this.textCode.ReadOnly = true;
            this.textCode.Size = new System.Drawing.Size(184, 20);
            this.textCode.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(109, 223);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(586, 89);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.butAnnul);
            this.groupBox3.Controls.Add(this.ButAjouterActe);
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Controls.Add(this.lblType);
            this.groupBox3.Controls.Add(this.lbllibelle);
            this.groupBox3.Controls.Add(this.comboBoxLibelle);
            this.groupBox3.Controls.Add(this.comboBoxType);
            this.groupBox3.Controls.Add(this.lblDate);
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Controls.Add(this.lblVeto);
            this.groupBox3.Controls.Add(this.txtVeto);
            this.groupBox3.Controls.Add(this.dGVListeActes);
            this.groupBox3.Location = new System.Drawing.Point(14, 318);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(680, 309);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Actes médicaux";
            // 
            // butAnnul
            // 
            this.butAnnul.Location = new System.Drawing.Point(586, 105);
            this.butAnnul.Name = "butAnnul";
            this.butAnnul.Size = new System.Drawing.Size(67, 26);
            this.butAnnul.TabIndex = 24;
            this.butAnnul.Text = "Supprimer";
            this.butAnnul.UseVisualStyleBackColor = true;
            this.butAnnul.Click += new System.EventHandler(this.butAnnul_Click);
            // 
            // ButAjouterActe
            // 
            this.ButAjouterActe.Location = new System.Drawing.Point(587, 73);
            this.ButAjouterActe.Name = "ButAjouterActe";
            this.ButAjouterActe.Size = new System.Drawing.Size(66, 26);
            this.ButAjouterActe.TabIndex = 23;
            this.ButAjouterActe.Text = "Ajouter";
            this.ButAjouterActe.UseVisualStyleBackColor = true;
            this.ButAjouterActe.Click += new System.EventHandler(this.ButAjouterActe_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl);
            this.panel1.Controls.Add(this.lblMaxi);
            this.panel1.Controls.Add(this.lblMini);
            this.panel1.Controls.Add(this.textBoxPrix);
            this.panel1.Controls.Add(this.textBoxMaxi);
            this.panel1.Controls.Add(this.textBoxMini);
            this.panel1.Location = new System.Drawing.Point(388, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(161, 91);
            this.panel1.TabIndex = 22;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(27, 65);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(30, 13);
            this.lbl.TabIndex = 25;
            this.lbl.Text = "Prix :";
            // 
            // lblMaxi
            // 
            this.lblMaxi.AutoSize = true;
            this.lblMaxi.Location = new System.Drawing.Point(28, 39);
            this.lblMaxi.Name = "lblMaxi";
            this.lblMaxi.Size = new System.Drawing.Size(35, 13);
            this.lblMaxi.TabIndex = 24;
            this.lblMaxi.Text = "Maxi :";
            // 
            // lblMini
            // 
            this.lblMini.AutoSize = true;
            this.lblMini.Location = new System.Drawing.Point(27, 13);
            this.lblMini.Name = "lblMini";
            this.lblMini.Size = new System.Drawing.Size(32, 13);
            this.lblMini.TabIndex = 23;
            this.lblMini.Text = "Mini :";
            // 
            // textBoxPrix
            // 
            this.textBoxPrix.Location = new System.Drawing.Point(76, 62);
            this.textBoxPrix.Name = "textBoxPrix";
            this.textBoxPrix.Size = new System.Drawing.Size(73, 20);
            this.textBoxPrix.TabIndex = 16;
            // 
            // textBoxMaxi
            // 
            this.textBoxMaxi.Location = new System.Drawing.Point(76, 36);
            this.textBoxMaxi.Name = "textBoxMaxi";
            this.textBoxMaxi.ReadOnly = true;
            this.textBoxMaxi.Size = new System.Drawing.Size(73, 20);
            this.textBoxMaxi.TabIndex = 15;
            // 
            // textBoxMini
            // 
            this.textBoxMini.Location = new System.Drawing.Point(76, 10);
            this.textBoxMini.Name = "textBoxMini";
            this.textBoxMini.ReadOnly = true;
            this.textBoxMini.Size = new System.Drawing.Size(73, 20);
            this.textBoxMini.TabIndex = 14;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(46, 73);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(37, 13);
            this.lblType.TabIndex = 21;
            this.lblType.Text = "Type :";
            // 
            // lbllibelle
            // 
            this.lbllibelle.AutoSize = true;
            this.lbllibelle.Location = new System.Drawing.Point(190, 73);
            this.lbllibelle.Name = "lbllibelle";
            this.lbllibelle.Size = new System.Drawing.Size(43, 13);
            this.lbllibelle.TabIndex = 20;
            this.lbllibelle.Text = "Libelle :";
            // 
            // comboBoxLibelle
            // 
            this.comboBoxLibelle.FormattingEnabled = true;
            this.comboBoxLibelle.Location = new System.Drawing.Point(239, 70);
            this.comboBoxLibelle.Name = "comboBoxLibelle";
            this.comboBoxLibelle.Size = new System.Drawing.Size(122, 21);
            this.comboBoxLibelle.TabIndex = 19;
            this.comboBoxLibelle.SelectedIndexChanged += new System.EventHandler(this.comboBoxLibelle_SelectedIndexChanged);
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(95, 70);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(59, 21);
            this.comboBoxType.TabIndex = 18;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(118, 19);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(36, 13);
            this.lblDate.TabIndex = 17;
            this.lblDate.Text = "Date :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.Info;
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(163, 16);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // lblVeto
            // 
            this.lblVeto.AutoSize = true;
            this.lblVeto.Location = new System.Drawing.Point(385, 19);
            this.lblVeto.Name = "lblVeto";
            this.lblVeto.Size = new System.Drawing.Size(63, 13);
            this.lblVeto.TabIndex = 15;
            this.lblVeto.Text = "Vétérinaire :";
            // 
            // txtVeto
            // 
            this.txtVeto.Location = new System.Drawing.Point(454, 16);
            this.txtVeto.Name = "txtVeto";
            this.txtVeto.ReadOnly = true;
            this.txtVeto.Size = new System.Drawing.Size(207, 20);
            this.txtVeto.TabIndex = 4;
            // 
            // dGVListeActes
            // 
            this.dGVListeActes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dGVListeActes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVListeActes.Location = new System.Drawing.Point(13, 172);
            this.dGVListeActes.MultiSelect = false;
            this.dGVListeActes.Name = "dGVListeActes";
            this.dGVListeActes.ReadOnly = true;
            this.dGVListeActes.Size = new System.Drawing.Size(656, 131);
            this.dGVListeActes.TabIndex = 0;
            this.dGVListeActes.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dGVListeActes_DataBindingComplete);
            // 
            // lblCommentaire
            // 
            this.lblCommentaire.AutoSize = true;
            this.lblCommentaire.Location = new System.Drawing.Point(19, 259);
            this.lblCommentaire.Name = "lblCommentaire";
            this.lblCommentaire.Size = new System.Drawing.Size(74, 13);
            this.lblCommentaire.TabIndex = 14;
            this.lblCommentaire.Text = "Commentaire :";
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Location = new System.Drawing.Point(610, 633);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.ReadOnly = true;
            this.textBoxTotal.Size = new System.Drawing.Size(84, 20);
            this.textBoxTotal.TabIndex = 16;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(475, 636);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(126, 13);
            this.lblTotal.TabIndex = 17;
            this.lblTotal.Text = "Total  de la consultation :";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // ConsultationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 675);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.lblCommentaire);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultationForm";
            this.Text = "Consultation";
            this.Load += new System.EventHandler(this.Consultation_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVListeActes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button butAnnuler;
        private System.Windows.Forms.Button butValider;
        private System.Windows.Forms.Button butDossierMedical;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCouleur;
        private System.Windows.Forms.TextBox txtsexe;
        private System.Windows.Forms.TextBox txtRace;
        private System.Windows.Forms.TextBox textEspece;
        private System.Windows.Forms.TextBox textNom;
        private System.Windows.Forms.TextBox textCode;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dGVListeActes;
        private System.Windows.Forms.Label lblSEX;
        private System.Windows.Forms.Label lblCouleur;
        private System.Windows.Forms.Label lblRace;
        private System.Windows.Forms.Label lblTatouage;
        private System.Windows.Forms.Label lblEspèce;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblCommentaire;
        private System.Windows.Forms.Label lblVeto;
        private System.Windows.Forms.TextBox txtVeto;
        private System.Windows.Forms.TextBox txtTatouage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblMaxi;
        private System.Windows.Forms.Label lblMini;
        private System.Windows.Forms.TextBox textBoxPrix;
        private System.Windows.Forms.TextBox textBoxMaxi;
        private System.Windows.Forms.TextBox textBoxMini;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lbllibelle;
        private System.Windows.Forms.ComboBox comboBoxLibelle;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button butAnnul;
        private System.Windows.Forms.Button ButAjouterActe;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button butenregistrer;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button butTatouage;
    }
}