public class Player
{
    private string name;
    private string marker;

    private bool isComputer;

    public Player(string name, string marker, bool isComputer = false)
    {
        this.name = name;
        this.marker = marker;

        this.isComputer = isComputer;
    }

    public string GetName()
    {
        return name;
    }

    public string GetMarker()
    {
        return marker;
    }
    public bool IsComputer()
    {
        return isComputer;
    }
}