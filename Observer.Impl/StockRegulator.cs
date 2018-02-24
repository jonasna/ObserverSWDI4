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
        private bool _running;

        public StockRegulator(IRandom randomNumberGenerator, IStock stock)
        {
            _randomNumberGenerator = randomNumberGenerator;
            _stock = stock;
            _regulatorThread = new Thread(Regulate);
            _running = false;
        }
        private void Regulate()
        {
            do
            {
                if (_randomNumberGenerator.GenerateRandom(1, 3) == 1)
                    _stock.IncreaseValue();
                else
                    _stock.DecreaseValue();

                Thread.Sleep(5000);

            } while (_running);
        }

        public void Start()
        {
            _running = true;
            _regulatorThread.Start();
        }

        public void Stop()
        {
            _running = false;
            _regulatorThread.Abort();
        }
    }
}
