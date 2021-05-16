using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternTechStore
{
    class AppleSmartWatch : SmartWatch
    {
        public AppleSmartWatch()
        {
            Model = "IWatch";
            Price = 1700;
        }
        public string Model { get; set; }
        public int Price   { get; set; }
    }
}
