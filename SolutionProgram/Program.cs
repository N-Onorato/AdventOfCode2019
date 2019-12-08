using System;
using System.Threading.Tasks;
using System.Linq;

namespace AdventOfCode
{

    class console {
        static void Main() {
            var myWatch = new System.Diagnostics.Stopwatch();
            myWatch.Start();
            
            Task<string>[] tasks = new Task<string>[8];
            tasks[0] = Task<string>.Run(solutions.solution1.getAnswer);
            tasks[1] = Task<string>.Run(solutions.solution1p2.getAnswer);
            tasks[2] = Task<string>.Run(solutions.solution2.getAnswer);
            tasks[3] = Task<string>.Run(solutions.solution2p2.getAnswer);
            tasks[4] = Task<string>.Run(solutions.solution3.getAnswer);
            tasks[5] = Task<string>.Run(solutions.solution3p2.getAnswer);
            tasks[6] = Task<string>.Run(solutions.solution4.getAnswer);
            tasks[7] = Task<string>.Run(solutions.solution4p2.getAnswer);
            
            Task.WaitAll(tasks);

            Console.WriteLine($"The answer to December 1st is: {tasks[0].Result} and {tasks[1].Result}");
            Console.WriteLine($"The answer to December 2nd is: {tasks[2].Result} and part 2 is {tasks[3].Result}");
            Console.WriteLine($"The answer to December 3rd is: {tasks[4].Result} and part 2 is {tasks[5].Result}");
            Console.WriteLine($"The answer to December 4th is: {tasks[6].Result} and part 2 is {tasks[7].Result}");
            myWatch.Stop();
            Console.WriteLine($"Solutions Took: {myWatch.ElapsedMilliseconds} ms to complete.");
        }
    }

}
