namespace FormationDotNetForms
{
    partial class NomPrenom
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.txbNom = new System.Windows.Forms.TextBox();
            this.lblDateNaissance = new System.Windows.Forms.Label();
            this.txbPrenom = new System.Windows.Forms.TextBox();
            this.txbDate = new System.Windows.Forms.DateTimePicker();
            this.btnValider = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.92157F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.07843F));
            this.tableLayoutPanel1.Controls.Add(this.lblDateNaissance, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblNom, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPrenom, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txbNom, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txbPrenom, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txbDate, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(255, 97);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(3, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(29, 13);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(3, 26);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(43, 13);
            this.lblPrenom.TabIndex = 1;
            this.lblPrenom.Text = "Prenom";
            this.lblPrenom.Click += new System.EventHandler(this.label2_Click);
            // 
            // txbNom
            // 
            this.txbNom.Location = new System.Drawing.Point(115, 3);
            this.txbNom.Name = "txbNom";
            this.txbNom.Size = new System.Drawing.Size(125, 20);
            this.txbNom.TabIndex = 2;
            // 
            // lblDateNaissance
            // 
            this.lblDateNaissance.AutoSize = true;
            this.lblDateNaissance.Location = new System.Drawing.Point(3, 52);
            this.lblDateNaissance.Name = "lblDateNaissance";
            this.lblDateNaissance.Size = new System.Drawing.Size(96, 13);
            this.lblDateNaissance.TabIndex = 4;
            this.lblDateNaissance.Text = "Date de naissance";
            // 
            // txbPrenom
            // 
            this.txbPrenom.Location = new System.Drawing.Point(115, 29);
            this.txbPrenom.Name = "txbPrenom";
            this.txbPrenom.Size = new System.Drawing.Size(122, 20);
            this.txbPrenom.TabIndex = 5;
            // 
            // txbDate
            // 
            this.txbDate.Location = new System.Drawing.Point(115, 55);
            this.txbDate.Name = "txbDate";
            this.txbDate.Size = new System.Drawing.Size(137, 20);
            this.txbDate.TabIndex = 6;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(12, 115);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 1;
            this.btnValider.Text = "Ok";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // NomPrenom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 152);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "NomPrenom";
            this.Text = "NomPrenom";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.TextBox txbNom;
        private System.Windows.Forms.Label lblDateNaissance;
        private System.Windows.Forms.TextBox txbPrenom;
        private System.Windows.Forms.DateTimePicker txbDate;
        private System.Windows.Forms.Button btnValider;
    }
}