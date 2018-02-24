using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Impl.Interfaces
{
    public interface IStock
    {
        string Navn { get; }
        int Value { get; }
        void DecreaseValue();
        void IncreaseValue();
    }
}
