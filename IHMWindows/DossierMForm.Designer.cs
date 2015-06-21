namespace IHMWindows
{
    partial class DossierMForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DossierMForm));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxPrenomClient = new System.Windows.Forms.ComboBox();
            this.comboBoxNomClient = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxTatouage = new System.Windows.Forms.ComboBox();
            this.comboBoxNomanimal = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Tatouage = new System.Windows.Forms.RadioButton();
            this.Animal = new System.Windows.Forms.RadioButton();
            this.Client = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.richTextBox1.Location = new System.Drawing.Point(272, 15);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(420, 346);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxPrenomClient);
            this.groupBox1.Controls.Add(this.comboBoxNomClient);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(88, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(163, 147);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recherche par Client :";
            // 
            // comboBoxPrenomClient
            // 
            this.comboBoxPrenomClient.FormattingEnabled = true;
            this.comboBoxPrenomClient.Location = new System.Drawing.Point(11, 108);
            this.comboBoxPrenomClient.Name = "comboBoxPrenomClient";
            this.comboBoxPrenomClient.Size = new System.Drawing.Size(127, 21);
            this.comboBoxPrenomClient.TabIndex = 5;
            this.comboBoxPrenomClient.SelectedIndexChanged += new System.EventHandler(this.comboBoxPrenomClient_SelectedIndexChanged);
            // 
            // comboBoxNomClient
            // 
            this.comboBoxNomClient.FormattingEnabled = true;
            this.comboBoxNomClient.Location = new System.Drawing.Point(11, 51);
            this.comboBoxNomClient.Name = "comboBoxNomClient";
            this.comboBoxNomClient.Size = new System.Drawing.Size(127, 21);
            this.comboBoxNomClient.TabIndex = 4;
            this.comboBoxNomClient.SelectedIndexChanged += new System.EventHandler(this.comboBoxPrenomClient_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prenom :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nom :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxTatouage);
            this.groupBox2.Controls.Add(this.comboBoxNomanimal);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(88, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(163, 147);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recherche par Animal :";
            // 
            // comboBoxTatouage
            // 
            this.comboBoxTatouage.FormattingEnabled = true;
            this.comboBoxTatouage.Location = new System.Drawing.Point(11, 107);
            this.comboBoxTatouage.Name = "comboBoxTatouage";
            this.comboBoxTatouage.Size = new System.Drawing.Size(127, 21);
            this.comboBoxTatouage.TabIndex = 7;
            // 
            // comboBoxNomanimal
            // 
            this.comboBoxNomanimal.FormattingEnabled = true;
            this.comboBoxNomanimal.Location = new System.Drawing.Point(11, 48);
            this.comboBoxNomanimal.Name = "comboBoxNomanimal";
            this.comboBoxNomanimal.Size = new System.Drawing.Size(127, 21);
            this.comboBoxNomanimal.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tatouage :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nom :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Tatouage);
            this.groupBox3.Controls.Add(this.Animal);
            this.groupBox3.Controls.Add(this.Client);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(61, 300);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Options";
            // 
            // Tatouage
            // 
            this.Tatouage.AutoSize = true;
            this.Tatouage.Location = new System.Drawing.Point(21, 260);
            this.Tatouage.Name = "Tatouage";
            this.Tatouage.Size = new System.Drawing.Size(14, 13);
            this.Tatouage.TabIndex = 2;
            this.Tatouage.TabStop = true;
            this.Tatouage.UseVisualStyleBackColor = true;
            this.Tatouage.CheckedChanged += new System.EventHandler(this.Animal_CheckedChanged);
            // 
            // Animal
            // 
            this.Animal.AutoSize = true;
            this.Animal.Location = new System.Drawing.Point(21, 201);
            this.Animal.Name = "Animal";
            this.Animal.Size = new System.Drawing.Size(14, 13);
            this.Animal.TabIndex = 1;
            this.Animal.TabStop = true;
            this.Animal.UseVisualStyleBackColor = true;
            this.Animal.CheckedChanged += new System.EventHandler(this.Animal_CheckedChanged);
            // 
            // Client
            // 
            this.Client.AutoSize = true;
            this.Client.Location = new System.Drawing.Point(21, 54);
            this.Client.Name = "Client";
            this.Client.Size = new System.Drawing.Size(14, 13);
            this.Client.TabIndex = 0;
            this.Client.TabStop = true;
            this.Client.UseVisualStyleBackColor = true;
            this.Client.CheckedChanged += new System.EventHandler(this.Animal_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(114, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 43);
            this.button1.TabIndex = 4;
            this.button1.Text = "Rechercher";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DossierMForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 373);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.richTextBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DossierMForm";
            this.Text = "Dossier Medical";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxPrenomClient;
        private System.Windows.Forms.ComboBox comboBoxNomClient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxTatouage;
        private System.Windows.Forms.ComboBox comboBoxNomanimal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton Tatouage;
        private System.Windows.Forms.RadioButton Animal;
        private System.Windows.Forms.RadioButton Client;
        private System.Windows.Forms.Button button1;
    }
}