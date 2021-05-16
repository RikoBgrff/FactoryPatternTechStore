using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternTechStore
{
   abstract class TechStore_AbstractFactory
    {
        public abstract SmartPhone CreateSmartPhone();
        public abstract SmartWatch CreateSmartWatch();
    }
}
