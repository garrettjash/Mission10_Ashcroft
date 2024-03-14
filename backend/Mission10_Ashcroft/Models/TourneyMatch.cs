using System;
using System.Collections.Generic;

namespace Mission10_Ashcroft.Models;

public partial class TourneyMatch
{
    public int MatchId { get; set; }

    public int? TourneyId { get; set; }

    public string? Lanes { get; set; }

    public int? OddLaneTeamId { get; set; }

    public int? EvenLaneTeamId { get; set; }

    public virtual Team? EvenLaneTeam { get; set; }

    public virtual ICollection<MatchGame> MatchGames { get; set; } = new List<MatchGame>();

    public virtual Team? OddLaneTeam { get; set; }

    public virtual Tournament? Tourney { get; set; }
}
