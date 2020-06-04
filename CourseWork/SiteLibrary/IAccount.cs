namespace SiteLibrary
{
    /// <summary>
    /// Interface for creating Admin, Editor and Reader classes
    /// </summary>
    public interface IAccount
    {
        /// <summary>
        /// Creates article using constructor of Article - <see cref="Article(string, string, string, string, string, ArticleStateHandler)"/>
        /// </summary>
        /// <param name="textFile">File with article's text</param>
        /// <param name="author">Name of the author of the article</param>
        /// <param name="title">Title of the article</param>
        /// <param name="topic">Topic of the article</param>
        /// <param name="tags">Tags of the article</param>
        void CreateArticle(string textFile, string author, string title, string topic, string tags, ArticleStateHandler handler);
        
        /// <summary>
        /// Finds file with name of 1st article's tag in author's directory and returns content
        /// </summary>
        /// <param name="author">Name of the author of the article</param>
        /// <param name="title">Title of the article</param>
        /// <returns>Text of the article</returns>
        string ReadArticle(string author, string title);
        
        /// <summary>
        /// Deleting for Editors(they can delete only their own articles). Uses <see cref="Account.DeleteArticle(string, string)"/>
        /// </summary>
        /// <param name="author">Name of the author of the article</param>
        /// <param name="title">Title of article</param>
        /// <param name="user">Current authorized user</param>
        void DeleteArticle(string author, string title, string user);
        
        /// <summary>
        /// Deletes file with article in author's directory
        /// </summary>
        /// <param name="author">Name of the author of the article</param>
        /// <param name="title">Title of article</param>
        void DeleteArticle(string author, string title);
        
        /// <summary>
        /// Adds article to user's bookmarks
        /// </summary>
        /// <param name="title">Bookmark title</param>
        void AddToBookmarks(string title);
        
        /// <summary>
        /// Shows user's bookmarks
        /// </summary>
        /// <returns>String with all user's bookmarks, joined with ';'</returns>
        string ShowBookmarks();
    }
}