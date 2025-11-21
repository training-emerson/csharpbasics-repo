using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManBoyInheritanceApp.Domain
{
    internal class NewBorn:Boy
    {
        public override void Play()
        {
            Console.WriteLine("New Born is playing");
        }

    }
}
