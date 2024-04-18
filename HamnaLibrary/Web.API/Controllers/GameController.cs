using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Web.API.Controllers;

[ApiController]
[Route("[controller]")]
public class GameController : ControllerBase
{
    private readonly ILogger<GameController> _logger;

    public GameController(ILogger<GameController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetGames")]
    public IEnumerable<Game> Get()
    {
        return new List<Game>() {
            new Game()
            {
                Id = 1,
                Name = "Street Fighter II",
                Genre ="Fighting",
                Price = 50,
                ReleaseDate= new DateTime(),

            },
            new Game()
            {
                   Id = 2,
                Name = "Final Fantasy",
                Genre ="Role Playing",
                Price = 50,
                ReleaseDate= new DateTime(),

            },
            new Game()
            {
                   Id = 3,
                Name = "FIFA 23",
                Genre ="Sports",
                Price = 50,
                ReleaseDate= new DateTime(),

            }
             }.AsEnumerable();
    }
}

