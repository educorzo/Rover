namespace Rover;

public class EastDirection : IDirectionState
{
    public IDirectionState RotateLeft()
    {
        return new NorthDirection();
    }
    
    public IDirectionState RotateRight()
    {
        return new SouthDirection();
    }

    public Position Move(Position position)
    {
        return position.MoveEast();
    }

    public override string ToString()
    {
        return "E";
    }
}