using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SV
{
    public class Klasse
    {
        private string Klassenbezeichnung;
        private string Ausbildungsrichtung;
        private Lehrer Klassenlehrer;
        
        //ctor für leere Klasse
        public Klasse()
        {
            Klassenbezeichnung = "";
            Ausbildungsrichtung = "";
            Klassenlehrer = new Lehrer();
        }
        //ctor mit 2 Parametern
        public Klasse(string kb, string ar)
        {
            Klassenbezeichnung = kb;
            Ausbildungsrichtung = ar;
            Klassenlehrer = new Lehrer();
        }
        //ctor mit 3 Parametern
        public Klasse(string kb, string ar, Lehrer kl)
        {
            Klassenbezeichnung = kb;
            Ausbildungsrichtung = ar;
            Klassenlehrer = kl;
        }

        public Lehrer Lehrer
        {
            get => Klassenlehrer;
            set
            {
                Klassenlehrer = value;
            }
        }

        public string Bezeichnung
        {
            get => Klassenbezeichnung;
            set
            {
            }
        }

        //Klassenobjekt als String ausgeben
        public string ausgeben()
        {
            String ausgabe = "Klasse: ";
            ausgabe += Klassenbezeichnung;
            ausgabe += "\n" + Ausbildungsrichtung + "\n";
            //Anpassung der Ausgabe, 
            if (Klassenlehrer.Lehrerkuerzel == "unbekannt")
                ausgabe += "kein Lehrer zugeordnet!!\n"; //wenn kein Lehrer zugewiesen
            else
                ausgabe += "Klassenlehrer: " + Klassenlehrer.ausgeben() + "\n"; //wenn Lehrer zugewiesen wurde
            return ausgabe;
        }
    }
}