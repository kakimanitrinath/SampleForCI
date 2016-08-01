﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core
{
    public interface IFactory
    {
        IComputer CreateComputer();
        ISmartPhone CreateSmartPhone();
        ITablet CreateTablet();
    }
}
