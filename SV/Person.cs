using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SV
{
    public class Person
    {
        private string Anrede;
        private string Name;
        private string Vorname;

        public Person()
        {
            Anrede = "";
            Name = "unbekannt";
            Vorname = "";
        }

        public Person(string anrede, string name, string vorname)
        {
            //Prüfung auf NULL
            Anrede = anrede ?? throw new ArgumentNullException(nameof(anrede));
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Vorname = vorname ?? throw new ArgumentNullException(nameof(vorname));
        }
        //Ausgabe
        public virtual string ausgeben()
        {
            string ausgabe = "";
            ausgabe += Anrede + " " + Vorname + " " + Name + "\n";
            return ausgabe;
        }
    }
}