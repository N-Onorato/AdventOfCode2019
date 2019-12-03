
using System;
using System.Linq;
using System.IO;

namespace AdventOfCode.solutions {

    public static class solution1
    {
        public static object calcFuelForModule(int mass)
        {
            return mass / 3 - 2;
        }

        public static int getInputData()
        {   
            var inputStrings = File.ReadLines("data/day1input");
            return int.Parse((from input in inputStrings select input).FirstOrDefault());
        }
    }

}