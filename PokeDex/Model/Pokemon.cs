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
        ///     Gets the stats.
        /// </summary>
        /// <value>
        ///     The stats.
        /// </value>
        public List<Stat> Stats { get; private set; }

        #endregion

        #region Constructors

        /// <summary>
        ///     Prevents a default instance of the <see cref="Pokemon" /> class from being created.
        /// </summary>
        private Pokemon()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Pokemon" /> class.
        /// </summary>
        /// <param name="pokemonBuilder">The pokemon builder.</param>
        public Pokemon(PokemonBuilder pokemonBuilder)
        {
            this.Name = pokemonBuilder.Name;
            this.Classification = pokemonBuilder.Classification;
            this.PokedexNumber = pokemonBuilder.PokedexNumber;
            this.Height = pokemonBuilder.Height;
            this.Weight = pokemonBuilder.Weight;
            this.Types = pokemonBuilder.Types;
            this.Abilities = pokemonBuilder.Abilities;
            this.AttackMoves = pokemonBuilder.AttackMoves;
            this.Stats = pokemonBuilder.Stats;
        }

        #endregion
    }
}