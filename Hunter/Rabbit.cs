using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hunter
{
    internal class Rabbit:Animal
    {
        const double rabitFactor = 0.3;
        const string type = "nyúl";

        public override string GetType()
        {
            return type+ base.GetType();
        }

        public override double getPrice()
        {
            return base.getPrice()*rabitFactor ;
        }
    }
}
