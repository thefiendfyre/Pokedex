using System.Collections.Specialized;

namespace PokeDex.Model
{
    /// <summary>
    /// Holds data for the Stat class.
    /// </summary>
    /// <author>
    /// Danl Doremus
    /// </author>
    /// <version>
    /// Summer 2016
    /// </version>
    internal class Stat
    {
        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; private set; }

        /// <summary>
        /// Gets the attribute.
        /// </summary>
        /// <value>
        /// The attribute.
        /// </value>
        public int Attribute { get; private set; }

        /// <summary>
        /// Prevents a default instance of the <see cref="Stat"/> class from being created.
        /// </summary>
        Stat()
        {
            
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Stat"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="attribute">The attribute.</param>
        public Stat(string name, int attribute)
        {
            this.Name = name;
            this.Attribute = attribute;
        }
    }
}