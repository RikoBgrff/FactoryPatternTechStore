using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternTechStore
{
    class SamsungSmartPhone : SmartPhone
    {
        public SamsungSmartPhone()
        {
            Model = "Galaxy S10";
            Price = 2000;
        }
        public string Model { get; set; }
        public int Price { get; set; }
    }
}
