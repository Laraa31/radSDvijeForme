namespace radSDvijeForme
{
    partial class FormUnosNovogStudenta
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
            this.btnSnimi = new System.Windows.Forms.Button();
            this.lblIme = new System.Windows.Forms.Label();
            this.txtBoxIme = new System.Windows.Forms.TextBox();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.cmbSmjer = new System.Windows.Forms.ComboBox();
            this.lblDatum = new System.Windows.Forms.Label();
            this.txtBoxPrezime = new System.Windows.Forms.TextBox();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.txtBoxIndeks = new System.Windows.Forms.TextBox();
            this.lblIndeks = new System.Windows.Forms.Label();
            this.lblSmjer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSnimi
            // 
            this.btnSnimi.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSnimi.Location = new System.Drawing.Point(17, 336);
            this.btnSnimi.Name = "btnSnimi";
            this.btnSnimi.Size = new System.Drawing.Size(100, 33);
            this.btnSnimi.TabIndex = 0;
            this.btnSnimi.Text = "Snimi";
            this.btnSnimi.UseVisualStyleBackColor = true;
            this.btnSnimi.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIme.Location = new System.Drawing.Point(12, 9);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(46, 30);
            this.lblIme.TabIndex = 1;
            this.lblIme.Text = "Ime:";
            this.lblIme.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBoxIme
            // 
            this.txtBoxIme.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxIme.Location = new System.Drawing.Point(17, 42);
            this.txtBoxIme.Name = "txtBoxIme";
            this.txtBoxIme.Size = new System.Drawing.Size(197, 35);
            this.txtBoxIme.TabIndex = 2;
            this.txtBoxIme.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOtkazi.Location = new System.Drawing.Point(403, 336);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(100, 33);
            this.btnOtkazi.TabIndex = 3;
            this.btnOtkazi.Text = "Otkazi";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);
            // 
            // dtpDatum
            // 
            this.dtpDatum.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDatum.Location = new System.Drawing.Point(303, 136);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(200, 35);
            this.dtpDatum.TabIndex = 4;
            // 
            // cmbSmjer
            // 
            this.cmbSmjer.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSmjer.FormattingEnabled = true;
            this.cmbSmjer.Items.AddRange(new object[] {
            "Programer",
            "Sistem administrator",
            "Mrežni administrator"});
            this.cmbSmjer.Location = new System.Drawing.Point(17, 238);
            this.cmbSmjer.Name = "cmbSmjer";
            this.cmbSmjer.Size = new System.Drawing.Size(197, 35);
            this.cmbSmjer.TabIndex = 5;
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatum.Location = new System.Drawing.Point(298, 103);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(132, 30);
            this.lblDatum.TabIndex = 6;
            this.lblDatum.Text = "Datum rodenja:";
            // 
            // txtBoxPrezime
            // 
            this.txtBoxPrezime.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPrezime.Location = new System.Drawing.Point(17, 136);
            this.txtBoxPrezime.Name = "txtBoxPrezime";
            this.txtBoxPrezime.Size = new System.Drawing.Size(197, 35);
            this.txtBoxPrezime.TabIndex = 8;
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrezime.Location = new System.Drawing.Point(12, 103);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(78, 30);
            this.lblPrezime.TabIndex = 7;
            this.lblPrezime.Text = "Prezime:";
            // 
            // txtBoxIndeks
            // 
            this.txtBoxIndeks.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxIndeks.Location = new System.Drawing.Point(303, 42);
            this.txtBoxIndeks.Name = "txtBoxIndeks";
            this.txtBoxIndeks.Size = new System.Drawing.Size(197, 35);
            this.txtBoxIndeks.TabIndex = 10;
            // 
            // lblIndeks
            // 
            this.lblIndeks.AutoSize = true;
            this.lblIndeks.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndeks.Location = new System.Drawing.Point(298, 9);
            this.lblIndeks.Name = "lblIndeks";
            this.lblIndeks.Size = new System.Drawing.Size(109, 30);
            this.lblIndeks.TabIndex = 9;
            this.lblIndeks.Text = "Broj indeksa:";
            // 
            // lblSmjer
            // 
            this.lblSmjer.AutoSize = true;
            this.lblSmjer.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSmjer.Location = new System.Drawing.Point(12, 205);
            this.lblSmjer.Name = "lblSmjer";
            this.lblSmjer.Size = new System.Drawing.Size(60, 30);
            this.lblSmjer.TabIndex = 11;
            this.lblSmjer.Text = "Smjer:";
            // 
            // FormUnosNovogStudenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 400);
            this.Controls.Add(this.lblSmjer);
            this.Controls.Add(this.txtBoxIndeks);
            this.Controls.Add(this.lblIndeks);
            this.Controls.Add(this.txtBoxPrezime);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.cmbSmjer);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.txtBoxIme);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.btnSnimi);
            this.Name = "FormUnosNovogStudenta";
            this.Text = "Unos Novog Studenta";
            this.Load += new System.EventHandler(this.FormUnosNovogStudenta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSnimi;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.TextBox txtBoxIme;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.ComboBox cmbSmjer;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.TextBox txtBoxPrezime;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.TextBox txtBoxIndeks;
        private System.Windows.Forms.Label lblIndeks;
        private System.Windows.Forms.Label lblSmjer;
    }
}