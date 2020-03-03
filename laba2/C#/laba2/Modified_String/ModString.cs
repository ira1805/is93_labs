using System;
using System.Linq;

namespace Modified_String
{
    public class ModString
    {
        private char[] _modString;

        public ModString(char[] letters) // Constructor for user's string
        {
            _modString = letters;
        }

        public int ModLength() // Length of the string
        {
            return _modString.Length;
        }

        public void DeleteBegAndEnd() // Delete the first and the last elements of the string
        {
            char[] changedString = new char[_modString.Length-2];
            int index = 0; // Index for changed string
            for (int i = 1; i < _modString.Length-1; i++)
            {
                changedString[index] = _modString[i];
                index++;
            }
            _modString = changedString;
        }

        public int ConsonantsAmount() // Amount of consonants in the string
        {
            char[] vowels = {'a','i','o','e','u','y'};
            int consonantsAmount = 0;
            foreach (var element in _modString)
            {
                if (!vowels.Contains(element))
                {
                    consonantsAmount += 1;
                }
            }
            return consonantsAmount;
        }

        public void DeleteRepeatSpaces() // Delete repeated spaces in the string
        {
            char[] changedString = new char[_modString.Length];
            int newIndex = 0;
            for (int index = 0; index < _modString.Length; index++)
            {
                if (_modString[index] != ' ')
                {
                    changedString[newIndex] = _modString[index];
                    newIndex++;
                } else if (index == _modString.Length - 1)
                {
                    changedString[newIndex] = _modString[index];
                    break; // Next condition will throw an error if we wouldn't stop our loop
                } else if (_modString[index] == ' ' & _modString[index+1] != ' ')
                { 
                    changedString[newIndex] = _modString[index];
                    newIndex++;
                }
            }
            _modString = changedString;
        }

        public void GetContent() // Print the string
        {
            Console.WriteLine(_modString);
        }
    }
}