using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternTechStore
{
    class AppleSmartPhone : SmartPhone
    {
        public AppleSmartPhone()
        {
            Model = "IPhone 12 Pro Max";
            Price = 2670;
        }
        public string Model { get; set; }
        public int Price { get; set; }
    }
}
