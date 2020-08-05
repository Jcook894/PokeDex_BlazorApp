using System.Threading.Tasks;
using PokeApiNet;
using PokeApiNet.Models;
using TestBlazorApp.Models;

namespace TestBlazorApp.Data
{
    public class PokeApiService
    {
        public async Task<PokeSpriteData> GetPokemonData(string pkmnName)
        {
            PokeApiClient _pokeApiClient = new PokeApiClient();

            Pokemon pkmn = await _pokeApiClient.GetResourceAsync<Pokemon>(pkmnName);

            Pokedex dexInfo = await _pokeApiClient.GetResourceAsync<Pokedex>(pkmn.Id);
            
            return new PokeSpriteData
            {
                DexEntry = pkmn.Id,
                Name = pkmn.Name,
                PkmnSprite = pkmn.Sprites.FrontDefault,
                PkmnShinySprite = pkmn.Sprites.FrontShiny,
                PokemonDescription = dexInfo.Descriptions,
            };
        }
    }
}
