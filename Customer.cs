using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza
{
    class Customer
    {
        //Jeg vil starte med at oprette properties)
        private int _Kundenummer;
        private string _Kundenavn;
        private string _Kundeadresse;
        private string _Kundeemail;

        //Nu vil jeg sætte constructor på for at man kan genkende objekterne som er properties.
        public Customer(int Kundenummer, string Kundenavn, string Kundeadresse, string Kundeemail)
        {
            _Kundenummer = Kundenummer;
            _Kundenavn = Kundenavn;
            _Kundeadresse = Kundeadresse;
            _Kundeemail = Kundeemail;
        }

        public string Kundenavn
        {
            get { return _Kundenavn; }
            set { _Kundenavn = value; }
        }
        public string Kundeadresse
        {
            get { return _Kundeadresse; }
            set { _Kundeadresse = value; }
        }
        public string Kundeemail
        {
            get { return _Kundeemail; }
            set { _Kundeemail = value; }
        }
        public int Kundenummer
        {
            get { return _Kundenummer; }
            set { _Kundenummer = value; }
        }


        //Nu vil jeg oprette tostring metode
        public override string ToString()
        {
            return "Navn: " + Kundenavn + "\n" + "Adresse: " + Kundeadresse + "\n" + "Kundenummer: " + _Kundenummer + "\n" + "Email: " + Kundeemail;
        }
}
}
