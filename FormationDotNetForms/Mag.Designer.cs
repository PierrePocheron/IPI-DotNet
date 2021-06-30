namespace FormationDotNetForms
{
    partial class Mag
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnRafraichir = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrix = new System.Windows.Forms.Label();
            this.lblPoids = new System.Windows.Forms.Label();
            this.lblQuantite = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.txbNom = new System.Windows.Forms.TextBox();
            this.txbPrix = new System.Windows.Forms.NumericUpDown();
            this.txbPoids = new System.Windows.Forms.NumericUpDown();
            this.txbQuantite = new System.Windows.Forms.NumericUpDown();
            this.txbTax = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txbPrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbPoids)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbQuantite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbTax)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 151);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 221);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(12, 402);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 1;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(130, 402);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 2;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(254, 402);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 3;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnRafraichir
            // 
            this.btnRafraichir.Location = new System.Drawing.Point(371, 402);
            this.btnRafraichir.Name = "btnRafraichir";
            this.btnRafraichir.Size = new System.Drawing.Size(75, 23);
            this.btnRafraichir.TabIndex = 4;
            this.btnRafraichir.Text = "Rafraichir";
            this.btnRafraichir.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblNom, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPrix, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblPoids, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblQuantite, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblTax, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txbNom, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txbPrix, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txbPoids, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txbQuantite, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txbTax, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 45);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(3, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(35, 13);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom :";
            // 
            // lblPrix
            // 
            this.lblPrix.AutoSize = true;
            this.lblPrix.Location = new System.Drawing.Point(3, 20);
            this.lblPrix.Name = "lblPrix";
            this.lblPrix.Size = new System.Drawing.Size(30, 13);
            this.lblPrix.TabIndex = 1;
            this.lblPrix.Text = "Prix :";
            // 
            // lblPoids
            // 
            this.lblPoids.AutoSize = true;
            this.lblPoids.Location = new System.Drawing.Point(3, 40);
            this.lblPoids.Name = "lblPoids";
            this.lblPoids.Size = new System.Drawing.Size(39, 13);
            this.lblPoids.TabIndex = 2;
            this.lblPoids.Text = "Poids :";
            // 
            // lblQuantite
            // 
            this.lblQuantite.AutoSize = true;
            this.lblQuantite.Location = new System.Drawing.Point(3, 60);
            this.lblQuantite.Name = "lblQuantite";
            this.lblQuantite.Size = new System.Drawing.Size(53, 13);
            this.lblQuantite.TabIndex = 3;
            this.lblQuantite.Text = "Quantité :";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(3, 80);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(31, 13);
            this.lblTax.TabIndex = 4;
            this.lblTax.Text = "Tax :";
            // 
            // txbNom
            // 
            this.txbNom.Location = new System.Drawing.Point(103, 3);
            this.txbNom.Name = "txbNom";
            this.txbNom.Size = new System.Drawing.Size(94, 20);
            this.txbNom.TabIndex = 5;
            // 
            // txbPrix
            // 
            this.txbPrix.Location = new System.Drawing.Point(103, 23);
            this.txbPrix.Name = "txbPrix";
            this.txbPrix.Size = new System.Drawing.Size(94, 20);
            this.txbPrix.TabIndex = 6;
            // 
            // txbPoids
            // 
            this.txbPoids.Location = new System.Drawing.Point(103, 43);
            this.txbPoids.Name = "txbPoids";
            this.txbPoids.Size = new System.Drawing.Size(94, 20);
            this.txbPoids.TabIndex = 7;
            // 
            // txbQuantite
            // 
            this.txbQuantite.Location = new System.Drawing.Point(103, 63);
            this.txbQuantite.Name = "txbQuantite";
            this.txbQuantite.Size = new System.Drawing.Size(94, 20);
            this.txbQuantite.TabIndex = 8;
            // 
            // txbTax
            // 
            this.txbTax.Location = new System.Drawing.Point(103, 83);
            this.txbTax.Name = "txbTax";
            this.txbTax.Size = new System.Drawing.Size(94, 20);
            this.txbTax.TabIndex = 9;
            this.txbTax.ValueChanged += new System.EventHandler(this.numericUpDown4_ValueChanged);
            // 
            // Mag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnRafraichir);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Mag";
            this.Text = "Mag";
            this.Load += new System.EventHandler(this.Mag_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txbPrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbPoids)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbQuantite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbTax)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnRafraichir;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblPrix;
        private System.Windows.Forms.Label lblPoids;
        private System.Windows.Forms.Label lblQuantite;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.TextBox txbNom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.NumericUpDown txbPrix;
        private System.Windows.Forms.NumericUpDown txbPoids;
        private System.Windows.Forms.NumericUpDown txbQuantite;
        private System.Windows.Forms.NumericUpDown txbTax;
    }
}