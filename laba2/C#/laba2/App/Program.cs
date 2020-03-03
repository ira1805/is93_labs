using System;
using Modified_Text;

namespace App
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ModText myText1 = new ModText();
            ModText myText2 = new ModText();

            char[] myText1String1 = {'h','e','l','l','o'};
            char[] myText1String2 =
            {
                ' ','i','t',' ','i','s',' ','a',' ','t','e','s','t',' '
            };
            char[] myText2String1 = {' ','t', 'e', 's', 't'};
            char[] myText2String2 =
            {
                'j', 'u', 's', 't', ' ', 'a', ' ', 't', 'e', 's', 't'
            };
            char[] myText2String3 = {
                ' ',' ',' ',' ','a','n','o','t','h','e','r',' ',' ','e','a','s','y',
                ' ','a','n','d',' ','i','n','t','e','r','e','s','t','i','n','g',' ',' ',
                ' ',' ',' ',' ',' ',' ','t','e','s','t',' ',' ',' ',' '};
            myText1.AddToText(myText1String1);
            myText1.AddToText(myText1String2);
            myText2.AddToText(myText2String1);
            myText2.AddToText(myText2String2);
            myText2.AddToText(myText2String3);
            
            // Tests with text 1
            Console.WriteLine("The smallest length of the string in the text 1 is {0}", myText1.SmallestLength());
            Console.WriteLine("Deleting spaces at the beginning and in the end of the 2th string in text 1...");
            myText1.DeleteSpaces(2);
            myText1.GetContent();
            Console.WriteLine("Cleaning text...");
            myText1.ClearText();
            myText1.GetContent();
            // Tests with text 2
            myText2.DeleteRepeatedSpaces();
            myText2.GetContent();
            Console.WriteLine("Consonants is {0}%", myText2.ConsonantsPercent());
            Console.WriteLine("Deleting 3rd string in the text...");
            myText2.DeleteString(3);
            myText2.GetContent();
        }
    }
}