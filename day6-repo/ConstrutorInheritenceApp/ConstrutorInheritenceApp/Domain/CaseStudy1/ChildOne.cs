using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstrutorInheritenceApp.Domain.CaseStudy1
{
    internal class ChildOne : ParentOne
    {
        public ChildOne() : base()
        {
            Console.WriteLine("Child Created");
        }
    }
}
