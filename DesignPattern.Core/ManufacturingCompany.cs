using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core
{
    public class ManufacturingCompany
    {
        private readonly IFactory _factory;
        private readonly List<IComputer> _computers;
        private readonly List<ISmartPhone> _smartPhones;
        private readonly List<ITablet> _tablets;

        public IEnumerable<IComputer> Computers
        {
            get { return _computers.ToArray(); }
        }

        public IEnumerable<ISmartPhone> SmartPhones
        {
            get { return _smartPhones.ToArray(); }
        }

        public IEnumerable<ITablet> Tablets
        {
            get { return _tablets.ToArray(); }
        }

        public ManufacturingCompany(IFactory factory)
        {
            _factory = factory;
            _computers = new List<IComputer>();
            _smartPhones = new List<ISmartPhone>();
            _tablets = new List<ITablet>();
        }

        public void Produce(Order order)
        {
            CreateComputers(order.Computer);
            CreateSmartPhones(order.SmartPhone);
            CreateTablets(order.Tablet);
        }

        private void CreateComputers(int count)
        {
            while (_computers.Count < count)
            {
                _computers.Add(_factory.CreateComputer());
            }
        }

        private void CreateSmartPhones(int count)
        {
            while (_smartPhones.Count < count)
            {
                _smartPhones.Add(_factory.CreateSmartPhone());
            }
        }

        private void CreateTablets(int count)
        {
            while (_tablets.Count < count)
            {
                _tablets.Add(_factory.CreateTablet());
            }
        }
    }
}
