using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternTechStore
{
    class HuaweiSmartPhone:SmartPhone
    {
        public HuaweiSmartPhone()
        {
            Model = "Huawei Mate Pro 30";
            Price = 1800;
        }
        public string Model { get; set; }
        public int Price { get; set; }

    }
}
