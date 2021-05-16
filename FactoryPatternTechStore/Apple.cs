using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternTechStore
{
    class Apple:TechStore_AbstractFactory
    {
        public override SmartPhone CreateSmartPhone()
        {
            return new AppleSmartPhone();
        }

        public override SmartWatch CreateSmartWatch()
        {
            return new AppleSmartWatch();
        }

    }
}
