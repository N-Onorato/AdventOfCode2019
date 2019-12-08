

using System;
using System.Linq;
using System.Threading.Tasks;


namespace AdventOfCode.solutions {


    public static class solution4 {
        public static string getAnswer() {
            int count = 0;
            System.Threading.Tasks.Parallel.For(136818, 685980, (n) => {
                    if(isValidNumber(n))
                        System.Threading.Interlocked.Increment(ref count);
            });
            return count.ToString();
        }

        public static bool isValidNumber(int number) {
            if(number > 136818 && number <= 685979) {
                return pairsAreValid(number);
            } else {
                return false;
            }
        }

        private static bool pairsAreValid(int number)
        {
            bool foundAdjacentPair = false;
            var numbers = number.ToString().ToCharArray();
            for(int i = 0; i < numbers.Length -1; i++) {
                int firstDigit = Convert.ToInt16(numbers[i]);
                int secondDigit = Convert.ToInt16(numbers[i+1]);
                if (firstDigit == secondDigit)
                    foundAdjacentPair = true;
                if (secondDigit < firstDigit)
                    return false;
            }
            if(foundAdjacentPair)
                return true;
            else
                return false;
        }
    }

}