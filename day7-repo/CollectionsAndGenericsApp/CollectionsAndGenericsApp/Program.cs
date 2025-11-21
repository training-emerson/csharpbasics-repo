using CollectionsAndGenericsApp.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.InteropServices.ObjectiveC;

namespace CollectionsAndGenericsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CaseStudy1();
            //CaseStudy2();
            //CaseStudy3();
            CaseStudy4();
        }

        private static void CaseStudy4()
        {
            var orderBasket = new HashSet<OrderItem>();
            var items1 = new OrderItem {Id = 1, Name = "books", Quantity = 3, UnitPrice = 100};
            var items2 = new OrderItem {Id = 1, Name = "books", Quantity = 3, UnitPrice = 100};

            Console.WriteLine( items1.GetHashCode());
            Console.WriteLine(items2.GetHashCode());
            Console.WriteLine(orderBasket.Count);

            orderBasket.Add(items1);
            orderBasket.Add(items2);
            Console.WriteLine(orderBasket.Count);
            //orderBasket.Add(new OrderItem { Id = 3, Name = "Bread", Quantity = 2, UnitPrice = 23 });

            //orderBasket.Add(new OrderItem { Id = 3, Name = "Bread", Quantity = 2, UnitPrice = 23 });
            //Console.WriteLine(orderBasket.Count);
        }

        private static void CaseStudy3()
        {
            var uniqueNames = new HashSet<string>();
            //HashSet<string> uniqueNames = new HashSet<string>();
            uniqueNames.Add("AG");
            uniqueNames.Add("KK");
            uniqueNames.Add("KK");

            Console.WriteLine(uniqueNames.Count);
            foreach (var name in uniqueNames)
            {
                Console.WriteLine(name);
            }
        }
        private static void CaseStudy2()
        {
            var orderBasket = new List<OrderItem>();
            orderBasket.Add(new OrderItem { Id = 1, Name = "books", Quantity = 3, UnitPrice = 100 });
            orderBasket.Add(new OrderItem { Id = 2, Name = "Amul Milk", UnitPrice = 65, Quantity = 11 });
            orderBasket.Add(new OrderItem { Id = 3, Name = "Bread", Quantity = 2, UnitPrice = 23 });

            double checkoutPrice = 0;
            foreach (OrderItem temp in orderBasket) //no need to cast as it is not an object but a list
            {
                checkoutPrice += temp.TotalCost();
                Console.WriteLine("id " + temp.Id + "name " + temp.Name + "UnitPrice " + temp.UnitPrice + "Quantity" + temp.Quantity);

            }
            Console.WriteLine(checkoutPrice);
        }

        private static void CaseStudy1()
        {
            ArrayList orderBasket = new ArrayList(); //it is creating an array of object
            orderBasket.Add(new OrderItem { Id = 1, Name = "books", Quantity = 3, UnitPrice = 100 });
            orderBasket.Add(new OrderItem { Id = 2, Name = "Amul Milk", UnitPrice = 65, Quantity = 11 });
            orderBasket.Add(new OrderItem { Id = 3, Name = "Bread", Quantity = 2, UnitPrice = 23 });

            //collection not type safe

            double checkoutPrice = 0;
            foreach (object box in orderBasket)
            {
                OrderItem temp = box as OrderItem; //need to case as it is an object
                checkoutPrice += temp.TotalCost();
                Console.WriteLine("id " + temp.Id + "name " + temp.Name + "UnitPrice " + temp.UnitPrice + "Quantity" + temp.Quantity);

            }
            Console.WriteLine(checkoutPrice);
        }
    }
}
