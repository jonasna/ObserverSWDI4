using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Impl
{
    public interface IStock
    {
        string Navn { get; set; }
        int Value { get; set; }
        void DecreaseValue();
        void IncreaseValue();
    }
}
