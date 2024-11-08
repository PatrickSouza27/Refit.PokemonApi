using Refit.Models;

namespace Refit.DTO;

public class PokemonResponse
{
    public int Count { get; set; }
    public string Next { get; set; }
    public object Previous { get; set; }
    public List<Pokemon> Results { get; set; }
    
}
