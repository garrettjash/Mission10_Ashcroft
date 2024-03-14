using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Mission10_Ashcroft.Models;

public partial class Team
{
    
    public int TeamId { get; set; }

    public string? TeamName { get; set; }

    public int? CaptainId { get; set; }
    [JsonIgnore]
    public virtual ICollection<Bowler> Bowlers { get; set; } = new List<Bowler>();

}
