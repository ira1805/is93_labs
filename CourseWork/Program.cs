using SiteLibrary;
using System;

namespace course
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            bool status = true;
            string userType = "Reader0";
            Account currentUser = new Account();
            while (status)
            {
                Console.WriteLine("\nEnter command please(type 'help' for more information): ");
                string command = Console.ReadLine();
                switch (command)
                {
                    case "help": CustomConsole.Help();
                        break;
                    case "": CustomConsole.Help();
                        break;
                    case "login": userType = CustomConsole.LogIn(ref currentUser);
                        break;
                    case "delete editor": CustomConsole.DeleteEditor(currentUser);
                        break;
                    case "create new user": CustomConsole.CreateUser();
                        break;
                    case "write article": CustomConsole.CreateArticle(currentUser, userType);
                        break;
                    case "delete article": CustomConsole.DeleteArticle(userType);
                        break;
                    case "main page": CustomConsole.MainPage();
                        break;
                    case "find article": CustomConsole.FindArticle();
                        break;
                    case "read article": CustomConsole.ReadArticle(currentUser);
                        break;
                    case "add to bookmarks": CustomConsole.AddBookmark(currentUser);
                        break;
                    case "show my bookmarks": CustomConsole.ShowBookmarks(currentUser);
                        break;
                    case "exit": status = false;
                        continue;
                }
            }
        }
    }
}