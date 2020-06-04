﻿using System;
using System.Collections.Generic;
using System.Linq;
using SiteLibrary;

 namespace course
{    
    /// <summary>
    /// Class has custom console commands to simulate web-site with news
    /// </summary>
    public static class CustomConsole
    { 
        /// <summary>
        /// Prints information about all functions in CustomConsole class
        /// </summary>
        public static void Help()
        {
            Console.WriteLine("To navigate on site type commands to the console" +
                             "\n'create new user' - create new admin or editor to write articles" +
                             "\n'login' - to login if you already has an account" +
                             "\n'delete editor' - admin can delete editors" +
                             "\n'write article' - write new article" +
                             "\n'delete article' - article can be deleted by author" +
                             "\n'main page' - open main page with topics and articles" +
                             "\n'find article' - find article by specific topic, title, author, date or during certain period of time" +
                             "\n'read article' - read specific article" +
                             "\n'add to bookmarks' - add article to your bookmarks" +
                             "\n'show my bookmarks' - show all your bookmarks" +
                             "\n'exit' - end current session");
        }
        
        /// <summary>
        /// Gets login, password and type of account from user and creates suitable account using constructors of Admin/Editor/Reader classes
        /// <remarks>See also <see cref="Admin(string, string, AccountStateHandler)"/>, <see cref="Editor(string, string, AccountStateHandler)"/>, <see cref="Reader(string, string, AccountStateHandler)"/></remarks>
        /// </summary>
        public static void CreateUser()
        {
            Console.WriteLine("Enter your login: ");
            string login = Console.ReadLine();
            Console.WriteLine("Enter your password: ");
            string passwd = Console.ReadLine();
            string key = "1635";  // Key for admin authorization
            
            Console.WriteLine("Enter type of account(admin or editor or reader): ");
            string type = Console.ReadLine();
            if (type == "admin")
            {
                Console.WriteLine("Enter key for admin rights: ");  // Ask key for authorization
                if (Console.ReadLine() == key) new Admin(login, passwd, SendMessage);
            }
            else if (type == "editor") new Editor(login, passwd, SendMessage);
            else if (type == "reader") new Reader(login, passwd, SendMessage);
            else Console.WriteLine("Please try again");
        }
        
        /// <summary>
        /// Logins to existing account by asking user login and password of that account. Uses <see cref="Account.CheckAccount"/> and constructors of Admin/Editor/Reader class
        /// </summary>
        /// <param name="currentUser">Reference to current authorized user</param>
        /// <returns>Type of current account</returns>
        public static string LogIn(ref Account currentUser)
        {
            Console.WriteLine("Enter your login: ");
            string login = Console.ReadLine();
            Console.WriteLine("Enter your password: ");
            string passwd = Console.ReadLine();
            string userType = Account.CheckAccount(login, passwd);
            
            if (userType.Contains("Admin")) currentUser = new Admin(userType, SendMessage);
            else if (userType.Contains("Editor")) currentUser = new Editor(userType, SendMessage);
            else if (userType.Contains("Reader")) currentUser = new Reader(userType, SendMessage);
            else Console.WriteLine("Account with that data doesn't exist, try again!");
            
            return userType;
        }
        
        /// <summary>
        /// Creates article using Account's method <see cref="Account.CreateArticle"/>
        /// </summary>
        /// <param name="user">Current authorized user</param>
        /// <param name="userType">Name of current authorized user(Reader0 as default)</param>
        public static void CreateArticle(Account user, string userType)
        {
            if (user is Admin || user is Editor)
            {
                Console.WriteLine("Enter full path to the text: ");
                string textFile = Console.ReadLine();
                Console.WriteLine("Enter title: ");
                string title = Console.ReadLine();
                Console.WriteLine("Enter topic: ");
                string topic = Console.ReadLine();
                Console.WriteLine("Enter tags comma separated: ");
                string tags = Console.ReadLine();
                user.CreateArticle(textFile, userType, title, topic, tags, SendMessage);
            }
            else Console.WriteLine("You have to be a registered editor or an admin");
        }
        
        /// <summary>
        /// Main page of the console web-site.
        /// Uses <see cref="Article.FindByPeriod"/> with dates parameters to get short information about latest articles.
        /// </summary>
        public static void MainPage()
        {
            Article tempArt = new Article(SendMessage);
            // Get information about latest articles
            string text = tempArt.FindByPeriod(new []{DateTime.Today.AddDays(-3).ToString(), DateTime.Today.ToString()});
            if (text != null)
            {
                string[] lines = text.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);  // Split text by lines
                if (lines.Length > 1)
                {
                    // Sort articles by topic
                    Dictionary<string, List<string>> articles = new Dictionary<string, List<string>>();
                    for (int i = 1; i < lines.Length; i++)
                    {
                        string key = lines[i].Split('|')[1];  // Key = article's topic
                        if(!articles.ContainsKey(key))
                            articles.Add(key, new List<string>());
                        articles[key].Add(lines[i]);  // Add article to certain topic 
                    }
                    
                    // Convert dictionary to string to print it
                    text = lines[0];
                    foreach (var value in articles.Values)
                    {
                        text += "\n";
                        text += string.Join("\n", value.ToArray());
                    }
                    Console.WriteLine($"\t\t\tWelcome to my web-site!\n\tLatest articles\n{text}");
                } else
                    Console.WriteLine($"\t\t\tWelcome to my web-site!\n\tLatest articles\n{text}");
            }
        }
        
