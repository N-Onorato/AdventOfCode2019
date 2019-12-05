using System;


namespace AdventOfCode.solutions {

    public class solution2p2 {

        public static string getAnswer() {
            IntCodeComputer computer = new IntCodeComputer(solution2.dataPath);
            for(int noun = 0; noun < 100; noun++) {

                for(int verb = 0; verb < 100; verb++) {

                    computer.setCodeElement(1, noun);
                    computer.setCodeElement(2, verb);
                    computer.processIntCode();
                    if(computer.getOutput() == 19690720) {
                        return $"noun: {noun} \t verb: {verb} \t answer: {100 * noun + verb}";
                    } else {
                        computer.reset();
                    }

                }
            }
            return "answer could not be found";
        }


    }



}