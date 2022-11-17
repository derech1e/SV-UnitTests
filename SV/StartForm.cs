using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SV
{
    public partial class StartForm : Form
    {   
        //**************Formularattribute***********************
        //Formularlisten 
        public List<Lehrer> Lehrerliste = new List<Lehrer>();
        public List<Klasse> Klassenliste = new List<Klasse>();
        public List<Schueler> Schuelerliste = new List<Schueler>();
        public List<Person> Personenliste = new List<Person>();
        public List<Fach> Fachliste = new List<Fach>();
        //**************Formularmethoden***********************
        public StartForm()
        {
            InitializeComponent();
        }
        //Schaltflächenmethoden
        private void btnLehrer_Click(object sender, EventArgs e)
        {
            //Objekt instanziieren
            Lehrer le1 = new Lehrer("Rie", "Frau", "Dipl.-Ing.", "Riester", "Antje");
            Lehrer le2 = new Lehrer("Sie", "Frau", "", "Siegel", "Sylvia");
            //in Liste speichern
            Lehrerliste.Add(le1);
            Lehrerliste.Add(le2);
            Personenliste.Add(le1);
            Personenliste.Add(le2);
            
            //Objekte anzeigen
            lblAnzeige.Text = "";
            foreach(Lehrer l in Lehrerliste)
                lblAnzeige.Text += l.ausgeben() + "\n";
        }

        private void btnKlasse_Click(object sender, EventArgs e)
        {
            Klasse kl1 = new Klasse("IGD19", "DuBAS-I", Lehrerliste[1]); //lokal
            Klasse kl2 = new Klasse("IGy22", "BGy");
            Klassenliste.Add(kl1);
            Klassenliste.Add(kl2);
            //Objekte anzeigen
            lblAnzeige.Text = "";
            foreach (Klasse k in Klassenliste)
                lblAnzeige.Text += k.ausgeben();
            //Lehrer der Klasse zuweisen ...
            Klassenliste[1].Lehrer = Lehrerliste[0];
            //... und anzeigen
            lblAnzeige.Text += Klassenliste[1].ausgeben();

        }

        private void btnSchueler_Click(object sender, EventArgs e)
        {
            Schueler s1 = new Schueler("1234", "Herr", "Richter", "Manuel", new DateTime(2002, 03, 13, 0, 0, 0),Klassenliste[0]);
            Schuelerliste.Add(s1);
            Personenliste.Add(s1);
            Schueler s2 = new Schueler("1235", "Frau", "Müller", "Gundula", new DateTime(2005, 12, 06, 0, 0, 0));
            Schuelerliste.Add(s2);
            Personenliste.Add(s2);
            //Objekte anzeigen
            lblAnzeige.Text = "";
            foreach (Schueler s in Schuelerliste)
                lblAnzeige.Text += s.ausgeben();

            //dem Schüler die Klasse zuweisen ...
            Schuelerliste[1].Klasse = Klassenliste[1];
            //... und ausgaben
            lblAnzeige.Text += Schuelerliste[1].ausgeben();
        }

        private void BtnPerson_Click(object sender, EventArgs e)
        {
            Person p1 = new Person("Herr", "Meyer", "Oliver");
            lblAnzeige.Text = p1.ausgeben();
            foreach (Person p in Personenliste)
                lblAnzeige.Text += "\n" + p.ausgeben();
        }

        private void btnIdent_Click(object sender, EventArgs e)
        {
            string eintraege = cboxFach.SelectedItem.ToString();
            eintraege += ";" + cboxSchulart.SelectedItem.ToString();
            Fach f1 = new Fach(eintraege);
            Fachliste.Add(f1);
            //Liste ausgeben
            lblAnzeige.Text = "";
            foreach (Fach f in Fachliste)
                lblAnzeige.Text += f.FachIdent + "\n";
        }

        private void btnFach_Click(object sender, EventArgs e)
        {
            lblAnzeige.Text = "";
            foreach(Fach f in Fachliste)
            {
                lblAnzeige.Text += f.speichern() + "\n";
            }
        }
    }
}
