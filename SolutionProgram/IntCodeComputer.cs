using System;
using System.Linq;

namespace AdventOfCode
{
    public class IntCodeComputer {

        private readonly string dataPath = "";
        private readonly int[] initialIntCode;
        private int[] intCode;

        public IntCodeComputer(string intCodeFilePath) {
            dataPath = intCodeFilePath;
            initialIntCode = getInputArray(dataPath);
            intCode = initialIntCode;
        }

        public IntCodeComputer(int[] program) {
            intCode = program;
        }

        public int[] getInputArray() {
            return intCode.ToArray();
        }

        public void reset() {
            if(dataPath == "")
                intCode = initialIntCode;
            else
                getInputArray(dataPath);
        }

        public static int[] getInputArray(string path)
        {
            string[] integerStrings = System.IO.File.ReadAllText(path).Split(',');
            int[] ints = (from singleString in integerStrings select int.Parse(singleString)).ToArray();
            return ints;
        }

        public int[] getOpcode(int pos)
        {
            int opcodePos = (pos - 1) * 4;
            if(opcodePos >= 0 && opcodePos < intCode.Length) {
                if(opcodePos < intCode.Length - 4)
                    return intCode.AsSpan<int>(opcodePos, 4).ToArray();
                else
                    return intCode.AsSpan<int>(opcodePos, intCode.Length - opcodePos).ToArray();
            } else {
                return System.Array.Empty<int>();
            }
        }

        public void processIntCode()
        {
            for (int i = 1; i <= intCode.Length / 4; ++i) {
                int[] opCode = getOpcode(i);
                switch(opCode[0]) {
                    case 1:
                        processAdditionOpcode(opCode[1], opCode[2], opCode[3]);
                        break;
                    case 2:
                        processMultOpcode(opCode[1], opCode[2], opCode[3]);
                        break;
                    case 99:
                        return;
                    default:
                        throw new System.Exception("Encountered unsupported opCode value.");
                }
            }
        }

        private void processMultOpcode(int multVal1, int multVal2, int productDestination)
        {
            intCode[productDestination] = intCode[multVal1] * intCode[multVal2];
        }

        private void processAdditionOpcode(int addVal1, int addVal2, int sumDestination)
        {
            intCode[sumDestination] = intCode[addVal1] + intCode[addVal2];
        }

        public void setCodeElement(int pos, int val) {
            intCode[pos] = val;
        }

        public int getOutput() {
            return intCode[0];
        }

        public int getOutput(int intCodePos) {
            return intCode[intCodePos];
        }

    }

}