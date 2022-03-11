namespace Rover;

public class NorthDirection : IDirectionState
{
    public IDirectionState RotateLeft()
    {
        return new WestDirection();
    }
    
    public IDirectionState RotateRight()
    {
        return new EastDirection();
    }
    
    public Position Move(Position position)
    {
        return position.MoveNorth();
    }
    
    public override string ToString()
    {
        return "N";
    }
}