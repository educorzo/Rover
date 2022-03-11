namespace Rover;

public class Position
{
    private readonly int _x;
    private readonly int _y;

    public Position(int x, int y)
    {
        _x = x;
        _y = y;
    }

    public Position MoveNorth()
    {
        return new Position(_x, _y + 1);
    }
    
    public Position MoveWest()
    {
        return new Position(_x-1, _y);
    }
    
    public Position MoveEast()
    {
        return new Position(_x+1, _y);
    }
    
    public Position MoveSouth()
    {
        return new Position(_x, _y-1);
    }

    public override string ToString()
    {
        return _x+":"+_y;
    }
}