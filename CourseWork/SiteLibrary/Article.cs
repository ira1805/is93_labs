using System;
using System.Collections.Generic;
using System.IO;

namespace SiteLibrary
{    
    public delegate void ArticleStateHandler(string msg);  // Delegate for printing information about Article status into the console
    public class Article
    {        
        private event ArticleStateHandler Created;
        
        /// <summary>
        /// Printing info about creating article into the console.
        /// <remarks>
        /// Uses <see cref="Created"/> event
        /// </remarks>
        /// </summary>
        /// <param name="msg">Message to print into the console</param>
        private void OnCreatedArticle(string msg)
        {
            if (msg != null) Created?.Invoke(msg);
        }
        
        /// <summary>
        /// Printing info about reading article into the console.
        /// <remarks>
        /// Uses <see cref="Created"/> event
        /// </remarks>
        /// </summary>
        /// <param name="msg">Message to print into the console</param>
        private void OnReadArticle(string msg)
        {
            if (msg != null) Created?.Invoke(msg);
        }
        
        public string _title, _author, _topic, _data, _tags, _articleFile, _allLines;  // Information about article
        private string _allArticles = "B:\\Programming\\course\\articles.txt";  // File with information about all articles
        public Text _text;
        
        /// <summary>
        /// Creates article's file and write information about new article to file with all articles' info
        /// </summary>
        /// <param name="textFile">User's file with article's text</param>
        /// <param name="author">Name of the author of the article</param>
        /// <param name="title">Title of the article</param>
        /// <param name="topic">Topic of the article</param>
        /// <param name="tags">Tags of the article</param>
        public Article(string textFile, string author, string title, string topic, string tags, ArticleStateHandler handler)
        {
            Created += handler;
            _articleFile = $"B:\\Programming\\course\\{author}\\{title}.txt";
            if (!File.Exists(_articleFile))
            {
                _text = new Text(textFile, author, tags.Split(',')[0]);  // Create text file in author's folder
                _data = DateTime.Today.ToShortDateString();
                _title = title;
                _author = author;
                _topic = topic;
                _tags = tags;
                AddToAll();  // Write information about new article
                OnCreatedArticle("Article created!");
            } else
                OnCreatedArticle("This article already exists");
        }
        
        /// <summary>
        /// Constructor for creating an empty object which will be used for calling methods of Article class
        /// </summary>
        public Article(ArticleStateHandler handler) => Created += handler;

        /// <summary>
        /// Adds information about article to the file with all articles' info
        /// </summary>
        private void AddToAll()
        {
            if (!File.Exists(_allArticles))
            {
                StreamWriter articles = File.CreateText(_allArticles);  // Create file for first article
                articles.Close();
            }
            _allLines = $"\n{_author} | {_topic} | {_title} | {_tags} | {_data}";  // Write all data to file
            File.AppendAllText(_allArticles, _allLines);
        }
        
        /// <summary>
        /// Finds articles which matching user's criterion
        /// </summary>
        /// <param name="criterion">Specific criterion of article</param>
        /// <param name="type">Type of the criterion(author,title,topic,date)</param>
        /// <returns>Returns string with all matching articles</returns>
        public string FindByCriterion(string criterion, string type)
        {
            if (File.Exists(_allArticles))
            {
                if (type == "date" && DateTime.Compare(Convert.ToDateTime(criterion), DateTime.Today) > 0)  // Date has to be not later than today's date
                {
                    OnReadArticle("Wrong date!");
                    return null;
                }
                List<string> info = new List<string>();  // Saving info about matching articles here
                foreach (var line in File.ReadAllLines(_allArticles))
                {
                    switch (type)  // Searching by type of the criterion
                    {
                       case "author":
                           if (line != "" && line.Split('|')[0].Contains(criterion))
                               info.Add(line);
                           break;
                       case "topic":
                           if (line != "" && line.Split('|')[1].Contains(criterion))
                               info.Add(line);
                           break;
                       case "title":
                           if (line != "" && line.Split('|')[2].Contains(criterion))
                               info.Add(line);
                           break;
                       case "date":
                           if (line != "" && line.Split('|')[4].Contains(criterion))
                               info.Add(line);
                           break;
                    }
                }
                if (info.Count == 1)   // Return only text from one article
                    return "There is only one article:\n" + string.Join("",File.ReadAllLines($"B:\\Programming\\course\\{info[0].Split('|')[0]}\\{info[0].Split('|')[3].Split(',')[0].Trim()}.txt"));
                if (info.Count != 0)   // Return all information about all matching articles
                    return $"All that was found at request '{type} {criterion}':" + string.Join("\n", info.ToArray());
                OnReadArticle("There are no articles that match your criteria");
                return null;
            }
            OnReadArticle("There are no any articles");
            return null;
        }

