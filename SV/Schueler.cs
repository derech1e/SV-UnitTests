using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SV
{
    public class Schueler : Person
    {
        //Attribute
        private string SchuelerIdent;
        //private string Anrede;
        //private string Name;
        //private string Vorname;
        private DateTime Geburtsdatum;
        Klasse Klassenbezeichnung;

        //Methoden
        //ctor mit Klasse
        public Schueler(string Id, string a, string n, string vn, DateTime gebdat, Klasse kb):base(a,n,vn)
        {
            SchuelerIdent = Id;
            //Anrede = a;
            //Name = n;
            //Vorname = vn;
            Geburtsdatum = gebdat;
            Klassenbezeichnung = kb;
        }
        //ctor ohne Klasse
        public Schueler(string Id, string a, string n, string vn, DateTime gebdat):base(a,n,vn)
        {
            SchuelerIdent = Id;
            //Anrede = a;
            //Name = n;
            //Vorname = vn;
            Geburtsdatum = gebdat;
            Klassenbezeichnung = new Klasse();
        }
        //Klasse zuordnen und ausgeben
        public Klasse Klasse
        {
            get => Klassenbezeichnung;
            set
            {
                Klassenbezeichnung = value;
            }
        }
        //Schülerobjekt als String ausgeben
        public override string ausgeben()
        {
            string ausgabe = "Schüler: ";
            ausgabe += SchuelerIdent;
            ausgabe += "\n" + base.ausgeben();//vererbte Methode ausgeben() nutzen
            ausgabe += "Geburtsdatum: " + Geburtsdatum.ToString("dd.MM.yyyy") + "\n";
            //Anpassung der Ausgabe, 
            if (Klassenbezeichnung.Bezeichnung != "")
                ausgabe += Klassenbezeichnung.ausgeben() + "\n"; //wenn Klasse zugewiesen
            else
                ausgabe += "keine Klassenzuordnung!!\n"; //wenn keine Klasse zugewiesen wurde
            return ausgabe;
        }
    }
}