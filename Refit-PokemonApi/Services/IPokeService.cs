using Refit.DTO;

namespace Refit.Services;

public interface IPokeService
{
    [Get("/pokemon")]
    Task<PokemonResponse> GetAll(int limit);

}