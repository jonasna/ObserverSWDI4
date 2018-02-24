using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Impl
{
    public interface IPortfolio
    {
        List<Ownstock> MyOwnstocks { get; set; }

        int totalStockValue { get; set; }
        
        IPortfolioDisplay disp { get; set; }

        IStock AddStock(IStock stock, int Amount);

    }
}
