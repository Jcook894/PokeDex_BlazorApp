using System.Threading.Tasks;
using PokeApiNet;
using PokeApiNet.Models;

namespace TestBlazorApp.Data
{
    public class PokeApiService
    {
        public async Task<PokeData> GetPokemonData(string pkmnName)
        {
            PokeApiClient _pokeApiClient = new PokeApiClient();

            Pokemon pkmn = await _pokeApiClient.GetResourceAsync<Pokemon>(pkmnName);

            PokeData pokeData = new PokeData
            {
                DexEntry = pkmn.Id,
                Name = pkmn.Name,
                PkmnSprite = pkmn.Sprites.FrontDefault,
                PkmnShinySprite = pkmn.Sprites.FrontShiny,

            };

            return pokeData;
        }
    }
}
