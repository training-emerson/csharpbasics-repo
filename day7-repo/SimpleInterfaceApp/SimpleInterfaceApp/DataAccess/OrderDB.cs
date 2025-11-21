using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInterfaceApp.DataAccess
{
    internal class OrderDB : ICrudable
    {
        public void Create()
        {
            Console.WriteLine( "Order Created");
        }

        public void Delete()
        {
            Console.WriteLine( "Order Deleted");
        }

        public void Read()
        {
            Console.WriteLine( "Order Read");
        }

        public void Update()
        {
            Console.WriteLine( "Order Updated");
        }
    }
}
