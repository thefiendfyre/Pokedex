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
        /// <param name="name">The name.</param>
        /// <param name="classification">The classification.</param>
        /// <param name="pokedexNumber">The pokedex number.</param>
        public Pokemon(string name, string classification, int pokedexNumber)
        {
            this.Name = name;
            this.Classification = classification;
            this.PokedexNumber = pokedexNumber;
        }

        /// <summary>
        ///     Sets the height.
        /// </summary>
        /// <param name="height">The height.</param>
        public void SetHeight(double height)
        {
            this.Height = height;
        }

        /// <summary>
        ///     Sets the weight.
        /// </summary>
        /// <param name="weight">The weight.</param>
        public void SetWeight(double weight)
        {
            this.Weight = weight;
        }

        /// <summary>
        ///     Sets the attack moves.
        /// </summary>
        /// <param name="attackMoves">The attack moves.</param>
        public void SetAttackMoves(List<AttackMove> attackMoves)
        {
            this.AttackMoves = attackMoves;
        }

        /// <summary>
        ///     Sets the types.
        /// </summary>
        /// <param name="types">The types.</param>
        public void SetTypes(List<ElementType> types)
        {
            this.Types = types;
        }

        /// <summary>
        ///     Sets the abilities.
        /// </summary>
        /// <param name="abilities">The abilities.</param>
        public void SetAbilities(List<Ability> abilities)
        {
            this.Abilities = abilities;
        }

        /// <summary>
        ///     Sets the stats.
        /// </summary>
        /// <param name="stats">The stats.</param>
        public void SetStats(List<Stat> stats)
        {
            this.Stats = stats;
        }

        #endregion
    }
}