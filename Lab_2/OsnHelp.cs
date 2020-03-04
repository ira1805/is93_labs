using System;

namespace LAB_2
{
    class OsnHelp
    {
        private char[] lines;
        public OsnHelp(char[] line = null)
        {
            this.lines = line;
        }

        public void outputString()
        {
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i] == default(char))
                    break;
                Console.Write(lines[i]);
            }
        }
        public int getLength()
        {
            int i = 1;
            for (; i < lines.Length; i++)
                if (lines[i] == default(char))
                    break;

            return i;
        }
    }
}