using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternTechStore
{
    class Samsung : TechStore_AbstractFactory
    {
        public override SmartPhone CreateSmartPhone()
        {
            return new SamsungSmartPhone();
        }

        public override SmartWatch CreateSmartWatch()
        {
            return new SamsungSmartWatch();
        }
    }
}
