using System.Collections.Generic;

namespace PokeDex.Model
{
    /// <summary>
    ///     Holds data for the Pokedex class.
    /// </summary>
    /// <version>
    ///     Summer 2016
    /// </version>
    /// <author>
    ///     Danl Doremus
    /// </author>
    internal class Pokedex
    {
        #region Data members

        private List<Pokemon> pokemon;
        private Pokemon pokemonDexEntry;
        private PokemonBuilder pokemonBuilder;

        #endregion

        #region Constructors

        private Pokedex()
        {
            this.pokemon = new List<Pokemon>();

            //Example on how to use the Build Pattern
            this.pokemonDexEntry =
                this.pokemonBuilder.SetName("Pikachu")
                    .SetClassification("Mouse Pokemon")
                    .SetHeight(1.04)
                    .SetWeight(13.2)
                    .Build();
        }

        #endregion
    }
}