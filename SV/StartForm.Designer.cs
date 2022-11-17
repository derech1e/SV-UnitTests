
namespace SV
{
    partial class StartForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLehrer = new System.Windows.Forms.Button();
            this.lblAnzeige = new System.Windows.Forms.Label();
            this.btnKlasse = new System.Windows.Forms.Button();
            this.btnSchueler = new System.Windows.Forms.Button();
            this.grbFach = new System.Windows.Forms.GroupBox();
            this.btnFach = new System.Windows.Forms.Button();
            this.btnIdent = new System.Windows.Forms.Button();
            this.cboxSchulart = new System.Windows.Forms.ComboBox();
            this.cboxFach = new System.Windows.Forms.ComboBox();
            this.btnPerson = new System.Windows.Forms.Button();
            this.grbFach.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLehrer
            // 
            this.btnLehrer.Location = new System.Drawing.Point(32, 29);
            this.btnLehrer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLehrer.Name = "btnLehrer";
            this.btnLehrer.Size = new System.Drawing.Size(217, 35);
            this.btnLehrer.TabIndex = 0;
            this.btnLehrer.Text = "Lehrerobjekt anzeigen";
            this.btnLehrer.UseVisualStyleBackColor = true;
            this.btnLehrer.Click += new System.EventHandler(this.btnLehrer_Click);
            // 
            // lblAnzeige
            // 
            this.lblAnzeige.AutoSize = true;
            this.lblAnzeige.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnzeige.Location = new System.Drawing.Point(314, 36);
            this.lblAnzeige.Name = "lblAnzeige";
            this.lblAnzeige.Size = new System.Drawing.Size(17, 16);
            this.lblAnzeige.TabIndex = 1;
            this.lblAnzeige.Text = "...";
            // 
            // btnKlasse
            // 
            this.btnKlasse.Location = new System.Drawing.Point(32, 74);
            this.btnKlasse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnKlasse.Name = "btnKlasse";
            this.btnKlasse.Size = new System.Drawing.Size(217, 35);
            this.btnKlasse.TabIndex = 2;
            this.btnKlasse.Text = "Klassenobjekt anzeigen";
            this.btnKlasse.UseVisualStyleBackColor = true;
            this.btnKlasse.Click += new System.EventHandler(this.btnKlasse_Click);
            // 
            // btnSchueler
            // 
            this.btnSchueler.Location = new System.Drawing.Point(32, 119);
            this.btnSchueler.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSchueler.Name = "btnSchueler";
            this.btnSchueler.Size = new System.Drawing.Size(217, 35);
            this.btnSchueler.TabIndex = 3;
            this.btnSchueler.Text = "Schülerobjekt anzeigen";
            this.btnSchueler.UseVisualStyleBackColor = true;
            this.btnSchueler.Click += new System.EventHandler(this.btnSchueler_Click);
            // 
            // grbFach
            // 
            this.grbFach.Controls.Add(this.btnFach);
            this.grbFach.Controls.Add(this.btnIdent);
            this.grbFach.Controls.Add(this.cboxSchulart);
            this.grbFach.Controls.Add(this.cboxFach);
            this.grbFach.Location = new System.Drawing.Point(32, 213);
            this.grbFach.Name = "grbFach";
            this.grbFach.Size = new System.Drawing.Size(216, 253);
            this.grbFach.TabIndex = 4;
            this.grbFach.TabStop = false;
            this.grbFach.Text = "Fach festlegen";
            // 
            // btnFach
            // 
            this.btnFach.Location = new System.Drawing.Point(20, 198);
            this.btnFach.Name = "btnFach";
            this.btnFach.Size = new System.Drawing.Size(180, 35);
            this.btnFach.TabIndex = 3;
            this.btnFach.Text = "Fach speichern";
            this.btnFach.UseVisualStyleBackColor = true;
            this.btnFach.Click += new System.EventHandler(this.btnFach_Click);
            // 
            // btnIdent
            // 
            this.btnIdent.Location = new System.Drawing.Point(20, 146);
            this.btnIdent.Name = "btnIdent";
            this.btnIdent.Size = new System.Drawing.Size(180, 35);
            this.btnIdent.TabIndex = 2;
            this.btnIdent.Text = "Ident anzeigen";
            this.btnIdent.UseVisualStyleBackColor = true;
            this.btnIdent.Click += new System.EventHandler(this.btnIdent_Click);
            // 
            // cboxSchulart
            // 
            this.cboxSchulart.FormattingEnabled = true;
            this.cboxSchulart.Items.AddRange(new object[] {
            "Berufsschule",
            "Berufsvorbereitung",
            "Fachoberschule",
            "Grundkurs",
            "Leistungskurs"});
            this.cboxSchulart.Location = new System.Drawing.Point(20, 92);
            this.cboxSchulart.Name = "cboxSchulart";
            this.cboxSchulart.Size = new System.Drawing.Size(181, 28);
            this.cboxSchulart.Sorted = true;
            this.cboxSchulart.TabIndex = 1;
            this.cboxSchulart.Text = "Bitte Art wählen";
            // 
            // cboxFach
            // 
            this.cboxFach.FormattingEnabled = true;
            this.cboxFach.Items.AddRange(new object[] {
            "Biologie",
            "Englisch",
            "Informatik",
            "Informatik-Systeme",
            "Mathematik",
            "Wirtschaftslehre/Recht"});
            this.cboxFach.Location = new System.Drawing.Point(20, 38);
            this.cboxFach.Name = "cboxFach";
            this.cboxFach.Size = new System.Drawing.Size(181, 28);
            this.cboxFach.Sorted = true;
            this.cboxFach.TabIndex = 0;
            this.cboxFach.Text = "Bitte Fach wählen";
            // 
            // btnPerson
            // 
            this.btnPerson.Location = new System.Drawing.Point(32, 164);
            this.btnPerson.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPerson.Name = "btnPerson";
            this.btnPerson.Size = new System.Drawing.Size(217, 35);
            this.btnPerson.TabIndex = 5;
            this.btnPerson.Text = "Personenobjekt anzeigen";
            this.btnPerson.UseVisualStyleBackColor = true;
            this.btnPerson.Click += new System.EventHandler(this.BtnPerson_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 478);
            this.Controls.Add(this.btnPerson);
            this.Controls.Add(this.grbFach);
            this.Controls.Add(this.btnSchueler);
            this.Controls.Add(this.btnKlasse);
            this.Controls.Add(this.lblAnzeige);
            this.Controls.Add(this.btnLehrer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StartForm";
            this.Text = "Testformular";
            this.grbFach.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLehrer;
        private System.Windows.Forms.Label lblAnzeige;
        private System.Windows.Forms.Button btnKlasse;
        private System.Windows.Forms.Button btnSchueler;
        private System.Windows.Forms.GroupBox grbFach;
        private System.Windows.Forms.Button btnFach;
        private System.Windows.Forms.Button btnIdent;
        private System.Windows.Forms.ComboBox cboxSchulart;
        private System.Windows.Forms.ComboBox cboxFach;
        private System.Windows.Forms.Button btnPerson;
    }
}

