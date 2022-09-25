namespace radSDvijeForme
{
    partial class FormStudenti
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
            this.btnNoviStudent = new System.Windows.Forms.Button();
            this.lbStudenti = new System.Windows.Forms.ListBox();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnObrisiSve = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNoviStudent
            // 
            this.btnNoviStudent.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoviStudent.Location = new System.Drawing.Point(12, 12);
            this.btnNoviStudent.Name = "btnNoviStudent";
            this.btnNoviStudent.Size = new System.Drawing.Size(266, 31);
            this.btnNoviStudent.TabIndex = 0;
            this.btnNoviStudent.Text = "Dodaj novog studenta";
            this.btnNoviStudent.UseVisualStyleBackColor = true;
            this.btnNoviStudent.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbStudenti
            // 
            this.lbStudenti.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStudenti.FormattingEnabled = true;
            this.lbStudenti.ItemHeight = 27;
            this.lbStudenti.Location = new System.Drawing.Point(12, 62);
            this.lbStudenti.Name = "lbStudenti";
            this.lbStudenti.Size = new System.Drawing.Size(423, 328);
            this.lbStudenti.TabIndex = 3;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisi.Location = new System.Drawing.Point(12, 423);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(192, 31);
            this.btnObrisi.TabIndex = 4;
            this.btnObrisi.Text = "Obriši studenta";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnObrisiSve
            // 
            this.btnObrisiSve.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiSve.Location = new System.Drawing.Point(210, 423);
            this.btnObrisiSve.Name = "btnObrisiSve";
            this.btnObrisiSve.Size = new System.Drawing.Size(225, 31);
            this.btnObrisiSve.TabIndex = 5;
            this.btnObrisiSve.Text = "Obriši sve studente";
            this.btnObrisiSve.UseVisualStyleBackColor = true;
            this.btnObrisiSve.Click += new System.EventHandler(this.btnObrisiSve_Click);
            // 
            // FormStudenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 491);
            this.Controls.Add(this.btnObrisiSve);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.lbStudenti);
            this.Controls.Add(this.btnNoviStudent);
            this.Name = "FormStudenti";
            this.Text = "Studenti";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNoviStudent;
        private System.Windows.Forms.ListBox lbStudenti;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnObrisiSve;
    }
}

