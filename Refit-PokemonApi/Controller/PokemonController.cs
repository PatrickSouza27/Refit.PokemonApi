using Microsoft.AspNetCore.Mvc;
using Refit.Services;

namespace Refit.Controller;

[ApiController]
public class PokemonController : ControllerBase
{
    private readonly IPokeService _pokeService;

    public PokemonController(IPokeService pokeService)
    {
        _pokeService = pokeService;
    }

    [HttpGet("pokemon")]
    public async Task<IActionResult> GetPokemon([FromQuery] int limit)
    {
        var pokemon = await _pokeService.GetAll(limit);
        return Ok(pokemon.Results);
    }
}