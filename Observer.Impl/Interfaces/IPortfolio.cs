using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Impl.Interfaces
{
    public interface IPortfolio
    {
        List<Ownstock> MyOwnstocks { get; }

        int TotalStockValue { get; }
        
        IPortfolioDisplay Disp { get; }

        void AddStock(IStock stock, int Amount);

    }
}
