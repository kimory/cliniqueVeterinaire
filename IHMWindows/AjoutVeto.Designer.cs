namespace IHMWindows
{
    partial class AjoutVeto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjoutVeto));
            this.lblNomPrenom = new System.Windows.Forms.Label();
            this.lblMotPasse = new System.Windows.Forms.Label();
            this.TxtNomPrenom = new System.Windows.Forms.TextBox();
            this.TxtMotPasse = new System.Windows.Forms.TextBox();
            this.GBoxAjoutVeto = new System.Windows.Forms.GroupBox();
            this.ButValider = new System.Windows.Forms.Button();
            this.ButAnnuler = new System.Windows.Forms.Button();
            this.GBoxAjoutVeto.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNomPrenom
            // 
            this.lblNomPrenom.AutoSize = true;
            this.lblNomPrenom.Location = new System.Drawing.Point(38, 37);
            this.lblNomPrenom.Name = "lblNomPrenom";
            this.lblNomPrenom.Size = new System.Drawing.Size(82, 13);
            this.lblNomPrenom.TabIndex = 0;
            this.lblNomPrenom.Text = "Nom / Prénom :";
            // 
            // lblMotPasse
            // 
            this.lblMotPasse.AutoSize = true;
            this.lblMotPasse.Location = new System.Drawing.Point(38, 63);
            this.lblMotPasse.Name = "lblMotPasse";
            this.lblMotPasse.Size = new System.Drawing.Size(78, 13);
            this.lblMotPasse.TabIndex = 1;
            this.lblMotPasse.Text = "Mot de Passe :";
            // 
            // TxtNomPrenom
            // 
            this.TxtNomPrenom.Location = new System.Drawing.Point(126, 34);
            this.TxtNomPrenom.Name = "TxtNomPrenom";
            this.TxtNomPrenom.Size = new System.Drawing.Size(100, 20);
            this.TxtNomPrenom.TabIndex = 2;
            // 
            // TxtMotPasse
            // 
            this.TxtMotPasse.Location = new System.Drawing.Point(126, 60);
            this.TxtMotPasse.Name = "TxtMotPasse";
            this.TxtMotPasse.Size = new System.Drawing.Size(100, 20);
            this.TxtMotPasse.TabIndex = 3;
            // 
            // GBoxAjoutVeto
            // 
            this.GBoxAjoutVeto.Controls.Add(this.TxtMotPasse);
            this.GBoxAjoutVeto.Controls.Add(this.TxtNomPrenom);
            this.GBoxAjoutVeto.Controls.Add(this.lblMotPasse);
            this.GBoxAjoutVeto.Controls.Add(this.lblNomPrenom);
            this.GBoxAjoutVeto.Location = new System.Drawing.Point(12, 12);
            this.GBoxAjoutVeto.Name = "GBoxAjoutVeto";
            this.GBoxAjoutVeto.Size = new System.Drawing.Size(280, 112);
            this.GBoxAjoutVeto.TabIndex = 4;
            this.GBoxAjoutVeto.TabStop = false;
            this.GBoxAjoutVeto.Text = "Ajout d\'un vétérinaire";
            // 
            // ButValider
            // 
            this.ButValider.Location = new System.Drawing.Point(226, 130);
            this.ButValider.Name = "ButValider";
            this.ButValider.Size = new System.Drawing.Size(66, 34);
            this.ButValider.TabIndex = 5;
            this.ButValider.Text = "Valider";
            this.ButValider.UseVisualStyleBackColor = true;
            this.ButValider.Click += new System.EventHandler(this.ButValider_Click);
            // 
            // ButAnnuler
            // 
            this.ButAnnuler.Location = new System.Drawing.Point(154, 130);
            this.ButAnnuler.Name = "ButAnnuler";
            this.ButAnnuler.Size = new System.Drawing.Size(66, 34);
            this.ButAnnuler.TabIndex = 6;
            this.ButAnnuler.Text = "Annuler";
            this.ButAnnuler.UseVisualStyleBackColor = true;
            this.ButAnnuler.Click += new System.EventHandler(this.ButAnnuler_Click);
            // 
            // AjoutVeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 184);
            this.Controls.Add(this.ButAnnuler);
            this.Controls.Add(this.ButValider);
            this.Controls.Add(this.GBoxAjoutVeto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(323, 211);
            this.MinimumSize = new System.Drawing.Size(323, 211);
            this.Name = "AjoutVeto";
            this.Text = "Ajout Véto";
            this.GBoxAjoutVeto.ResumeLayout(false);
            this.GBoxAjoutVeto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNomPrenom;
        private System.Windows.Forms.Label lblMotPasse;
        private System.Windows.Forms.TextBox TxtNomPrenom;
        private System.Windows.Forms.TextBox TxtMotPasse;
        private System.Windows.Forms.GroupBox GBoxAjoutVeto;
        private System.Windows.Forms.Button ButValider;
        private System.Windows.Forms.Button ButAnnuler;
    }
}