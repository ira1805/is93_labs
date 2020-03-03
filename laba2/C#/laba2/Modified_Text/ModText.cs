using Modified_String;
using System;


namespace Modified_Text
{
    public class ModText
    {
        private ModString[] _text = new ModString[0];
        public void AddToText(char[] chars) // Add a new string to the text
        {
            Array.Resize(ref _text, _text.Length+1);
            ModString word = new ModString(chars);
            _text[_text.Length - 1] = word;
        }

        public void ClearText() // Clean the text
        {
            _text = new ModString[0];
        }

        public int SmallestLength() // Find the smallest length of the string in the text
        {
            int minimum = _text[0].ModLength();
            foreach (var element in _text) // Check every string
            {
                if (element.ModLength() < minimum)
                {
                    minimum = element.ModLength();
                }
            }
            return minimum;
        }

        public void DeleteSpaces(int index) // Delete spaces in the beginning and in the end of string
        {
            _text[index-1].DeleteBegAndEnd();
        }

        public double ConsonantsPercent() // Percent of consonants in the text
        {
            double textLength = 0;
            double allConsonantsAmount = 0;
            foreach (var element in _text)
            {
                textLength += element.ModLength();
                allConsonantsAmount += element.ConsonantsAmount();
            }
            double result = (allConsonantsAmount / textLength)*100;
            return Math.Round(result, 2);
        }

        public void DeleteString(int index) // Delete certain string from the text
        {
            ModString[] changedText = new ModString[_text.Length-1];
            int element = 0;
            for (int i = 0; i < _text.Length; i++)
            {
                if (i != index-1)
                {
                    changedText[element] = _text[i];
                    element++;
                }
            }
            _text = changedText;
        }

        public void DeleteRepeatedSpaces() // Delete all repeated spaces in the text
        {
            foreach (var userString in _text)
            {
                userString.DeleteRepeatSpaces();
            }
        }

        public void GetContent() // Print the text
        {
            foreach (var element in _text)
            {
                element.GetContent();
            }
        }
    }
}