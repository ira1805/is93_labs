using System.IO;

namespace SiteLibrary
{
    /// <summary>
    /// Class for creating text in author's folder 
    /// </summary>
    public class Text
    {
        public string _textPath;  // Path to text in author's folder
        public Text(string userPath, string author, string title)
        {
            _textPath = $@"B:\\Programming\\course\\{author}\\{title}.txt";
            File.Copy(userPath, _textPath);
        }
    }
}