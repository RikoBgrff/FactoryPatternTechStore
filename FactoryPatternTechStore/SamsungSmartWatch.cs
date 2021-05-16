using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternTechStore
{
    class SamsungSmartWatch : SmartWatch
    {
        public SamsungSmartWatch()
        {
            Model = "Galaxy Watch";
            Price = 1100;
        }

        public string Model { get; set; }
        public int Price { get; set; }
    }
}
