using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_playground.Polymorphism
{
    public class Apple : IFruit
    {
        public string GetColour()
        {
            return "RED";
        }
    }
}
