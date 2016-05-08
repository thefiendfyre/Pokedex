namespace PokeDex.Model
{
    /// <summary>
    ///     Holds data for the Ability class.
    /// </summary>
    /// <author>
    ///     Danl Doremus
    /// </author>
    /// <version>
    ///     Summer 2016
    /// </version>
    internal class Ability
    {
        #region Properties

        /// <summary>
        ///     The name of the Ability.
        /// </summary>
        /// <value>
        ///     The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        ///     The description of the Ability.
        /// </summary>
        /// <value>
        ///     The description.
        /// </value>
        public string Description { get; set; }

        #endregion

        /// <summary>
        /// Prevents a default instance of the <see cref="Ability"/> class from being created.
        /// </summary>
        Ability()
        {
            
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Ability"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="description">The description.</param>
        public Ability(string name, string description)
        {
            this.Name = name;
            this.Description = description;
        }
    }
}