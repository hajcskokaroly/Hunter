using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hunter
{
    abstract class Animal
    {
        const double basePrice = 100000;

        public new virtual string GetType() { return " pémének ára: "; }

        public virtual double getPrice() { return basePrice; }
    }
}
