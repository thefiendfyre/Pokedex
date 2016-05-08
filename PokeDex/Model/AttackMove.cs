using System;

namespace PokeDex.Model
{
    /// <summary>
    /// Holds data for the AttackMove class.
    /// </summary>
    /// <author>
    /// Danl Doremus
    /// </author>
    /// <version>
    /// Summer 2016
    /// </version>
    internal class AttackMove
    {
        /// <summary>
        /// The level the Pokemon learns this AttackMove.
        /// </summary>
        /// <value>
        /// The level learned.
        /// </value>
        public int LevelLearned { get; set; }
        /// <summary>
        /// The name of this AttackMove.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }
        /// <summary>
        /// The type of this AttackMove.
        /// </summary>
        /// <value>
        /// The type.
        /// </value>
        public ElementType Type { get; set; }

        /// <summary>
        /// How powerful this AttackMove is.
        /// </summary>
        /// <value>
        /// The power.
        /// </value>
        public int Power { get; set; }

        /// <summary>
        /// The accuracy of this AttackMove.
        /// </summary>
        /// <value>
        /// The accuracy.
        /// </value>
        public int Accuracy { get; set; }

        /// <summary>
        /// The power points of this AttackMove; how many times the attack can be used.
        /// </summary>
        /// <value>
        /// The power points.
        /// </value>
        public int PowerPoints { get; set; }

        /// <summary>
        /// The description of this AttackMove.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        public string Description { get; set; }
        
    }
}