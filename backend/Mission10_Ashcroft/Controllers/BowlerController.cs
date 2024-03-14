using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Mission10_Ashcroft.Controllers;
using Mission10_Ashcroft.Models;
using System.Text.Json.Serialization;
using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Mission10_Ashcroft.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BowlerController : ControllerBase
    {
        private IBowlerRepository _bowlerRepository;

        public BowlerController(IBowlerRepository temp)
        {
            _bowlerRepository = temp;
        }

        public IEnumerable<Bowler> Get()
        {
            var joinedData = from bowler in _bowlerRepository.bowlers
                             join team in _bowlerRepository.teams
                             on bowler.TeamId equals team.TeamId
                             select new Bowler
                             {
                                 BowlerId = bowler.BowlerId,
                                 BowlerLastName = bowler.BowlerLastName,
                                 BowlerFirstName = bowler.BowlerFirstName,
                                 BowlerMiddleInit = bowler.BowlerMiddleInit,
                                 BowlerAddress = bowler.BowlerAddress,
                                 BowlerCity = bowler.BowlerCity,
                                 BowlerState = bowler.BowlerState,
                                 BowlerZip = bowler.BowlerZip,
                                 BowlerPhoneNumber = bowler.BowlerPhoneNumber,
                                 TeamId = team.TeamId,
                                 Team = bowler.Team,
                             };

            return joinedData.ToList(); // Convert the result to a list of Bowler objects and return
        }

    }
}

