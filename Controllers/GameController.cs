using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RockPaperScissorsEndPoint.Services;

namespace RockPaperScissorsEndPoint.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GameController : ControllerBase
    {
        private readonly GameServices _gameServices;

        public GameController(GameServices gameServices)
        {
            _gameServices = gameServices;
        }

        [HttpGet]
        [Route("RockPaperScissors")]
        public string CPUChoice()
        {
            return _gameServices.CPUChoice();
        }
    }
}