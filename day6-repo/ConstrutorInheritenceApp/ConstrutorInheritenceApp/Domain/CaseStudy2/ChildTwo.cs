using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstrutorInheritenceApp.Domain.CaseStudy2
{
    internal class ChildTwo : ParentTwo
    {
        public ChildTwo() : base(100)
        {
        }

        public ChildTwo(int myage) : base(myage)
        {
        }


    }

}
