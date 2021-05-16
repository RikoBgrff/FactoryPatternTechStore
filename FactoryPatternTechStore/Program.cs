using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternTechStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose your Vendor:");
            Console.WriteLine("Apple: 'A'");
            Console.WriteLine("Samsung: 'S'");
            Console.WriteLine("Huawei: 'H'");
            Console.Write("Choice:"); string choice = Console.ReadLine();
            TechStore_AbstractFactory abstractFactory = null;
            if (choice == "S")
            {
                abstractFactory = new Samsung();
            }
            else if (choice == "A")
            {
                abstractFactory = new Apple();
            }
            else if (choice == "H")
            {
                abstractFactory = new Huawei();
            }
            Console.WriteLine(abstractFactory.CreateSmartPhone().Model);
            Console.WriteLine(abstractFactory.CreateSmartPhone().Price);
            Console.WriteLine(abstractFactory.CreateSmartWatch().Model);
            Console.WriteLine(abstractFactory.CreateSmartWatch().Price);
        }

    }
}
