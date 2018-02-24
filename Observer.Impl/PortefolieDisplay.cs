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
        public void Print(List<Ownstock> mySOwnstocks)
        {
            Console.WriteLine("Your portefolie includes the following stocks: ");
            foreach (var item in mySOwnstocks)
            {
                Console.WriteLine("Name: " + item.Name + "\t Value: " + item.Value + "\t Amount: " + item.Amount );
            }
        }
    }
}
