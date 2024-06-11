namespace dvojka
{
    partial class Form1
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
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.cmbUloga = new System.Windows.Forms.ComboBox();
            this.btnDodajOsobu = new System.Windows.Forms.Button();
            this.btnPrikaziOsobe = new System.Windows.Forms.Button();
            this.cmbFiltriraj = new System.Windows.Forms.ComboBox();
            this.btnFiltriraj = new System.Windows.Forms.Button();
            this.btnObradiPodatke = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(46, 36);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(100, 26);
            this.txtIme.TabIndex = 0;
            this.txtIme.Text = "Ime";
            this.txtIme.TextChanged += new System.EventHandler(this.txtIme_TextChanged);
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(46, 93);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(100, 26);
            this.txtPrezime.TabIndex = 1;
            this.txtPrezime.Text = "Prezime";
            // 
            // cmbUloga
            // 
            this.cmbUloga.FormattingEnabled = true;
            this.cmbUloga.Location = new System.Drawing.Point(46, 146);
            this.cmbUloga.Name = "cmbUloga";
            this.cmbUloga.Size = new System.Drawing.Size(121, 28);
            this.cmbUloga.TabIndex = 2;
            this.cmbUloga.Text = "Uloga";
            // 
            // btnDodajOsobu
            // 
            this.btnDodajOsobu.Location = new System.Drawing.Point(46, 189);
            this.btnDodajOsobu.Name = "btnDodajOsobu";
            this.btnDodajOsobu.Size = new System.Drawing.Size(121, 28);
            this.btnDodajOsobu.TabIndex = 3;
            this.btnDodajOsobu.Text = "Dodaj Osobu";
            this.btnDodajOsobu.UseVisualStyleBackColor = true;
            // 
            // btnPrikaziOsobe
            // 
            this.btnPrikaziOsobe.Location = new System.Drawing.Point(46, 233);
            this.btnPrikaziOsobe.Name = "btnPrikaziOsobe";
            this.btnPrikaziOsobe.Size = new System.Drawing.Size(121, 32);
            this.btnPrikaziOsobe.TabIndex = 4;
            this.btnPrikaziOsobe.Text = "Prikaži osobe";
            this.btnPrikaziOsobe.UseVisualStyleBackColor = true;
            // 
            // cmbFiltriraj
            // 
            this.cmbFiltriraj.FormattingEnabled = true;
            this.cmbFiltriraj.Location = new System.Drawing.Point(46, 280);
            this.cmbFiltriraj.Name = "cmbFiltriraj";
            this.cmbFiltriraj.Size = new System.Drawing.Size(121, 28);
            this.cmbFiltriraj.TabIndex = 5;
            this.cmbFiltriraj.Text = "Filtriraj";
            // 
            // btnFiltriraj
            // 
            this.btnFiltriraj.Location = new System.Drawing.Point(46, 325);
            this.btnFiltriraj.Name = "btnFiltriraj";
            this.btnFiltriraj.Size = new System.Drawing.Size(142, 33);
            this.btnFiltriraj.TabIndex = 6;
            this.btnFiltriraj.Text = "Filtriraj";
            this.btnFiltriraj.UseVisualStyleBackColor = true;
            // 
            // btnObradiPodatke
            // 
            this.btnObradiPodatke.Location = new System.Drawing.Point(46, 364);
            this.btnObradiPodatke.Name = "btnObradiPodatke";
            this.btnObradiPodatke.Size = new System.Drawing.Size(142, 33);
            this.btnObradiPodatke.TabIndex = 7;
            this.btnObradiPodatke.Text = "Obradi podatke";
            this.btnObradiPodatke.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(303, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(371, 361);
            this.dataGridView1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnObradiPodatke);
            this.Controls.Add(this.btnFiltriraj);
            this.Controls.Add(this.cmbFiltriraj);
            this.Controls.Add(this.btnPrikaziOsobe);
            this.Controls.Add(this.btnDodajOsobu);
            this.Controls.Add(this.cmbUloga);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.ComboBox cmbUloga;
        private System.Windows.Forms.Button btnDodajOsobu;
        private System.Windows.Forms.Button btnPrikaziOsobe;
        private System.Windows.Forms.ComboBox cmbFiltriraj;
        private System.Windows.Forms.Button btnFiltriraj;
        private System.Windows.Forms.Button btnObradiPodatke;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

