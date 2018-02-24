using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Observer.Impl.Interfaces;


namespace Observer.Impl
{
    public class PorteFolio : IObserver, IPortfolio
    {
        private readonly List<Ownstock> _myOwnStock = new List<Ownstock>();
        private readonly IPortfolioDisplay _myDisplay;

        public List<Ownstock> MyOwnStocks
        {
            get { return _myOwnStock; }
        }

        public PorteFolio(IPortfolioDisplay Disp)
        {
            _myDisplay = Disp;
        }

        public void Update(Subject subject)
        {
            var stock = (IStock) subject;

            foreach (var item in _myOwnStock)
            {
                if (item.Name.Contains(stock.Navn))
                {
                    item.Value = stock.Value;
                }
            }

            _myDisplay.Print(this);
        }

        public int TotalStockValue
        {
            get
            {
                int sum = 0;
                foreach (var Item in _myOwnStock)
                {
                    sum = (Item.Value * Item.Amount) + sum;
                }

                return sum;
            }
        }

        public void AddStock(IStock stock, int amount)
        {
            var subject = (Subject) stock;
            subject.Attach(this);

            ;
            var mystock = new Ownstock
            {
                Amount = amount,
                Name = stock.Navn,
                Value = stock.Value
            };

            _myOwnStock.Add(mystock);
        }
    }
}
