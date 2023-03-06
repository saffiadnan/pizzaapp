using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Pizza;

namespace Pizza
{
    class Order
    {
        //Starter med at oprette properties
        private string _ordreID;
        private string _ordredato;
        public List<Pizza> pizzaer { get; set; }
        private Customer customer;
        private double _totalPris;

        //Opretter nu constructor
        public Order(string ordreID, string ordredato, List<Pizza> pizzaer, Customer customer)
        {
            _ordreID = ordreID;
            _ordredato = ordredato;
            this.pizzaer = pizzaer;
            this.customer = customer;
        }

        public string ordreID
        {
            get { return _ordreID; }
            set { ordreID = value; }
        }
        public string ordredato
        {
            get { return _ordredato; }
            set { _ordredato = value; }
        }
        
        public double totalPris
        {
            get { return _totalPris; }
            set { _totalPris = value; }
        }
        public void printOrder()
        {
            Console.WriteLine("Order number: " + this.ordreID);
            Console.WriteLine("Order date: " + this.ordredato);
            Console.WriteLine("Customer ID: " + this.customer.Kundenummer);
            Console.WriteLine("Customer name: " + this.customer.Kundenavn);


            totalPris = 0;

            for(int i = 0; i < pizzaer.Count; i++)
            {
                Console.WriteLine(pizzaer[i]);
                totalPris = totalPris + pizzaer[i].Getprice();
            }

            double tax = totalPris + 40;
            Console.WriteLine("totale pris: " + tax + " DKK. inkl. 40kr moms");
        }

        //Opretter hermed tostring metode
        public override string? ToString()
        {
            return "ordrenummer: " + _ordreID + "\n" + "ordredato: " + _ordredato + "\n" + "totalpris: " + _totalPris + "\n";
        }
    }
    }

