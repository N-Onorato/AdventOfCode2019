using System;

namespace AdventOfCode.solutions
{
    public static class solution4p2
    {

        public static string getAnswer()
        {
            int count = 0;
            for (int i = 136818; i <= 685979; i++)
            {
                if (isValidNumberV2(i))
                    count++;
            }
            return count.ToString();
        }

        public static bool isValidNumberV2(int number)
        {
            if (number > 136818 && number <= 685979)
            {
                return pairsAreValidV2(number);
            }
            else
            {
                return false;
            }
        }

        private static bool pairsAreValidV2(int number)
        {
            bool foundAdjacentPair = false;
            var numbers = number.ToString().ToCharArray();
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int firstDigit = Convert.ToInt16(numbers[i]);
                int secondDigit = Convert.ToInt16(numbers[i + 1]);
                if (firstDigit == secondDigit)
                {
                    if (i > 0 && i < numbers.Length - 2 && !foundAdjacentPair)
                    {
                        foundAdjacentPair = Convert.ToInt16(numbers[i - 1]) != firstDigit &&  Convert.ToInt16(numbers[i + 2]) != secondDigit;
                    }
                    else
                    {
                        if (i == 0)
                            foundAdjacentPair = Convert.ToInt16(numbers[i + 2]) != secondDigit;
                        if (i == numbers.Length - 2 && !foundAdjacentPair)
                            foundAdjacentPair = Convert.ToInt16(numbers[i - 1]) != firstDigit;
                    }
                }
                if (secondDigit < firstDigit)
                    return false;
            }
            if (foundAdjacentPair)
                return true;
            else
                return false;
        }
    }
}