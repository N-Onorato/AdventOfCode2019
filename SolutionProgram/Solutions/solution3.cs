using System;
using System.IO;


namespace AdventOfCode.solutions
{

    class solution3 {

        public static string getAnswer()
        {
            var wireStrings = getStrings();
            Grid answerGrid = new Grid();
            answerGrid.addWire(wireStrings.Item1);
            answerGrid.addWire(wireStrings.Item2);
            return answerGrid.getDistance().ToString();
        }

        public static ValueTuple<string, string> getStrings()
        {
            string firstWire, secondWire;
            string bothWireDefinitions = File.ReadAllText("B:\\OneDrive_Root\\OneDrive\\Documents\\Programming\\CSharp\\AdventOfCode\\SolutionProgram\\data\\day3Input");
            int seperationPoint = bothWireDefinitions.IndexOf('\n');
            firstWire = bothWireDefinitions.Substring(0, seperationPoint - 1);
            secondWire = bothWireDefinitions.Substring(seperationPoint + 1, bothWireDefinitions.Length - seperationPoint - 2);
            return new ValueTuple<string, string>(firstWire, secondWire);
        }
    }








}