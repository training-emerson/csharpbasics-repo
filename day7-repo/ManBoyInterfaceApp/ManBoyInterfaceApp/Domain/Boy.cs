using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManBoyInterfaceApp.Domain
{
    internal class Boy : IMannerable, IEmotionable
    {
        public void Cry()
        {
            Console.WriteLine( "Boy is crying"); 
        }

        public void Depart()
        {
            Console.WriteLine( "Boy is leaving"); 
        }

        public void Laugh()
        {
            Console.WriteLine( "Boy is laughing...");
        }

        public void Wish()
        {
            Console.WriteLine( "Boy is saying Hello..");
        }

        public void Play()
        {
            Console.WriteLine("Boy is playing..");
        }

    }
}
