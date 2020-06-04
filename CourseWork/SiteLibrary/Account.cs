using System;
using System.Collections.Generic;
using System.IO;

namespace SiteLibrary
{
    public delegate void AccountStateHandler(string msg);  // Delegate for printing information about Account status to the console
    public class Account : IAccount
    {
        protected internal event AccountStateHandler Created;
        protected internal event AccountStateHandler Deleted;
        protected internal event AccountStateHandler Added;
        // Methods for printing text
        protected void OnCreatedAccount(string msg)
        {
            if (msg != null) Created?.Invoke(msg); 
        }
        protected void OnLogged(string msg)
        {
            if (msg != null) Created?.Invoke(msg);
        }
        protected void OnRead(string msg)
        {
            if (msg != null) Created?.Invoke(msg);
        }
        protected void OnDeletedArticle(string msg)
        {
            if (msg != null) Deleted?.Invoke(msg);
        }
        protected void OnDeletedEditor(string msg)
        {
            if (msg != null) Deleted?.Invoke(msg);
        }
        protected void OnAddBookmark(string msg)
        {
            if (msg != null) Added?.Invoke(msg);
        }
        
        protected string _settingsFile = "B:\\Programming\\course\\data.txt";  // File with users' data
        protected string _directoryPath;  // Directory of specific user
        protected string[] _allLines;  // String to save info
        protected string[] firstLine;  // Amount of Admins, Editors and Readers
        public List<string> _bookmarks = new List<string>();  // Temporary bookmarks

        /// <summary>
        /// Checks if account exists searching by its login
        /// </summary>
        /// <param name="login">Login for authorizing</param>
        /// <returns>Returns true if account exists</returns>
        public bool CheckLogin(string login)
        {
            foreach (var line in File.ReadAllLines(_settingsFile))
            {
                if (line.Split(' ')[1] == login)  // Searching user's login in file with all users' data
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Searches name of specific account. Method is used in <see cref="Login(ref Account)"/>
        /// </summary>
        /// <param name="login">Login of account</param>
        /// <param name="passwd">Password of account</param>
        /// <returns>Returns type of the account</returns>
        public static string CheckAccount(string login, string passwd)
        {
            if (File.Exists("B:\\Programming\\course\\data.txt"))
            {
                foreach (var line in File.ReadAllLines("B:\\Programming\\course\\data.txt"))
                {
                    if (line.Contains($"{login} {passwd}"))  // Searching for data of current user
                        return line.Split(' ')[0];
                }
            }
            return "";
        }

        /// <summary>
        /// Calls in constructors of Admin, Editor and Reader classes
        /// </summary>
        protected Account(AccountStateHandler handler)
        {
            if (!File.Exists(_settingsFile))
            {
                StreamWriter data = File.CreateText(_settingsFile);  // Create file with all users' data
                data.Write("0 0 0");  // Amount of admins, editors and reader ever created
                data.Close();
            }
            Created += handler;
            Added += handler;
            Deleted += handler;
        }
        
        /// <summary>
        /// Parameterless constructor for unauthorized users
        /// </summary>
        public Account() {}
        
        /// <summary>
        /// Creates account's directory for saving article in it
        /// </summary>
        /// <param name="directoryPath">Path to folder of new user</param>
        /// <param name="login">Login of new user</param>
        /// <param name="passwd">Password of new user</param>
        /// <returns>Returns true if account didn't exist and false if it existed</returns>
        protected bool CreateAccountDirectory(string directoryPath, string login, string passwd)
        {
            if (!CheckLogin(login))
            {
                if (!Directory.Exists(directoryPath))
                {
                    DirectoryInfo dir = new DirectoryInfo(directoryPath);
                    dir.Create();  // Create directory
                    string newUser = directoryPath.Substring(directoryPath.IndexOf('\\') + 1)+ $" {login} {passwd}";
                    File.AppendAllText(_settingsFile, newUser);  // Add new user's information to file with all users' info
                    OnCreatedAccount("Account created! Now you have to login");
                    return true;
                }
            }
            else OnCreatedAccount("This user already exists, try another login");
            return false;
        }

        public void CreateArticle(string textFile, string author, string title, string topic, string tags, ArticleStateHandler handler) => new Article(textFile, author, title, topic, tags, handler);

        public string ReadArticle(string author, string title)
        {
            string name = "";
            string temp;
            foreach (var line in File.ReadAllLines("B:\\Programming\\course\\articles.txt"))
            {
                if (line == "")
                    continue;
                temp = line.Split('|')[2].Trim();  // Take article's title
                if (line.Contains(author) &&  temp == title)  // Searching for article's data 
                {
                    name = line.Split('|')[3].Split(',')[0].Trim();  // Take only article's first tag(name of the file with article's text)
                    break;
                }
            }
            string articleFile = $"B:\\Programming\\course\\{author}\\{name.Trim('/', '\\', ':', '"', '.', '|', '<', '>', '*')}.txt";  // Delete unnecessary symbols to avoid exceptions with path
            if (File.Exists(articleFile))
            {
                return string.Join("",File.ReadAllLines(articleFile));
            }
            OnRead("There is no such article");
            return null;
        }
        public virtual void DeleteArticle(string author, string title, string user) => DeleteArticle(author, title);

        public void DeleteArticle(string author, string title)
        {
            string name = "";
            string temp;  // Save all data except information about deleted article
            foreach (var line in File.ReadAllLines("B:\\Programming\\course\\articles.txt"))
            {
                if (line == "")
                    continue;
                temp = line.Split('|')[2].Trim();
                if (line.Contains(author) &&  temp == title){  // Find line with article's information
                name = line.Split('|')[3].Split(',')[0];
                name = name.Remove(0, 1);  // Take first tag from there. It is the name of the deleted article
                break; 
                }
            }
            List<string> articlesData = new List<string>();
            foreach (var line in File.ReadAllLines("B:\\Programming\\course\\articles.txt"))
            {
                if (line == "")
                    continue;
                if (!line.Contains(title))  // Skip line with information about deleted article
                    articlesData.Add(line);
            }
            if (File.Exists($"B:\\Programming\\course\\{author}\\{name}.txt"))
            {
                File.Delete($"B:\\Programming\\course\\{author}\\{name}.txt");  // Delete article's file
                File.WriteAllLines("B:\\Programming\\course\\articles.txt", articlesData.ToArray());  // Rewrite file with articles' information
                OnDeletedArticle("Article deleted!");
            } else
                OnDeletedArticle("There is no such article");
            
        }
        
        public void AddToBookmarks(string title)
        {
            _bookmarks.Add(title);
            OnAddBookmark("Bookmark added!");
        } 
        public string ShowBookmarks() => string.Join("; ", _bookmarks.ToArray());
    }
}