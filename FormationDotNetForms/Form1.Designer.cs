namespace FormationDotNetForms
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
            this.btnAfficherUnMessage = new System.Windows.Forms.Button();
            this.btnSaisiePersonne = new System.Windows.Forms.Button();
            this.btnEventMouse = new System.Windows.Forms.Button();
            this.btnMagasin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAfficherUnMessage
            // 
            this.btnAfficherUnMessage.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAfficherUnMessage.ForeColor = System.Drawing.Color.Coral;
            this.btnAfficherUnMessage.Location = new System.Drawing.Point(12, 12);
            this.btnAfficherUnMessage.Name = "btnAfficherUnMessage";
            this.btnAfficherUnMessage.Size = new System.Drawing.Size(200, 34);
            this.btnAfficherUnMessage.TabIndex = 0;
            this.btnAfficherUnMessage.Text = "Afficher un message ";
            this.btnAfficherUnMessage.UseVisualStyleBackColor = true;
            this.btnAfficherUnMessage.Click += new System.EventHandler(this.btnAfficherUnMessage_Click);
            // 
            // btnSaisiePersonne
            // 
            this.btnSaisiePersonne.Location = new System.Drawing.Point(30, 174);
            this.btnSaisiePersonne.Name = "btnSaisiePersonne";
            this.btnSaisiePersonne.Size = new System.Drawing.Size(141, 23);
            this.btnSaisiePersonne.TabIndex = 1;
            this.btnSaisiePersonne.Text = "Saisir une personne";
            this.btnSaisiePersonne.UseVisualStyleBackColor = true;
            this.btnSaisiePersonne.Click += new System.EventHandler(this.btnSaisiePersonne_Click);
            // 
            // btnEventMouse
            // 
            this.btnEventMouse.Location = new System.Drawing.Point(30, 267);
            this.btnEventMouse.Name = "btnEventMouse";
            this.btnEventMouse.Size = new System.Drawing.Size(157, 44);
            this.btnEventMouse.TabIndex = 2;
            this.btnEventMouse.Text = "> Evenement <";
            this.btnEventMouse.UseVisualStyleBackColor = true;
            this.btnEventMouse.Click += new System.EventHandler(this.btnEventMouse_Click);
            this.btnEventMouse.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEventMouse_MouseMove);
            // 
            // btnMagasin
            // 
            this.btnMagasin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMagasin.Location = new System.Drawing.Point(30, 366);
            this.btnMagasin.Name = "btnMagasin";
            this.btnMagasin.Size = new System.Drawing.Size(75, 23);
            this.btnMagasin.TabIndex = 3;
            this.btnMagasin.Text = "Magazin";
            this.btnMagasin.UseVisualStyleBackColor = true;
            this.btnMagasin.Click += new System.EventHandler(this.btnMagasin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 450);
            this.Controls.Add(this.btnMagasin);
            this.Controls.Add(this.btnEventMouse);
            this.Controls.Add(this.btnSaisiePersonne);
            this.Controls.Add(this.btnAfficherUnMessage);
            this.Name = "Form1";
            this.Text = "Exemple d\'utilisation de windows Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAfficherUnMessage;
        private System.Windows.Forms.Button btnSaisiePersonne;
        private System.Windows.Forms.Button btnEventMouse;
        private System.Windows.Forms.Button btnMagasin;
    }
}

