namespace Rover;

public class SouthDirection : IDirectionState
{
    public IDirectionState RotateLeft()
    {
        return new EastDirection();
    }
    
    public IDirectionState RotateRight()
    {
        return new WestDirection();
    }
    
    public Position Move(Position position)
    {
        return position.MoveSouth();
    }
    
    public override string ToString()
    {
        return "S";
    }
}