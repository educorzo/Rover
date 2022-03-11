namespace Rover;

public class WestDirection : IDirectionState
{
    public IDirectionState RotateLeft()
    {
        return new SouthDirection();
    }
    
    public IDirectionState RotateRight()
    {
        return new NorthDirection();
    }
    
    public Position Move(Position position)
    {
        return position.MoveWest();
    }

    public override string ToString()
    {
        return "W";
    }
}