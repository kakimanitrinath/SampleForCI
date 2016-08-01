using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core
{
    public class ClientBFactory : IFactory
    {
        public IComputer CreateComputer()
        {
            return new ClientBComputer();
        }

        public ISmartPhone CreateSmartPhone()
        {
            return new ClientBSmartPhone();
        }

        public ITablet CreateTablet()
        {
            return new ClientBTablet();
        }
    }
}
