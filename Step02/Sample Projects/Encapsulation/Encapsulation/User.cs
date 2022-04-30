namespace Encapsulation
{
    /// <summary>
    /// Sample class for testing the Encapsulation
    /// </summary>
    public class User
    {
        #region Private fields
        // private field for the location of the user
        private string location;
        // private field for the name of the user
        private string name;
        #endregion

        #region Sets The Location
        /// <summary>
        /// Gets or sets the location of the user
        /// </summary>
        public string Location
        {
            get => location;
            set => location = value;
        }
        #endregion

        #region Sets The Name
        /// <summary>
        /// Gets or sets the name of the user
        /// </summary>
        public string Name
        {
            get => name;
            set => name = value;
        }
        #endregion
    }
}
