using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Observer.Impl.Interfaces;

namespace Observer.Impl
{
    public class Stock : Subject, IStock
    {
        Stock(string name, int value, IRegulator stockRegulator)
        {
            try
            {
                Navn = name;
                Value = value;
                Notify();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        public string Navn { get; }
        public int Value { get; private set; }

        public void DecreaseValue()
        {
            try
            {
                Value = (int)(Value * 0.95);
                Notify();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
           
        }

        public void IncreaseValue()
        {
            try
            {
                Value = (int)(Value * 1.05);
                Notify();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
        }
    }
}
