using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Library
{
    public class LibraryManager
    {
        private const string PathToUsersDataFile = @"C:\Users\Ryzen\Desktop\kursova\usersData.json";                //way to files
        private const string PathToCompositionsDataFile = @"C:\Users\Ryzen\Desktop\kursova\compositionsData.json";

        private List<User> _users { get; set; }
        private Dictionary<string, List<Composition>> _compositionsDict { get; set; }

        public LibraryManager()     //constructor with methods, that deserialize data 
        {                           //from JSON-file to variables
            LoadUsers();
            LoadCompositions();
        }
        public void SaveData()          //method that save data after program is terminated
        {
            var data = _users;
            using (var writer = new StreamWriter(PathToUsersDataFile))
            {
                string json = JsonConvert.SerializeObject(data, Formatting.Indented);
                writer.Write(json);
            }
            var _data = _compositionsDict;
            using (var writer = new StreamWriter(PathToCompositionsDataFile))
            {
                string json = JsonConvert.SerializeObject(_data, Formatting.Indented);
                writer.Write(json);
            }
        }
        public void ShowMainMenu()
        {
            OutputManager.ShowGreeting();       //method that output greeting to user
            while (true)
            {
                var loginOption = OutputManager.RequestLoginOption();   //request login option
                if (loginOption == LoginOptions.SignIn)                 //if user choose sign in 
                {
                    var user = OutputManager.RequestUserName();         //request for user name
                    var userInDatabase = _users.Where(x => x.Name == user).FirstOrDefault(); //search user in base

                    if (userInDatabase != null)                         //if user is in Base
                    {
                        var currentOption = OutputManager.RequestUserAction();  //request next action 
                        if (currentOption == UserAction.TakeBook)
                        {
                            if (userInDatabase.CompositionNames.Count < 10)     //check if user have more than 10 books
                            {
                                var selection = OutputManager.SelectionBook();  //request for selection book
                                if (selection == BookSelection.ByAuthor)
                                {
                                    var listOfAuthors = _compositionsDict.Select(x => x.Key).ToList();  //variable with only authors' name
                                    var selectedAuthor = OutputManager.SearchByAuthor(listOfAuthors);  
                                    var selectedAuthorCompositions = _compositionsDict[selectedAuthor]  //variable with comopition of selected author
                                                                     .Where(x => x.CountOfAvailableCopies > 0)
                                                                     .Select(x => x.Name)
                                                                     .ToList();
                                    var selectedComposition = OutputManager.SelectedComposeByAuthor(selectedAuthorCompositions);
                                    userInDatabase.CompositionNames.Add(selectedComposition);
                                    OutputManager.AddingBookToLogBook();
                                }
                                else if (selection == BookSelection.ByName)
                                {
                                    var listOfCompositions = _compositionsDict          //variable  with all composition in archieve
                                            .SelectMany(x => x.Value)
                                            .Where(x => x.CountOfAvailableCopies > 0)
                                            .Select(y => y.Name)
                                            .ToList();
                                    var selectedComposition = OutputManager.SearchByName(listOfCompositions);
                                    userInDatabase.CompositionNames.Add(selectedComposition);                   
                                }
                                else if (selection == BookSelection.ByTheme)
                                {
                                    var listOfTheme = _compositionsDict                 //variable with only themes
                                            .SelectMany(x => x.Value)
                                            .Where(x => x.CountOfAvailableCopies > 0)
                                            .Select(y => y.Theme)
                                            .ToList();
                                    var selectedTheme = OutputManager.SearchByTheme(listOfTheme);
                                    var SelectedThemeCompositions = _compositionsDict   //variable with compositions of select
                                            .SelectMany(x => x.Value)
                                            .Where(x => x.CountOfAvailableCopies > 0)
                                            .Where(y => y.Theme == selectedTheme)
                                            .ToList();
                                    var selectedComposition = OutputManager.SelectedComposeByTheme(SelectedThemeCompositions);
                                    userInDatabase.CompositionNames.Add(selectedComposition);
                                }
                                else            //if input is incorrect than output message with warning
                                {
                                    OutputManager.IncorrectOption();
                                }
                            }
                            else                //if in user's logbook more than 10 books than output message with warning
                            {
                                OutputManager.OverloadLogbook();
                            }
                        }
                        else if (currentOption == UserAction.HandOverBook)
                        {
                            var currentHandOverBook = OutputManager.HandOverBook(userInDatabase);
                            userInDatabase.CompositionNames.Remove(currentHandOverBook);
                        }
                        else if (currentOption == UserAction.Exit)
                        {
                            break;
                        }
                        else                     //if input is incorrect than output message with warning
                        {
                            OutputManager.IncorrectOption();
                        }
                    }
                    else                        //if user isn't in base than output message with warning
                    {
                        OutputManager.IncorrectName();
                    }
                }
                else if (loginOption == LoginOptions.SignUp)
                {
                    var login = OutputManager.SignUp();
                    var newUser = new User()
                    {
                        Name = login,
                        CompositionNames = new List<string>()
                    };
                    _users.Add(newUser);
                    OutputManager.AddingUserToDatabase();
                }
                else if (loginOption == LoginOptions.Exit)
                {
                    break;
                }
                else                             //if input is incorrect than output message with warning
                {
                    OutputManager.IncorrectOption();
                }
            }
            OutputManager.ProgramTerminate();
        }


        private void LoadUsers()        //method that deserialize data about users from JSON-file to variables
        {
            using (var reader = new StreamReader(PathToUsersDataFile))
            {
                var json = reader.ReadToEnd();
                _users = JsonConvert.DeserializeObject<List<User>>(json) ?? new List<User>();
            }
        }
        private void LoadCompositions()  //method that deserialize data about compositions from JSON-file to variables
        {
            using (var reader = new StreamReader(PathToCompositionsDataFile))
            {
                var json = reader.ReadToEnd();
                _compositionsDict = JsonConvert.DeserializeObject<Dictionary<string, List<Composition>>>(json);
            }
        }

       
    }
}

