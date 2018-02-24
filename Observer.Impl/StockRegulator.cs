using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Observer.Impl.Interfaces;

namespace Observer.Impl
{
    public class StockRegulator : IRegulator
    {
        private readonly IRandom _randomNumberGenerator;
        private readonly IStock _stock;
        private readonly Thread _regulatorThread;

        public StockRegulator(IRandom randomNumberGenerator, IStock stock)
        {
            _randomNumberGenerator = randomNumberGenerator;
            _stock = stock;
            _regulatorThread = new Thread(Regulate);
        }
        private void Regulate()
        {
            if(_randomNumberGenerator.GenerateRandom(1,3) == 1)
                _stock.IncreaseValue();
            else
                _stock.DecreaseValue();
        }

        public void Start()
        {
            _regulatorThread.Start();
        }

        public void Stop()
        {
            _regulatorThread.Abort();
        }
    }
}
