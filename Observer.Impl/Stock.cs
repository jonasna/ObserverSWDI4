using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using Observer.Impl.Interfaces;

namespace Observer.Impl
{
    public class Stock : Subject, IStock
    {
        private readonly IRegulator _stockRegulator;

        public Stock(string name, int value, IRegulator stockRegulator = null)
        {
            Navn = name;
            Value = value;
            if (stockRegulator == null)
            {
                _stockRegulator = new StockRegulator(new DefaultRandom(1,3), this);
            }
            else _stockRegulator = stockRegulator;
        }
        public string Navn { get; }
        public int Value { get; private set; }

        public void DecreaseValue()
        {
            Value = (int)(Value * 0.95);
            Notify();
        }

        public void IncreaseValue()
        {
            Value = (int)(Value * 1.05);
            Notify();
        }

        public void StartRegulate()
        {
            try
            {
                _stockRegulator.Start();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
        }

        public void StopRegulate()
        {
            try
            {
                _stockRegulator.Stop();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
