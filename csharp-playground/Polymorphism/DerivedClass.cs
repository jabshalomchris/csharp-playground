using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_playground.Polymorphism
{
    public class DerivedClass : ParentClass
    {
        public new void DoWork()
        {
            Console.WriteLine("Invoked from Derived");
        }
    }
}
