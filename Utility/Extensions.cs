using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility
{
    public static class Extensions
    {
        public static bool IsOdd(this int i)
        {
            return i % 2 > 0;
        }
    }
}
