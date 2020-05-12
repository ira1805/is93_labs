namespace Laba7
{
    class SymbolCounter
    { 
        public static int StaticCountSymbol(char uSymbol, string uString)  // Static method. Count the repetition of the character in the string
        {
            int count = 0;
            foreach (var symbol in uString)
            {
                if (symbol == uSymbol) {count += 1 ;}
            }
            return count;
        }
        public int CountSymbol(char uSymbol, string uString)  // Count the repetition of the character in the string
        {
            int count = 0;
            foreach (var symbol in uString)
            {
                if (symbol == uSymbol) {count += 1 ;}
            }
            return count;
        }
    }
}