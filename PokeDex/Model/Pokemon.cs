using System.Collections.Generic;

namespace PokeDex.Model
{
    /// <summary>
    ///     Holds data for the Pokemon class.
    /// </summary>
    /// <author>
    ///     Danl Doremus
    /// </author>
    /// <version>
    ///     Summer 2016
    /// </version>
    internal class Pokemon
    {
        #region Properties

        /// <summary>
        ///     Gets or sets the name.
        /// </summary>
        /// <value>
        ///     The name.
        /// </value>
        public string Name { get; private set; }

        /// <summary>
        ///     Gets or sets the classification.
        /// </summary>
        /// <value>
        ///     The classification.
        /// </value>
        public string Classification { get; private set; }

        /// <summary>
        ///     Gets or sets the height.
        /// </summary>
        /// <value>
        ///     The height.
        /// </value>
        public double Height { get; private set; }

        /// <summary>
        ///     Gets or sets the weight.
        /// </summary>
        /// <value>
        ///     The weight.
        /// </value>
        public double Weight { get; private set; }

        /// <summary>
        ///     Gets or sets the pokedex number.
        /// </summary>
        /// <value>
        ///     The pokedex number.
        /// </value>
        public int PokedexNumber { get; private set; }

        /// <summary>
        ///     Gets or sets the type.
        /// </summary>
        /// <value>
        ///     The type.
        /// </value>
        public List<ElementType> Types { get; private set; }

        /// <summary>
        ///     Gets or sets the attack moves.
        /// </summary>
        /// <value>
        ///     The attack moves.
        /// </value>
        public List<AttackMove> AttackMoves { get; private set; }

        /// <summary>
        ///     Gets or sets the abilities.
        /// </summary>
        /// <value>
        ///     The abilities.
        /// </value>
        public List<Ability> Abilities { get; private set; }

        /// <summary>
        /// Gets the stats.
        /// </summary>
        /// <value>
        /// The stats.
        /// </value>
        public List<Stat> Stats { get; private set; }

        #endregion

        /// <summary>
        /// Prevents a default instance of the <see cref="Pokemon"/> class from being created.
        /// </summary>
        Pokemon()
        {
            
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Pokemon" /> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="classification">The classification.</param>
        /// <param name="height">The height.</param>
        /// <param name="weight">The weight.</param>
        /// <param name="pokedexNumber">The pokedex number.</param>
        /// <param name="stats">The stats.</param>
        /// <param name="types">The types.</param>
        /// <param name="attackMoves">The attack moves.</param>
        /// <param name="abilities">The abilities.</param>
        public Pokemon(string name, string classification, double height, double weight, int pokedexNumber, List<Stat> stats, List<ElementType> types, List<AttackMove> attackMoves, List<Ability> abilities)
        {
            this.Name = name;
            this.Classification = classification;
            this.Height = height;
            this.Weight = weight;
            this.PokedexNumber = pokedexNumber;
            this.Stats = stats;
            this.Types = types;
            this.AttackMoves = attackMoves;
            this.Abilities = abilities;
        }
    }
}