using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRandomNumberApp.Domain
{
    class RandomNumberGen
    {
        private readonly int randnumber;
        Random random = new Random();

        int randomint = Random.next(0,100);


    }
}
