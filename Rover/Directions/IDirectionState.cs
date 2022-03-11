namespace Rover;

public interface IDirectionState
{
    public IDirectionState RotateLeft();
    public IDirectionState RotateRight();
    public Position Move(Position position);
}