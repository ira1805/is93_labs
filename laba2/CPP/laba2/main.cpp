#include <iostream>
#include <vector>
#include "ModText.h"
using namespace std;

int main() {
    ModText myText1;
    ModText myText2;
    vector<char> myText1String1 = {'h','e','l','l','o'};
    vector<char> myText1String2 =
            {
                    ' ','i','t',' ','i','s',' ','a',' ','t','e','s','t',' '
            };
    vector<char> myText2String1 = {' ','t', 'e', 's', 't'};
    vector<char> myText2String2 =
            {
                    'j', 'u', 's', 't', ' ', 'a', ' ', 't', 'e', 's', 't'
            };
    vector<char> myText2String3 = {
            ' ',' ',' ',' ','a','n','o','t','h','e','r',' ',' ','e','a','s','y',
            ' ','a','n','d',' ','i','n','t','e','r','e','s','t','i','n','g',' ',' ',
            ' ',' ',' ',' ',' ',' ','t','e','s','t',' ',' ',' ',' '};
    myText1.AddToText(myText1String1);
    myText1.AddToText(myText1String2);
    myText2.AddToText(myText2String1);
    myText2.AddToText(myText2String2);
    myText2.AddToText(myText2String3);

    // Tests with text 1
    cout << "The smallest length of the string in the text 1 is " << myText1.SmallestLength() << endl;
    cout << "Deleting spaces at the beginning and in the end of the 2th string in text 1..." << endl;
    myText1.DeleteSpaces(2);
    myText1.GetContent();
    cout << "Cleaning text..." << endl;
    myText1.ClearText();
    myText1.GetContent();
    // Tests with text 2
    myText2.DeleteRepeatedSpaces();
    myText2.GetContent();
    printf("Consonants is %d percent", myText2.ConsonantsPercent());
    cout << "\nDeleting 3rd string in the text..." << endl;
    myText2.DeleteString(3);
    myText2.GetContent();



}
