using System;
using System.Collections.Generic;
using System.Linq;


namespace AdventOfCode.solutions
{

    public static class solution2
    {
        public static System.Collections.Generic.IEnumerable<int> calcFuelValues(int fuelWeight)
        {
            int fuelForFuel = fuelWeight/3 - 2;
            if (fuelForFuel > 0)
                yield return fuelForFuel;
            else
                yield break;
        }
    }

}