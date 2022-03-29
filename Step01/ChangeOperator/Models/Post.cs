namespace ChangeOperator.Models
{
    /// <summary>
    /// The model for the change operator page.
    /// </summary>
    public class Post
    {
        /// <summary>
        /// The title of the post.
        /// </summary>
        public string? Title { get; set; }
        /// <summary>
        /// The view count of the post.
        /// </summary>
        public int ViewCount { get; set; }

        /// <summary>
        /// Post + operator
        /// </summary>
        /// <param name="a">First post</param>
        /// <param name="b">Second post</param>
        /// <returns></returns>
        public static int operator +(Post a, Post b)
        {
            return a.ViewCount + b.ViewCount;
        }
    }
}
