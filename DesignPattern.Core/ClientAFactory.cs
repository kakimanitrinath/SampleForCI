using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core
{
    public class ClientAFactory : IFactory
    {
        public IComputer CreateComputer()
        {
            return  new ClientAComputer();
        }

        public ISmartPhone CreateSmartPhone()
        {
            return new ClientASmartPhone();
        }

        public ITablet CreateTablet()
        {
            return new ClientATablet();
        }
    }
}
