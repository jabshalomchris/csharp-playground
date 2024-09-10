using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_playground.Polymorphism
{
    public class DerivedClass : ParentClass
    {
        private string MyVariable = "Derived Class Variable";

        public override  void DoWork()
        {
            Console.WriteLine(MyVariable);
        }
    }
}
