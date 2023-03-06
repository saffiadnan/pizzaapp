using Pizza;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
     class Store
    {
        public void Start()
        {
            Pizza p1 = new Pizza(1, "Margharita ", "Ost", 50) ;
            Pizza p2 = new Pizza(2, "Hawaii ", "Kødboller", 60);
            Pizza p3 = new Pizza(3, "Itiliano ", "Kartoffler og champignon", 75);

            List<Pizza> list = new List<Pizza>();

            list.Add(p1);
            list.Add(p2);
            list.Add(p3);

            Customer kunde = new Customer(1, "Lars Andersen ", "roskildevej ", "Larsandersen@hotmail.com ");
            Order ordre = new Order("1 ", "28-02-2023 ", list, kunde);
            List<Pizza> pizzaList = new List<Pizza>();


            Console.WriteLine("|********** Velkommen til Big Mammas Pizzaria **********|");
            Console.WriteLine("|                                                       |");
            Console.WriteLine("| Select an option from the menu                        |");
            Console.WriteLine("| 1. Add pizza to order                                 |");
            Console.WriteLine("| 2. See order                                          |");
            Console.WriteLine("| 3. See my information                                 |");
            Console.WriteLine("| 4. Exit                                               |");
            Console.WriteLine("|*******************************************************|");

          

            while (true)
            {
                int select = 0;
                Console.Write("Please select a number: ");
                select = Convert.ToInt32(Console.ReadLine());

                if (select == 1)
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        Console.WriteLine(list[i].ID + " : " + list[i].navn);
                    }
                    Console.Write("Choose a pizza by number:");
                    int pizzaId = Convert.ToInt32(Console.ReadLine());

                    pizzaList.Add(list[pizzaId - 1]);
                    ordre.pizzaer = pizzaList;
                }

                if (select == 2)
                {
                    ordre.printOrder();
                }

                if(select == 3)
                {
                    Console.WriteLine(kunde);
                }

                if (select == 4)
                {
                    Console.WriteLine("Exit");
                    break;
                }

                Console.WriteLine();
            }

        }
    }
        
    }


