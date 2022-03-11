namespace Rover;

public class MoveCommand : ICommand
{
    public void Execute(RoverVehicle rover)
    {
        rover.Move();
    }
}