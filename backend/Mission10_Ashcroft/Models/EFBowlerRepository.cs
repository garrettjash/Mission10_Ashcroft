using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.EntityFrameworkCore;

namespace Mission10_Ashcroft.Models
{
    public class EFBowlerRepository : IBowlerRepository
    {
        private BowlingLeagueContext _context;
        public EFBowlerRepository(BowlingLeagueContext temp)
        {
            _context = temp;
        }
        public IEnumerable<Bowler> bowlers => _context.Bowlers;

        public IEnumerable<Team> teams => _context.Teams;
    }
}