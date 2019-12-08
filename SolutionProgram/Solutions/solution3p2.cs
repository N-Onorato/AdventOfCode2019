namespace AdventOfCode.solutions
{
    class solution3p2 {

        public static string getAnswer() {
            Grid fancyGrid = new Grid();
            var wireStrings = solution3.getStrings();
            fancyGrid.addWire(wireStrings.Item1);
            fancyGrid.addWire(wireStrings.Item2);
            int answer = fancyGrid.getMinSteps();
            return answer.ToString();
        }
        
    }








}