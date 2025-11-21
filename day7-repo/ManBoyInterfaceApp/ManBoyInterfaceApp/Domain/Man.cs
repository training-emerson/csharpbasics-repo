using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManBoyInterfaceApp.Domain
{
    internal class Man : IMannerable
    {
        public void Depart()
        {
            Console.WriteLine( "Man says good bye..");
        }

        public void Wish()
        {
            Console.WriteLine( "Man says hello...");
        }

        public void Read()
        { Console.WriteLine("Man reads book"); }
    }
}
