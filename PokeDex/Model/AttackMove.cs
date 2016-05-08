using System;

namespace PokeDex.Model
{
    /// <summary>
    ///     Holds data for the AttackMove class.
    /// </summary>
    /// <version>
    ///     Summer 2016
    /// </version>
    /// <author>
    ///     Danl Doremus
    /// </author>
    internal class AttackMove
    {
        public int LevelLearned { get; set; }
        public String Name { get; set; }
        public Types Type { get; set; }
        
    }
}