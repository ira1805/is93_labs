using System;
using System.IO;

namespace SiteLibrary
{
    public class Editor : Account
    {
        private int _amountEditors; // Amount of all editors ever created
        
        /// <summary>
        /// Constructor with parameters which creates user's folder and adds information to file with all users' info
        /// </summary>
        /// <param name="login">Login of new user</param>
        /// <param name="passwd">Password of new user</param>
        public Editor(string login, string passwd, AccountStateHandler handler) : base(handler)
        {
            _allLines = File.ReadAllLines(_settingsFile);
            firstLine = _allLines[0].Split(' ');  // Get line with amount of all users
            _amountEditors = Convert.ToInt32(firstLine[1]) + 1;  // Increase amount of all Editors
            _directoryPath = $"B:\\Programming\\course\\Editor{_amountEditors}";
            if (CreateAccountDirectory(_directoryPath, login, passwd))
            {
                firstLine[1] = Convert.ToString(_amountEditors);
                _allLines[0] = string.Join(" ",firstLine);  // Change amount of Editors in string with all lines
                string userdata = $"Editor{_amountEditors} {login} {passwd}";
                File.WriteAllLines(_settingsFile, _allLines);  // Rewrite the file with all users' info
                File.AppendAllText(_settingsFile, userdata);  // Add data about new user
            }
        }
        
        /// <summary>
        /// Constructor for deleting user's article
        /// </summary>
        public Editor(AccountStateHandler handler) : base(handler){}
        
        /// <summary>
        /// Constructor for LogIn
        /// </summary>
        /// <param name="user">Name of the user</param>
        public Editor(string user, AccountStateHandler handler) : base(handler) => OnLogged($"You successfully logged as {user}!");

        /// <summary>
        /// Deletes an article with author verification
        /// </summary>
        /// <param name="author">Author of the deleting article</param>
        /// <param name="title">Title of the deleting article</param>
        /// <param name="user">Name of current authorized user</param>
        public override void DeleteArticle(string author, string title, string user)
        {
            if (author == user)
                DeleteArticle(author, title);
            else
                OnDeletedArticle("You can delete only your articles");
        }
    }
}