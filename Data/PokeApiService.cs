using System.Threading.Tasks;
using PokeApiNet;
using PokeApiNet.Models;
using TestBlazorApp.Models;

namespace TestBlazorApp.Data
{
    public class PokeApiService
    {
        public async Task<PokeSpriteData> GetPokeSprite(string pkmnName)
        {
            PokeApiClient _pokeApiClient = new PokeApiClient();

            Pokemon pkmn = await _pokeApiClient.GetResourceAsync<Pokemon>(pkmnName);

            PokeSpriteData pokeData = new PokeSpriteData
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
