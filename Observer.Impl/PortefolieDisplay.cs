using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Observer.Impl.Interfaces;

namespace Observer.Impl
{
    public class PortefolieDisplay : IPortfolioDisplay
    {
        public void Print(PorteFolio myPortefolio)
        {
            Console.WriteLine("Your portefolio has a total value of: " + myPortefolio.TotalStockValue + " and includes the following stocks: ");
            foreach (var item in myPortefolio.MyOwnStocks)
            {
                Console.WriteLine("Name: " + item.Name + "\t Value: " + item.Value + "\t Amount: " + item.Amount );
            }
        }
    }
}
