namespace IHMWindows
{
    partial class VaccinForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VaccinForm));
            this.dgvVaccins = new System.Windows.Forms.DataGridView();
            this.btnVaccinsACder = new System.Windows.Forms.Button();
            this.sfdVaccins = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVaccins)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVaccins
            // 
            this.dgvVaccins.AllowUserToAddRows = false;
            this.dgvVaccins.AllowUserToDeleteRows = false;
            this.dgvVaccins.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVaccins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVaccins.Location = new System.Drawing.Point(31, 24);
            this.dgvVaccins.Name = "dgvVaccins";
            this.dgvVaccins.Size = new System.Drawing.Size(552, 400);
            this.dgvVaccins.TabIndex = 0;
            this.dgvVaccins.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVaccins_CellValueChanged);
            // 
            // btnVaccinsACder
            // 
            this.btnVaccinsACder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVaccinsACder.Location = new System.Drawing.Point(508, 445);
            this.btnVaccinsACder.Name = "btnVaccinsACder";
            this.btnVaccinsACder.Size = new System.Drawing.Size(75, 39);
            this.btnVaccinsACder.TabIndex = 1;
            this.btnVaccinsACder.Text = "vaccins à commander";
            this.btnVaccinsACder.UseVisualStyleBackColor = true;
            this.btnVaccinsACder.Click += new System.EventHandler(this.btnVaccinsACder_Click);
            // 
            // VaccinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 496);
            this.Controls.Add(this.btnVaccinsACder);
            this.Controls.Add(this.dgvVaccins);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VaccinForm";
            this.Text = "Vaccins";
            this.Load += new System.EventHandler(this.VaccinForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVaccins)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVaccins;
        private System.Windows.Forms.Button btnVaccinsACder;
        private System.Windows.Forms.SaveFileDialog sfdVaccins;
    }
}