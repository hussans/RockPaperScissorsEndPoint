using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RockPaperScissorsEndPoint.Services
{
    public class GameServices
    {
        public string CPUChoice()
        {
            string[] choices = { "Rock", "Paper", "Scissors", "Lizard", "Spock" };
            return choices[new Random().Next(5)];
        }
    }
}