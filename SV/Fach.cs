using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SV
{
    public class Fach
    {
        public string FachIdent { get; }
        private string Fachbezeichnung;

        public Fach(string fb)
        {
            this.Fachbezeichnung = fb;
            //FachIdent zusammenbasteln
            this.FachIdent = bastelnFID();
        }

        /// <summary>
        /// Methode zur erzeugung der Fach Id
        /// Setzt sich zusammen aus Fach und Schulart
        /// </summary>
        /// <param name="fachBezeichnung">Fachbezeichnung zusammengesetzt aus Fach und Schualrt</param>
        /// <returns>Id nach den Vorgaben der Aufgabe</returns>
        public string bastelnFID()
        {
            var id = new StringBuilder();
            var preSemi = Fachbezeichnung.Split(';')[0];
            var postSemi = Fachbezeichnung.Split(';')[1];
            var schulartDict = new Dictionary<string, string>
        {
            {"Leistungskurs", "LK" },
            {"Grundkurs", "GK" },
            {"Fachoberschule", "FO" },
            {"Berufsschule", "BS" },
            {"Berufsvorbereitung", "BV" },

        };

            if(preSemi.Contains("-"))
            {
                var split = preSemi.Split('-');

                id.Append(split[0].Substring(0, 2));
                id.Append(split[1].Substring(0, 2));


            } else if(preSemi.Contains("/"))
            {
                var split = preSemi.Split('/');

                id.Append(split[0].Substring(0, 2));
                id.Append(split[1].Substring(0, 2));
            } else
            {
                id.Append(preSemi.Substring(0, 4));
            }
            if(schulartDict.TryGetValue(postSemi, out string schulart))
            {
                id.Append(schulart);
            }

            return id.ToString();
        }
        public string speichern()
        {
            return string.Format("INSERT INTO Fach (FID,Bezeichnung) VALUES ('{0}', '{1}');", this.FachIdent, this.Fachbezeichnung);
        }
    }
}