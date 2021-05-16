using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternTechStore
{
    class Huawei : TechStore_AbstractFactory
    {
        public override SmartPhone CreateSmartPhone()
        {
            return new HuaweiSmartPhone();
        }

        public override SmartWatch CreateSmartWatch()
        {
            return new HuaweiSmartWatch();
        }
    }
}
