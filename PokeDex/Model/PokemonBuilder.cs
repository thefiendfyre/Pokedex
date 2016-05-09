using System.Collections.Generic;

namespace PokeDex.Model
{
    /// <summary>
    /// </summary>
    internal class PokemonBuilder
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

        /// <summary>
        ///     Sets the name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public PokemonBuilder SetName(string name)
        {
            this.Name = name;
            return this;
        }

        /// <summary>
        ///     Sets the classification.
        /// </summary>
        /// <param name="classification">The classification.</param>
        /// <returns></returns>
        public PokemonBuilder SetClassification(string classification)
        {
            this.Classification = classification;
            return this;
        }

        /// <summary>
        ///     Sets the pokedex number.
        /// </summary>
        /// <param name="pokedexNumber">The pokedex number.</param>
        /// <returns></returns>
        public PokemonBuilder SetPokedexNumber(int pokedexNumber)
        {
            this.PokedexNumber = pokedexNumber;
            return this;
        }

        /// <summary>
        ///     Sets the height.
        /// </summary>
        /// <param name="height">The height.</param>
        /// <returns></returns>
        public PokemonBuilder SetHeight(double height)
        {
            this.Height = height;
            return this;
        }

        /// <summary>
        ///     Sets the weight.
        /// </summary>
        /// <param name="weight">The weight.</param>
        /// <returns></returns>
        public PokemonBuilder SetWeight(double weight)
        {
            this.Weight = weight;
            return this;
        }

        /// <summary>
        ///     Sets the types.
        /// </summary>
        /// <param name="types">The types.</param>
        /// <returns></returns>
        public PokemonBuilder SetTypes(List<ElementType> types)
        {
            this.Types = types;
            return this;
        }

        /// <summary>
        ///     Sets the attack moves.
        /// </summary>
        /// <param name="attackMoves">The attack moves.</param>
        /// <returns></returns>
        public PokemonBuilder SetAttackMoves(List<AttackMove> attackMoves)
        {
            this.AttackMoves = attackMoves;
            return this;
        }

        /// <summary>
        ///     Sets the abilities.
        /// </summary>
        /// <param name="abilities">The abilities.</param>
        /// <returns></returns>
        public PokemonBuilder SetAbilities(List<Ability> abilities)
        {
            this.Abilities = abilities;
            return this;
        }

        /// <summary>
        ///     Sets the stats.
        /// </summary>
        /// <param name="stats">The stats.</param>
        /// <returns></returns>
        public PokemonBuilder SetStats(List<Stat> stats)
        {
            this.Stats = stats;
            return this;
        }

        /// <summary>
        ///     Builds this instance.
        /// </summary>
        /// <returns></returns>
        public Pokemon Build()
        {
            return new Pokemon(this);
        }
    }
}