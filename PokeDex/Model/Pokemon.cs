using System.Collections.Generic;

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
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the classification.
        /// </summary>
        /// <value>
        /// The classification.
        /// </value>
        public string Classification { get; set; }

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

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>
        /// The type.
        /// </value>
        public List<ElementType> Types { get; set; }

        /// <summary>
        /// Gets or sets the attack moves.
        /// </summary>
        /// <value>
        /// The attack moves.
        /// </value>
        public List<AttackMove> AttackMoves { get; set; }

        /// <summary>
        /// Gets or sets the abilities.
        /// </summary>
        /// <value>
        /// The abilities.
        /// </value>
        public List<Ability> Abilities { get; set; }

        #endregion
    }
}