using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Observer.Impl;

namespace Observer.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            var display = new PortefolieDisplay();
            var portfolio = new PorteFolio(display);
            var AppleStock = new Stock("Apple", 100);
            var GoogleStock = new Stock("Google", 2000);

            portfolio.AddStock(AppleStock, 15);
            portfolio.AddStock(GoogleStock, 1000);

            AppleStock.StartRegulate();
            GoogleStock.StartRegulate();

            while (true)
            {
                Thread.Sleep(4000);
            }
        }
    }
}
