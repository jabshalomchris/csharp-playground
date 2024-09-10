using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_playground.Polymorphism
{
    public class ParentClass
    {
        private string MyVariable = "Parent Class Variable";

        public virtual void DoWork()
        {
            Console.WriteLine(MyVariable);
        }
    }
}
