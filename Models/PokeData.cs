using System.Collections.Generic;
using PokeApiNet.Models;

namespace TestBlazorApp.Models
{
    public class PokeData
    {
        public string Name { get; set; }
        public int DexEntry { get; set; }
        public string PkmnSprite {get; set;}
        public string PkmnShinySprite {get; set;}
        public List<Descriptions> PkmnDesc {get; set;}
    }
}
