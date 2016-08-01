using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.Core;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please provide the client Id (A or B) : ");
            var client = Console.ReadLine();

            IFactory factory;

            if (client == "A")
            {
                factory = new ClientAFactory();
            }
            else if (client == "B")
            {
                factory = new ClientBFactory();
            }
            else
            {
                return;
            }

            var order = new Order();

            Console.WriteLine("How many computers are required...??? :");
            order.Computer = ConvertToInt(Console.ReadLine());

            Console.WriteLine("How many smartphones are required...??? :");
            order.SmartPhone = ConvertToInt(Console.ReadLine());

            Console.WriteLine("How many tablets are required...??? :");
            order.Tablet = ConvertToInt(Console.ReadLine());

            var company = new ManufacturingCompany(factory);
            company.Produce(order);

            Console.WriteLine("Created "  + company.Computers.Count()  + " computers. "  );
            Console.WriteLine("Created "  + company.SmartPhones.Count()  + " smartphones. ");
            Console.WriteLine("Created "  + company.Tablets.Count()  + " tablets. ");

            Console.ReadLine();
        }

        private static int ConvertToInt(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return 0;
            }
            return Int32.Parse(input);
        }
    }
}
