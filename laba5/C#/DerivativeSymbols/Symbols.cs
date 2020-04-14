using BaseString;
namespace DerivativeSymbols
{
    public class Symbols : ModString
    {
        private string _stringSymbol;
        public Symbols(string userString) => _stringSymbol = userString;  // Constructor with parameters
        public override int StringLength() => _stringSymbol.Length;  // Length of the string
        public override void Increase()  // Increase by doubling symbol 'k'
        {
            string doubledString = "";
            foreach (var symbol in _stringSymbol)
            {
                if (symbol == 'k') doubledString += symbol;
                doubledString += symbol;
            }
            _stringSymbol = doubledString;
        }
        public string GetString() => _stringSymbol;
    }
}