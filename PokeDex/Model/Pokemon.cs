namespace PokeDex.Model
{
    /// <summary>
    /// Holds data for the Pokemon class.
    /// </summary>
    /// <author>
    /// Danl Doremus
    /// </author>
    /// <version>
    /// Summer 2016
    /// </version>
    internal class Pokemon
    {
        #region Properties

        /// <summary>
        /// Gets or sets the height.
        /// </summary>
        /// <value>
        /// The height.
        /// </value>
        public double Height { get; set; }

        /// <summary>
        /// Gets or sets the weight.
        /// </summary>
        /// <value>
        /// The weight.
        /// </value>
        public double Weight { get; set; }

        /// <summary>
        /// Gets or sets the pokedex number.
        /// </summary>
        /// <value>
        /// The pokedex number.
        /// </value>
        public int PokedexNumber { get; set; }  

        

        #endregion
    }
}