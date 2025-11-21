using ContactManagerAppV1.Domain;
using System;
using System.Collections.Generic;

namespace ContactManagerAppV1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var contactList = new List<Contact>();
            contactList.Add(new Contact { Id = 1, Email = "Krishna.kant@live.com", Name = "Krishna", Phone = 888888888 });
            contactList.Add(new Contact { Id = 2, Email = "Krishna.kant1@live.com", Name = "Krishna", Phone = 888888888 });
            contactList.Add(new Contact { Id = 3, Email = "Krishna.kant2@live.com", Name = "Krishna", Phone = 888888888 });

            Console.WriteLine("Welcome to my ContactList");
            foreach (Contact temp in contactList)
            {
                Console.WriteLine($" 1>{temp.Id}, name {temp.Name} with phone Number {temp.Phone} and email {temp.Email}");
            }
        }
    }
}
