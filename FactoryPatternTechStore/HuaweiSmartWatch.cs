using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternTechStore
{
    class HuaweiSmartWatch : SmartWatch
    {
        public string Model { get; set; }
        public int Price { get; set; }
        public HuaweiSmartWatch()
        {
            Model = "Huawei ProWatch";
            Price = 700;
        }
    }
}
