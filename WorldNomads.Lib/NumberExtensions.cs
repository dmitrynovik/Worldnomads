using System;
using System.Collections.Generic;

namespace WorldNomads.Lib
{
    static class NumberExtensions
    {
        public static bool IsMultipleOf(this int n, int divisor)
        {
            int p = n / divisor;
            return n == (p * divisor);
        }
    }
}
