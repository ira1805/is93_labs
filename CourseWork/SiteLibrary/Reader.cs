using System;
using System.IO;

namespace SiteLibrary
{
    public class Reader : Account
    {
        private int _amountReaders;  // Amount of all readers ever created
        
        /// <summary>
        /// Constructor with parameters which creates user's folder and adds information to file with all users' info
        /// </summary>
        /// <param name="login">Login of new user</param>
        /// <param name="passwd">Password of new user</param>
        public Reader(string login, string passwd, AccountStateHandler handler) : base(handler)
        {
            _allLines = File.ReadAllLines(_settingsFile);
            firstLine = _allLines[0].Split(' ');  // Get line with amount of all users
            _amountReaders = Convert.ToInt32(firstLine[2]) + 1;  // Increase amount of all Readers
            _directoryPath = $"B:\\Programming\\course\\Reader{_amountReaders}";  
            if (CreateAccountDirectory(_directoryPath, login, passwd))
            {
                firstLine[2] = Convert.ToString(_amountReaders);
                _allLines[0] = string.Join(" ",firstLine);  // Change amount of Readers in string with all lines
                string userdata = $"Reader{_amountReaders} {login} {passwd}";  
                File.WriteAllLines(_settingsFile, _allLines);  // Rewrite the file with all users' info
                File.AppendAllText(_settingsFile, userdata);  // Add data about new user
            }
        }
        
        /// <summary>
        /// Constructor for LogIn
        /// </summary>
        /// <param name="user">Name of the user</param>
        public Reader(string user, AccountStateHandler handler) : base(handler) => OnLogged($"You successfully logged as {user}!");
        
    }
}