﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Impl
{
    public interface IRegulator
    {
        void Regulate(object regulateObject);
        IRandom RandomNumberGenerator { get; }
    }
}