        /// <summary>
        /// Deletes editor using <see cref="Admin.DeleteEditor"/>
        /// </summary>
        /// <param name="user">Current authorized user</param>
        public static void DeleteEditor(Account user)
        {
            if (user is Admin)  // Only admin has permission to delete editors
            {
                Admin admin = new Admin(SendMessage);
                Console.WriteLine("What user do you want to delete?");
                string editor = Console.ReadLine();
                Console.WriteLine($"Are you sure that you want to delete {editor}?(yes or no)");
                if (Console.ReadLine() == "yes")
                    admin.DeleteEditor(editor);
            } else
                Console.WriteLine("You must be an admin to have this feature");
        }

        /// <summary>
        /// Prints short info about article and it's text
        /// </summary>
        /// <param name="user">A parameter to call <see cref="Account.ReadArticle"/>.</param>
        public static void ReadArticle(Account user)
        {
            Console.WriteLine("Enter author: ");
            string author = Console.ReadLine();
            Console.WriteLine("Enter title: ");
            string title = Console.ReadLine();
            string text = user.ReadArticle(author, title);
            if (text != null)  // Can be null if there is no such article
            {
                string[] info = new Article(SendMessage).GetInformation(author, title).Split('|');
                Console.WriteLine($"Topic: {info[1]}\nTags: {info[3]}\nDate: {info[4]}\n\t\t{title}\n\t\t\t{author}" +
                                  $"\n\n{text}");
            }
        }

        /// <summary>
        /// Deletes article using <see cref="Account.DeleteArticle(string, string)"/> or <see cref="Editor.DeleteArticle(string, string, string)"/>
        /// </summary>
        /// <param name="user">Name of current authorized user(Reader0 as default)</param>
        public static void DeleteArticle(string user)
        {
            if (!(user.Contains("Reader")))
            {
                Editor editor = new Editor(SendMessage);
                Console.WriteLine("Enter author: ");
                string author = Console.ReadLine();
                Console.WriteLine("Enter title: ");
                string title = Console.ReadLine();
                if (user.Contains("Editor"))
                    editor.DeleteArticle(author, title, user);
                else
                    editor.DeleteArticle(author, title);
            } else
                Console.WriteLine("You have to be an author of this article or an admin");
        }
        
        /// <summary>
        /// Finds article by some specific parameter that user prints
        /// <remarks>Uses <see cref="Article.FindByCriterion"/>, <see cref="Article.FindByTags"/>, <see cref="Article.FindByPeriod"/></remarks>
        /// </summary>
        public static void FindArticle()
        {
            string[] criteria = {"author", "title", "topic", "tags", "date", "period"};
            bool findFlag = true;
            Article tempArt = new Article(SendMessage);
            
            while (findFlag)
            {
                Console.WriteLine($"Enter the criterion({string.Join(", ", criteria)}) and its value that you want to find: \n");
                string userChoice = Console.ReadLine();

                if (userChoice != null && userChoice.Split(' ')[0].Contains("tags"))
                { 
                    List<string> tempStr = userChoice.Split(' ').ToList();
                    tempStr.RemoveAt(0);
                    if (tempStr[0] == "")
                        Console.WriteLine("Please try again");
                    else
                    {
                        string articles = tempArt.FindByTags(tempStr.ToArray());
                        if (articles != null)
                            Console.WriteLine(articles);
                        Console.WriteLine("Do you want to choose criteria?(yes or no)");
                        if (Console.ReadLine() == "no")
                            findFlag = false;
                    }
                } else if (userChoice != null && userChoice.Split(' ')[0].Contains("period"))
                {
                    try
                    {
                        List<string> tempStr = userChoice.Split(' ').ToList();
                        tempStr.RemoveAt(0);
                        string articles = tempArt.FindByPeriod(tempStr.ToArray());
                        if (articles != null)
                            Console.WriteLine(articles);
                        Console.WriteLine("Do you want to choose criteria?(yes or no)");
                        if (Console.ReadLine() == "no")
                            findFlag = false;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Please try again");
                    }
                } else if (userChoice != null)
                {
                    string type = userChoice.Split(' ')[0];
                    string criterion = userChoice.Split(' ')[1];
                    if (criterion != "" && type != "")
                    {
                        string articles = tempArt.FindByCriterion(criterion, type);
                        if (articles != null)
                            Console.WriteLine(articles);
                        Console.WriteLine("Do you want to choose criteria?(yes or no)");
                        if (Console.ReadLine() == "no")
                            findFlag = false;
                    } else
                        Console.WriteLine("Please try again");
                }
                else
                    findFlag = false;
            }
        }

        /// <summary>
        /// Adds to temporary bookmarks(saved for current session only)
        /// </summary>
        /// <param name="user">Current authorized user</param>
        public static void AddBookmark(Account user)
        {
            if (user is Admin || user is Editor || user is Reader)
            {
                Console.WriteLine("Please enter title of the article to add: ");
                string title = Console.ReadLine();
                user.AddToBookmarks(title);
            }
            else Console.WriteLine("You have to login first!");
        }
        
        /// <summary>
        /// Show all user's bookmarks
        /// </summary>
        /// <param name="user">Current authorized user</param>
        public static void ShowBookmarks(Account user)
        {
            if (user is Admin || user is Editor || user is Reader)
            {
                string bookmarks = user.ShowBookmarks();
                if (bookmarks != "")
                    Console.WriteLine($"Your bookmarks: \n{bookmarks}");
                else
                    Console.WriteLine("You don't have any bookmarks");
            }
            else Console.WriteLine("You have to login first!");
        }

        /// <summary>
        /// Prints text
        /// </summary>
        /// <param name="msg">Text to print</param>
        public static void SendMessage(string msg) => Console.WriteLine(msg);
    }
}