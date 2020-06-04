using System;
using System.Collections.Generic;
using System.IO;

namespace SiteLibrary
{
    public class Admin : Account
    {
        private int _amountAdmins;  // Amount of all admins ever created

        /// <summary>
        /// Constructor with parameters which creates user's folder and adds information to file with all users' info
        /// </summary>
        /// <param name="login">Login of new user</param>
        /// <param name="passwd">Password of new user</param>
        public Admin(string login, string passwd, AccountStateHandler handler) : base(handler)
        {
            _allLines = File.ReadAllLines(_settingsFile);
            firstLine = _allLines[0].Split(' ');  // Get line with amount of all users
            _amountAdmins = Convert.ToInt32(firstLine[0]) + 1;  // Increase amount of all Admins
            _directoryPath = $"B:\\Programming\\course\\Admin{_amountAdmins}";
            if (CreateAccountDirectory(_directoryPath, login, passwd))
            { 
                firstLine[0] = Convert.ToString(_amountAdmins);
                _allLines[0] = string.Join(" ",firstLine);  // Change amount of Admins in string with all lines
                string userdata = $"Admin{_amountAdmins} {login} {passwd}";
                File.WriteAllLines(_settingsFile, _allLines);  // Rewrite the file with all users' info
                File.AppendAllText(_settingsFile, userdata);  // Add data about new user
            }
        }
        
        public Admin(AccountStateHandler handler) : base(handler){}
        
        /// <summary>
        /// Constructor for LogIn
        /// </summary>
        /// <param name="user">Name of the user</param>
        public Admin(string user, AccountStateHandler handler) : base(handler) => OnLogged($"You successfully logged as {user}!");

        
        /// <summary>
        /// Finds and deletes editor's folder if it exists and deletes line with editor's login and password from file with all users' info
        /// </summary>
        /// <param name="editor">Name of the deleted editor</param>
        public void DeleteEditor(string editor)
        {
            if (editor.Contains("Editor"))
            {
                if (Directory.Exists($"B:\\Programming\\course\\{editor}"))  // Check if editor's folder exists
                {
                    List<string> data = new List<string>();  // List for saving all users' data except editor's data
                    Directory.Delete($"B:\\Programming\\course\\{editor}", true);
                    foreach (var line in File.ReadAllLines(_settingsFile))
                    {
                        if (!line.Contains($"{editor}"))
                            data.Add(line);
                    }
                    File.WriteAllLines(_settingsFile, data.ToArray());  // Rewrite file with all users's info
                    OnDeletedEditor($"{editor} was successfully deleted");
                }
                else
                    OnDeletedEditor("There is no such user");
            }
            else
                OnDeletedEditor("You can delete only editors!");
        }

    }
}
