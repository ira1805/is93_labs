using BaseString;
namespace DerivativeNumerals 
{
    public class Numeral : ModString
    {
        private string _stringNumeral;
        public Numeral(string userString) => _stringNumeral = userString;  // Constructor with parameter
        public override int StringLength() => _stringNumeral.Length;  // Length of the string
        public override void Increase()  // Increase by doubling all symbols
        {
            string doubledString = "";
            foreach (var symbol in _stringNumeral)
            {
                doubledString += symbol;
                doubledString += symbol;
            }
            _stringNumeral = doubledString;
        }
        public string GetString() => _stringNumeral;
    }
}
