using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Observer.Impl.Interfaces;

namespace Observer.Impl
{
    public class DefaultRandom : IRandom
    {
        private int Result { get; }

        public DefaultRandom(int min, int max)
        {
            Result = GenerateRandom(min, max);
        }
        public int GenerateRandom(int min, int max)
        {
                int result = 0;
                Random tempRandom = new Random();
                result = tempRandom.Next(min, max);
                return result;
        }

        public int GetResult => Result;
    }
}
