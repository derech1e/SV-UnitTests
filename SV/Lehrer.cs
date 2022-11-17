using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SV
{
    public class Lehrer : Person
    {
        //Attribute
        public string Lehrerkuerzel { get; private set; }//Alternative zu separatem Accessor
        //private string Anrede;
        private string Titel;
        //private string Name;
        //private string Vorname;

        public Lehrer():base()
        {
            Lehrerkuerzel = "unbekannt";
            //Anrede = "";
            Titel = "";
            //Name = "";
            //Vorname = "";
        }

        //ctor
        public Lehrer(string lk, string a, string t, string n, string vn):base(a,n,vn)
        {
            Lehrerkuerzel = lk;
            //Anrede = a;
            Titel = t;
            //Name = n;
            //Vorname = vn;
        }

        //public string Kuerzel
        //{
        //    get => Lehrerkuerzel;
        //    set
        //    {
        //    }
        //}

        //Ausgabemethode für Objektinhalt
        public override string ausgeben()
        {
            string ausgabe = "Lehrer: ";
            ausgabe += Lehrerkuerzel + "\n";
            if (Titel.Trim() != "") ausgabe += Titel + " "; //Titel existiert
            ausgabe += base.ausgeben();//vererbte Methode der Klasse Person
            return ausgabe;
        }
    }
}