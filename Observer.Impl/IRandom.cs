using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Impl
{
    public interface IRandom
    {
        int GenerateRandom(int min, int max);
    }
}
