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
        public void Update(Subject subject)
        {
            var stock = (IStock) subject;

            foreach (var item in _myOwnStock)
            {
                if (item.Name.Contains(stock.Navn))
                {
                    item.Value = stock.Value;
                }
                else
                {
                    Console.WriteLine("Stock not in Portefolio");
                }

            }

        }

        public int TotalStockValue
        {
            get
            {
                int sum = 0;
                foreach (var Item in _myOwnStock)
                {
                    
                    sum = Item.Value + sum;
                    
                }

                return sum;


            }
        }

        public void AddStock(IStock stock, int amount)
        {
            Ownstock mystock = new Ownstock();
            mystock.Amount = amount;
            mystock.Name = stock.Navn;
            mystock.Value = stock.Value;
            _myOwnStock.Add(mystock);
            

        }

        
    }

    
}
