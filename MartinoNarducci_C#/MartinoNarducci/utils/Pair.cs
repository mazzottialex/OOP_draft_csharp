public class Pair<TX, TY>
{
    public TX X { get; set; }
    public TY Y { get; set; }

    public Pair(TX x, TY y)
    {
        X = x;
        Y = y;
    }
}
