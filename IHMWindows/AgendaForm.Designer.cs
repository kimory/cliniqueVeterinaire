namespace IHMWindows
{
    partial class AgendaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgendaForm));
            this.gbxVeterinaire = new System.Windows.Forms.GroupBox();
            this.dtpAgenda = new System.Windows.Forms.DateTimePicker();
            this.cbxVeterinaire = new System.Windows.Forms.ComboBox();
            this.lblVeterinaire = new System.Windows.Forms.Label();
            this.dgvAgenda = new System.Windows.Forms.DataGridView();
            this.btnDossierMedical = new System.Windows.Forms.Button();
            this.gbxVeterinaire.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgenda)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxVeterinaire
            // 
            this.gbxVeterinaire.Controls.Add(this.dtpAgenda);
            this.gbxVeterinaire.Controls.Add(this.cbxVeterinaire);
            this.gbxVeterinaire.Controls.Add(this.lblVeterinaire);
            this.gbxVeterinaire.Location = new System.Drawing.Point(12, 12);
            this.gbxVeterinaire.Name = "gbxVeterinaire";
            this.gbxVeterinaire.Size = new System.Drawing.Size(618, 50);
            this.gbxVeterinaire.TabIndex = 0;
            this.gbxVeterinaire.TabStop = false;
            this.gbxVeterinaire.Text = "De";
            // 
            // dtpAgenda
            // 
            this.dtpAgenda.Location = new System.Drawing.Point(380, 17);
            this.dtpAgenda.Name = "dtpAgenda";
            this.dtpAgenda.Size = new System.Drawing.Size(200, 20);
            this.dtpAgenda.TabIndex = 2;
            this.dtpAgenda.ValueChanged += new System.EventHandler(this.SelectionVeterinaireOuDate);
            // 
            // cbxVeterinaire
            // 
            this.cbxVeterinaire.FormattingEnabled = true;
            this.cbxVeterinaire.Location = new System.Drawing.Point(95, 17);
            this.cbxVeterinaire.Name = "cbxVeterinaire";
            this.cbxVeterinaire.Size = new System.Drawing.Size(192, 21);
            this.cbxVeterinaire.TabIndex = 1;
            this.cbxVeterinaire.SelectedIndexChanged += new System.EventHandler(this.SelectionVeterinaireOuDate);
            // 
            // lblVeterinaire
            // 
            this.lblVeterinaire.AutoSize = true;
            this.lblVeterinaire.Location = new System.Drawing.Point(32, 20);
            this.lblVeterinaire.Name = "lblVeterinaire";
            this.lblVeterinaire.Size = new System.Drawing.Size(57, 13);
            this.lblVeterinaire.TabIndex = 0;
            this.lblVeterinaire.Text = "Vétérinaire";
            // 
            // dgvAgenda
            // 
            this.dgvAgenda.AllowUserToAddRows = false;
            this.dgvAgenda.AllowUserToDeleteRows = false;
            this.dgvAgenda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgenda.Location = new System.Drawing.Point(13, 83);
            this.dgvAgenda.Name = "dgvAgenda";
            this.dgvAgenda.ReadOnly = true;
            this.dgvAgenda.Size = new System.Drawing.Size(617, 321);
            this.dgvAgenda.TabIndex = 1;
            this.dgvAgenda.DoubleClick += new System.EventHandler(this.dgvAgenda_DoubleClic);
            // 
            // btnDossierMedical
            // 
            this.btnDossierMedical.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDossierMedical.Location = new System.Drawing.Point(555, 423);
            this.btnDossierMedical.Name = "btnDossierMedical";
            this.btnDossierMedical.Size = new System.Drawing.Size(75, 44);
            this.btnDossierMedical.TabIndex = 2;
            this.btnDossierMedical.Text = "Dossier médical";
            this.btnDossierMedical.UseVisualStyleBackColor = true;
            this.btnDossierMedical.Click += new System.EventHandler(this.btnDossierMedical_Click);
            // 
            // AgendaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 479);
            this.Controls.Add(this.btnDossierMedical);
            this.Controls.Add(this.dgvAgenda);
            this.Controls.Add(this.gbxVeterinaire);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AgendaForm";
            this.Text = "Agenda";
            this.Load += new System.EventHandler(this.AgendaForm_Load);
            this.gbxVeterinaire.ResumeLayout(false);
            this.gbxVeterinaire.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgenda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxVeterinaire;
        private System.Windows.Forms.DateTimePicker dtpAgenda;
        private System.Windows.Forms.ComboBox cbxVeterinaire;
        private System.Windows.Forms.Label lblVeterinaire;
        private System.Windows.Forms.DataGridView dgvAgenda;
        private System.Windows.Forms.Button btnDossierMedical;
    }
}