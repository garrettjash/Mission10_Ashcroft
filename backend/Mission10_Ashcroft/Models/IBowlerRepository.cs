namespace Mission10_Ashcroft.Models
{
    public interface IBowlerRepository
    {
        IEnumerable<Bowler> bowlers { get; }
        IEnumerable<Team> teams { get; }
    }
}
