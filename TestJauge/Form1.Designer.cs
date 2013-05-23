namespace TestJauge
{
    partial class Form1
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
            this.btnValider = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNouvelleValeur = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.circularGauge21 = new GaugeControls.CircularGauge2();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(25, 82);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(146, 30);
            this.btnValider.TabIndex = 1;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nouvelle valeur :";
            // 
            // txtNouvelleValeur
            // 
            this.txtNouvelleValeur.Location = new System.Drawing.Point(112, 47);
            this.txtNouvelleValeur.Name = "txtNouvelleValeur";
            this.txtNouvelleValeur.Size = new System.Drawing.Size(59, 20);
            this.txtNouvelleValeur.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnValider);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNouvelleValeur);
            this.groupBox1.Location = new System.Drawing.Point(605, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 167);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Test";
            // 
            // circularGauge21
            // 
            this.circularGauge21.BackColor = System.Drawing.Color.Transparent;
            this.circularGauge21.DialColor = System.Drawing.Color.Lavender;
            this.circularGauge21.DialText = null;
            this.circularGauge21.Glossiness = 11.36364F;
            this.circularGauge21.Location = new System.Drawing.Point(86, 40);
            this.circularGauge21.MaxValue = 100F;
            this.circularGauge21.MinValue = 0F;
            this.circularGauge21.Name = "circularGauge21";
            this.circularGauge21.RecommendedValue = 0F;
            this.circularGauge21.Size = new System.Drawing.Size(400, 400);
            this.circularGauge21.TabIndex = 5;
            this.circularGauge21.ThresholdPercent = 0F;
            this.circularGauge21.Value = 0F;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 520);
            this.Controls.Add(this.circularGauge21);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Dashboard";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNouvelleValeur;
        private System.Windows.Forms.GroupBox groupBox1;
        private GaugeControls.CircularGauge2 circularGauge21;
       




















    }
}

