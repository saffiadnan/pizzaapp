using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Pizza
{
    class Pizza
    {
        //Starter med at oprette properties
        private string _navn;
        private string _topping;
        private double pris;
        public int ID { get; set; }

        //Opretter nu constructor
        public Pizza(int ID, string navn, string topping, double pris)

        {
            this.ID = ID;
            _navn = navn;
            _topping = topping;
            this.pris = pris;


        }

        public string navn
        {
            get { return _navn; }
            set { _navn = value; }
        }
        public string topping
        {
            get { return _topping; }
            set { topping = value; }
        }
        public void Setprice(double pris)
        {
            this.pris = pris;
        }
        public double Getprice()
        {
            return pris;
        }
        //Opretter nu tostring metode
        public override string ToString()
        {
            return "\n" + "Ordre: " + _navn + "with " + _topping + "\n" + "Pris: " + this.pris + "DKK";
        }

    }
}
