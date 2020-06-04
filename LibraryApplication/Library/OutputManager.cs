using System;
using System.Collections.Generic;

namespace Library
{
    public delegate void BookInLogbook();
    public delegate void UserInDatabase();
    public static class OutputManager
    { 
        public static void ShowGreeting()
        { 
            Console.WriteLine("Welcome to Library Application!");
        }

        public static LoginOptions RequestLoginOption()
        {
            Console.WriteLine("Which function do you want to choose?");
            Console.WriteLine("1. Login to the system");
            Console.WriteLine("2. Sign up to the system");
            Console.WriteLine("3. Exit");
            Console.WriteLine();
            Console.Write("Enter option name: ");

            var option = Convert.ToInt32(Console.ReadLine());
            if (option == 1)
                return LoginOptions.SignIn;
            else if (option == 2)
                return LoginOptions.SignUp;
            else
                return LoginOptions.Exit;
        }

        public static string RequestUserName()
        {
            Console.WriteLine("Enter user's name: ");

            return Console.ReadLine();
        }

        public static UserAction RequestUserAction()
        {
            Console.WriteLine("Which function do you want to choose?");
            Console.WriteLine("1. Take a book");
            Console.WriteLine("2. Hand over a book");
            Console.WriteLine("3. Exit");
            Console.WriteLine();
            Console.Write("Enter function name: ");
            var option = Convert.ToInt32(Console.ReadLine());

            if (option == 1)
            {
                return UserAction.TakeBook;
            }
            else if (option == 2)
            {
                return UserAction.HandOverBook;
            }
            else
            {
                return UserAction.Exit;
            }
        }

        public static BookSelection SelectionBook()
        {
            Console.WriteLine("How do you want to do a search?");
            Console.WriteLine("1. Search by author");
            Console.WriteLine("2. Search by name of composition");
            Console.WriteLine("3. Search by theme");

            Console.WriteLine();
            Console.Write("Enter option name: ");
            var option = Convert.ToInt32(Console.ReadLine());

            if (option == 1)
            {
                return BookSelection.ByAuthor;
            }
            else if (option == 2)
            {
                return BookSelection.ByName;
            }
            else
            {
                return BookSelection.ByTheme;
            }
        }

        public static string SearchByAuthor(List<string> listOfAuthor)
        {
            Console.WriteLine("Which author do you want to choose?");
            for (int i = 0; i < listOfAuthor.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {listOfAuthor[i]}");
            }
            Console.WriteLine();
            Console.Write("Enter your selection: ");
            var index = Convert.ToInt32(Console.ReadLine());
            return listOfAuthor[index-1];
        }

        public static string SelectedComposeByAuthor( List<string> SelectedAuthorCompositions)
        {
            Console.WriteLine("Which composition do you want to choose?");
            for (int i = 0; i < SelectedAuthorCompositions.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {SelectedAuthorCompositions[i]}");
            }
            Console.WriteLine();
            Console.Write("Enter your selection: ");
            var index = Convert.ToInt32(Console.ReadLine());
            return SelectedAuthorCompositions[index - 1];
        }

        public static string SearchByName(List<string> listOfCompositions)
        {
            Console.WriteLine("Which composition do you want to choose?");
            for (int i = 0; i < listOfCompositions.Count; i ++)
            {
                Console.WriteLine($"{i+1}. {listOfCompositions[i]}");
            }
            Console.WriteLine();
            Console.Write("Enter your selection: ");
            var index = Convert.ToInt32(Console.ReadLine());
            return listOfCompositions[index - 1];
        }

        public static string SearchByTheme(List<string> listOfTheme)
        {
            Console.WriteLine("Which theme do you want to choose?");
            for (int i = 0; i < listOfTheme.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {listOfTheme[i]}");
            }
            Console.WriteLine();
            Console.Write("Enter your selection: ");
            var index = Convert.ToInt32(Console.ReadLine());
            return listOfTheme[index];
        }

        public static string SelectedComposeByTheme(List<Composition> SelectedThemeCompositions)
        {
            Console.WriteLine("Which composition do you want to choose?");
            for (int i = 0; i < SelectedThemeCompositions.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {SelectedThemeCompositions[i].Name}");
            }
            Console.WriteLine();
            Console.Write("Enter your selection: ");
            var index = Convert.ToInt32(Console.ReadLine());
            return SelectedThemeCompositions[index - 1].Name;
        }

        public static string HandOverBook(User currentUser)
        {
            Console.WriteLine("List of your book");
            Console.WriteLine("Which one do you want to hand over?");
            for(int i = 0; i < currentUser.CompositionNames.Count; i ++)
            {
                Console.WriteLine($"{1 + 1}. {currentUser.CompositionNames[i]}");
            }
            Console.WriteLine();
            Console.Write("Enter your selection: ");
            var index = Convert.ToInt32(Console.ReadLine());
            return currentUser.CompositionNames[index - 1];
        }

        public static string SignUp()
        {
            Console.WriteLine("Enter your name to sign up: ");
            var name = Console.ReadLine();
            return name;
        }

        public static void OverloadLogbook()
        {
            Console.WriteLine("Your Logbook is overload");
            Console.WriteLine("Try again and choose other function");
        }

        public static event BookInLogbook TakingBook = null;
         
        public static void EventTakingBookDelegate()
        {
            TakingBook.Invoke();
        }

        private static void HandlerForTakingBook()
        {
            Console.WriteLine("Book succesfully added to your Logbook");
        }

        public static void AddingBookToLogBook()
        {
            TakingBook += new BookInLogbook(HandlerForTakingBook);
            EventTakingBookDelegate();
        }

        public static event UserInDatabase AddingUser = null;

        public static void EventAddingUserDelegate()
        {
            AddingUser.Invoke();
        }

        private static void HandlerForAddingUser()
        {
            Console.WriteLine("User succesfully added to database");
        }

        public static void AddingUserToDatabase()
        {
            AddingUser += new UserInDatabase(HandlerForAddingUser);
            EventAddingUserDelegate();
        }

        public static void IncorrectName()
        {
            Console.WriteLine("There isn't such name in base");
            Console.WriteLine("Try again and choose other function");
        }

        public static void IncorrectOption()
        {
            Console.WriteLine("There isn't such option");
            Console.WriteLine("Try again and choose other function");
        }

        public static void ProgramTerminate()
        {
            Console.WriteLine("Program is terminated");
        }
    }
}