        /// <summary>
        /// Finds all articles matching a certain tags
        /// </summary>
        /// <param name="tags">Tags for searching articles</param>
        /// <returns>Returns string with all matching articles</returns>
        public string FindByTags(string[] tags)
        {
            if (File.Exists(_allArticles))
            {
                List<string> info = new List<string>();
                foreach (var line in File.ReadAllLines(_allArticles))
                {
                    foreach (var tag in tags)  // Check every user tag
                    {
                        if (line != "" && line.Split('|')[3].Contains(tag.Trim(',')))
                        {
                            info.Add(line);
                            break;
                        }
                    }
                }
                if (info.Count == 1)   // Return only text from one article
                    return "There is only one article:\n" + string.Join("",File.ReadAllLines($"B:\\Programming\\course\\{info[0].Split('|')[0]}\\{info[0].Split('|')[3].Split(',')[0].Trim()}.txt"));
                if (info.Count != 0)   // Return all information about all matching articles
                    return $"All that was found at request 'tags {string.Join(" ", tags)}':" + string.Join("\n", info.ToArray());
                OnReadArticle("There are no articles that match your criteria");
                return null;
            }
            OnReadArticle("There are no any articles");
            return null;
        }
        
        /// <summary>
        /// Finds all articles matching a certain period
        /// </summary>
        /// <param name="period">Period of time for searching articles</param>
        /// <returns>Returns string with all matching articles</returns>
        public string FindByPeriod(string[] period)
        {
            if (File.Exists(_allArticles))
            {
                // Convert string to date
                DateTime start = Convert.ToDateTime(period[0]);
                DateTime end = Convert.ToDateTime(period[1]);
                // Check if dates are correct: first date is earlier than the second one. Both aren't later than today's date
                if (DateTime.Compare(start, end)<0 && DateTime.Compare(start, DateTime.Today)<0 && DateTime.Compare(end, DateTime.Today)<=0)
                {
                    List<string> info = new List<string>();
                    foreach (var line in File.ReadAllLines(_allArticles))
                    {
                        if (line == "")
                            continue;
                        DateTime userDate = Convert.ToDateTime(line.Split('|')[4]);  // Take date from article
                        // Compare article's date with start and end dates
                        if ((DateTime.Compare(start, userDate) < 0 && DateTime.Compare(end, userDate) > 0) || 
                            DateTime.Compare(start, userDate) == 0 || DateTime.Compare(end, userDate) == 0)
                            info.Add(line);
                    }
                    if (info.Count == 1)  // Return only text from one article
                        return "There is only one article:\n" + string.Join("",File.ReadAllLines($"B:\\Programming\\course\\{info[0].Split('|')[0]}\\{info[0].Split('|')[3].Split(',')[0].Trim()}.txt"));
                    if (info.Count != 0)  // Return all information about all matching articles
                        return $"All that was found at request 'period {string.Join(" ", period)}':\n" + string.Join("\n", info.ToArray());
                    OnReadArticle("There are no articles that match your criteria");
                    return null;
                }
                OnReadArticle("Wrong dates!");
                return null;
            }
            OnReadArticle("There are no any articles");
            return null;
        }
        
        /// <summary>
        /// Finds all information about specific article in the file with all articles' data
        /// </summary>
        /// <param name="author">Name of author of the article</param>
        /// <param name="title">Title of the article</param>
        /// <returns>Return string with article's information or null if there is no such article</returns>
        public string GetInformation(string author, string title)
        {
            foreach (var line in File.ReadAllLines(_allArticles))
            {
                if (line == "")
                    continue;
                if (line.Contains($"{author}") && line.Contains($"{title}"))  // Searching for article's information
                    return line;
            }
            OnReadArticle("There is no such article");
            return null;
        }
    }
}