using System;
using System.Linq;

namespace AdventOfCode.solutions
{
    public class solution2
    {
        public static readonly string dataPath = "B:\\OneDrive_Root\\OneDrive\\Documents\\Programming\\CSharp\\AdventOfCode\\SolutionProgram\\data\\day2input";
        public static int[] integers;

        static solution2() {
            integers = getInputArray(dataPath);
        }

        public static string getAnswer() {
            integers[1] = 12;
            integers[2] = 2;
            processIntCode(integers);
            return integers[0].ToString();
        }

        public static int[] getInputArray(string path)
        {
            string[] integerStrings = System.IO.File.ReadAllText(dataPath).Split(',');
            int[] ints = (from singleString in integerStrings select int.Parse(singleString)).ToArray();
            return ints;
        }

        public static int[] getOpcode(int[] inputArray, int pos)
        {
            int opcodePos = (pos - 1) * 4;
            if(opcodePos >= 0 && opcodePos < inputArray.Length) {
                if(opcodePos < inputArray.Length - 4)
                    return inputArray.AsSpan<int>(opcodePos, 4).ToArray();
                else
                    return inputArray.AsSpan<int>(opcodePos, inputArray.Length - opcodePos).ToArray();
            } else {
                return System.Array.Empty<int>();
            }
        }

        public static int[] processIntCode(int[] intCode)
        {
            for (int i = 1; i <= intCode.Length / 4; ++i) {
                int[] opCode = getOpcode(intCode, i);
                switch(opCode[0]) {
                    case 1:
                        processAdditionOpcode(intCode, opCode[1], opCode[2], opCode[3]);
                        break;
                    case 2:
                        processMultOpcode(intCode, opCode[1], opCode[2], opCode[3]);
                        break;
                    case 99:
                        return intCode;
                    default:
                        throw new System.Exception("Encountered unsupported int code value.");
                }
            }
            return new int[] {};
        }

        private static void processMultOpcode(int[] intCode, int multVal1, int multVal2, int productDestination)
        {
            intCode[productDestination] = intCode[multVal1] * intCode[multVal2];
        }

        private static void processAdditionOpcode(int[] intCode, int addVal1, int addVal2, int sumDestination)
        {
            intCode[sumDestination] = intCode[addVal1] + intCode[addVal2];
        }
    }

}