using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TareaAPI.Models;

namespace TareaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FootbalPlayerController : ControllerBase
    {
        private static List<FootbalPlayer> _players = new List<FootbalPlayer>
        {
            new FootbalPlayer
            {
                ID = 1,
                FullName = "Cristiano Ronaldo",
                Team = "Al-Nassr",
                Goals = "873"
            },
            new FootbalPlayer
            {
                ID = 2,
                FullName = "Lionel Messi",
                Team = "Inter Miami CF",
                Goals = "800"
            },
            new FootbalPlayer
            {
                ID = 3,
                FullName = "Robert Lewandowski",
                Team = "Fútbol Club Barcelona",
                Goals = "500"
            },
            new FootbalPlayer
            {
                ID = 4,
                FullName = "Kylian Mbappé",
                Team = "París Saint-Germán",
                Goals = "310"
            }
        };

        [HttpGet]
        public IEnumerable<FootbalPlayer> GetAllPlayers()
        {
            return _players;
        }
    }
}
