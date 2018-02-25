using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Impl.Interfaces
{
    public interface IPortfolio
    {
        int TotalStockValue { get; }

        void AddStock(IStock stock, int amount);
    }
}
