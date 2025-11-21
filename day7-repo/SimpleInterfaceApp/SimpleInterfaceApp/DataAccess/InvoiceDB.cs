using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInterfaceApp.DataAccess
{
    internal class InvoiceDB : ICrudable
    {
        public void Create()
        {
            Console.WriteLine( "Invoice Created");
        }

        public void Delete()
        {
            Console.WriteLine( "Invoice Deleted");
        }

        public void Read()
        {
            Console.WriteLine("Invoice Read");
        }

        public void Update()
        {
            Console.WriteLine("Invoice Updated");
        }
    }
}
