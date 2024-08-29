public class Player
{
    private string name;
    private string marker;

    public Player(string name, string marker)
    {
        this.name = name;
        this.marker = marker;
    }

    public string GetName()
    {
        return name;
    }

    public string GetMarker()
    {
        return marker;
    }
}