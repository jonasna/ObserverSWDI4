using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Observer.Impl.Interfaces;

namespace Observer.Impl
{
    class DefaultRandom : IRandom
    {
        public int GenerateRandom(int min, int max)
        {
                int result;
                Random tempRandom = new Random();
                result = tempRandom.Next(min, max);
                return result;
        } 
    }
}
