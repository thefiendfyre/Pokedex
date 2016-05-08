namespace PokeDex.Model
{
    /// <summary>
    ///     Holds data for the AttackMove class.
    /// </summary>
    /// <author>
    ///     Danl Doremus
    /// </author>
    /// <version>
    ///     Summer 2016
    /// </version>
    internal class AttackMove
    {
        #region Properties

        /// <summary>
        ///     The level the Pokemon learns this AttackMove.
        /// </summary>
        /// <value>
        ///     The level learned.
        /// </value>
        public int LevelLearned { get; private set; }

        /// <summary>
        ///     The name of this AttackMove.
        /// </summary>
        /// <value>
        ///     The name.
        /// </value>
        public string Name { get; private set; }

        /// <summary>
        ///     The type of this AttackMove.
        /// </summary>
        /// <value>
        ///     The type.
        /// </value>
        public ElementType Type { get; private set; }

        /// <summary>
        ///     How powerful this AttackMove is.
        /// </summary>
        /// <value>
        ///     The power.
        /// </value>
        public int Power { get; private set; }

        /// <summary>
        ///     The accuracy of this AttackMove.
        /// </summary>
        /// <value>
        ///     The accuracy.
        /// </value>
        public int Accuracy { get; private set; }

        /// <summary>
        ///     The power points of this AttackMove; how many times the attack can be used.
        /// </summary>
        /// <value>
        ///     The power points.
        /// </value>
        public int PowerPoints { get; private set; }

        /// <summary>
        ///     The description of this AttackMove.
        /// </summary>
        /// <value>
        ///     The description.
        /// </value>
        public string Description { get; private set; }

        #endregion

        /// <summary>
        /// Prevents a default instance of the <see cref="AttackMove"/> class from being created.
        /// </summary>
        AttackMove()
        {
            
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AttackMove"/> class.
        /// </summary>
        /// <param name="levelLearned">The level learned.</param>
        /// <param name="name">The name.</param>
        /// <param name="type">The type.</param>
        /// <param name="power">The power.</param>
        /// <param name="accuracy">The accuracy.</param>
        /// <param name="powerPoints">The power points.</param>
        /// <param name="description">The description.</param>
        public AttackMove(int levelLearned, string name, ElementType type, int power, int accuracy, int powerPoints, string description)
        {
            this.LevelLearned = levelLearned;
            this.Name = name;
            this.Type = type;
            this.Power = power;
            this.Accuracy = accuracy;
            this.PowerPoints = powerPoints;
            this.Description = description;
        }
    }
}