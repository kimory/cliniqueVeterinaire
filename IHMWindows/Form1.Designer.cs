namespace IHMWindows
{
    partial class VeterinaireForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.LBVeterinaire = new System.Windows.Forms.ListBox();
            this.BtAjouter = new System.Windows.Forms.Button();
            this.BtArchiver = new System.Windows.Forms.Button();
            this.BtRéinitialiser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBVeterinaire
            // 
            this.LBVeterinaire.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LBVeterinaire.FormattingEnabled = true;
            this.LBVeterinaire.Location = new System.Drawing.Point(12, 49);
            this.LBVeterinaire.Name = "LBVeterinaire";
            this.LBVeterinaire.Size = new System.Drawing.Size(611, 290);
            this.LBVeterinaire.TabIndex = 0;
            // 
            // BtAjouter
            // 
            this.BtAjouter.Location = new System.Drawing.Point(12, 6);
            this.BtAjouter.Name = "BtAjouter";
            this.BtAjouter.Size = new System.Drawing.Size(70, 37);
            this.BtAjouter.TabIndex = 1;
            this.BtAjouter.Text = "Ajouter";
            this.BtAjouter.UseVisualStyleBackColor = true;
            // 
            // BtArchiver
            // 
            this.BtArchiver.Location = new System.Drawing.Point(88, 6);
            this.BtArchiver.Name = "BtArchiver";
            this.BtArchiver.Size = new System.Drawing.Size(70, 37);
            this.BtArchiver.TabIndex = 2;
            this.BtArchiver.Text = "Archiver";
            this.BtArchiver.UseVisualStyleBackColor = true;
            // 
            // BtRéinitialiser
            // 
            this.BtRéinitialiser.Location = new System.Drawing.Point(164, 6);
            this.BtRéinitialiser.Name = "BtRéinitialiser";
            this.BtRéinitialiser.Size = new System.Drawing.Size(107, 37);
            this.BtRéinitialiser.TabIndex = 3;
            this.BtRéinitialiser.Text = "Reinitialiser le mot de passe";
            this.BtRéinitialiser.UseVisualStyleBackColor = true;
            // 
            // VeterinaireForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 355);
            this.Controls.Add(this.BtRéinitialiser);
            this.Controls.Add(this.BtArchiver);
            this.Controls.Add(this.BtAjouter);
            this.Controls.Add(this.LBVeterinaire);
            this.MinimumSize = new System.Drawing.Size(651, 394);
            this.Name = "VeterinaireForm";
            this.Text = "Gestion des vétérinaires";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LBVeterinaire;
        private System.Windows.Forms.Button BtAjouter;
        private System.Windows.Forms.Button BtArchiver;
        private System.Windows.Forms.Button BtRéinitialiser;
    }
}

