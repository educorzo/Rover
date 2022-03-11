namespace Rover;

public class RotateLeftCommand : ICommand
{
    public void Execute(RoverVehicle rover)
    {
        rover.RotateLeft();
    }
}