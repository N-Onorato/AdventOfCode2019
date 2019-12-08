using System;
using System.Linq;

namespace AdventOfCode
{

    class console {
        static void Main() {
            Console.WriteLine($"The answer to December 1st is: {solutions.solution1.getAnswer()} and {solutions.solution1p2.getAnswer()}");
            Console.WriteLine($"The answer to December 2nd is: {solutions.solution2.getAnswer()} and part 2 is {solutions.solution2p2.getAnswer()}");
            Console.WriteLine($"The answer to December 3rd is: {solutions.solution3.getAnswer()} and part 2 is {solutions.solution3p2.getAnswer()}");
        }
    }

}
