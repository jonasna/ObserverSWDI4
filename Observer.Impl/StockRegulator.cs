using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Observer.Impl.Interfaces;

namespace Observer.Impl
{
    public class StockRegulator : IRegulator
    {
        public void Regulate(object regulateObject)
        {
            throw new NotImplementedException();
        }

        public IRandom RandomNumberGenerator { get; }
    }
}
