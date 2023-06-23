public class Player
{
    public int Position { get; }
    public string Name { get; }
    public int DefensiveRating { get; }
    public int OffensiveRating { get; }

    public Player(int position, string name, int offensiveRating, int defensiveRating)
    {
        Position = position;
        Name = name;
        OffensiveRating = offensiveRating;
        DefensiveRating = defensiveRating;
    }
}
