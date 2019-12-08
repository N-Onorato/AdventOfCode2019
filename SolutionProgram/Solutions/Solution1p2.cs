using System;
using System.Collections.Generic;
using System.Linq;


namespace AdventOfCode.solutions
{

    public static class solution1p2
    {

        public static string getAnswer() {
            var ModuleWeights = solution1.getInputAsEnum(solution1.dataPath);
            var sum = 0;
            foreach(string module in ModuleWeights)
            {
               int weight = int.Parse(module);
               int fuelForModule = solution1.calcFuelForModule(weight);
               int fuelForFuel = calcFuelValues(fuelForModule).Sum();
               sum += fuelForModule + fuelForFuel; 
            }
            return sum.ToString();
        }

        public static int getFuelNeededForFuel(int inputFuel) {
            var fuelValues = calcFuelValues(inputFuel);
            return fuelValues.Sum();
        }
        public static IEnumerable<int> calcFuelValues(int fuelWeight)
        {
            int fuelForFuel = fuelWeight;
            while(fuelForFuel >= 6) {
                fuelForFuel = fuelForFuel/3 - 2;
                yield return fuelForFuel;
            }
            yield break;
        }

    }

}