namespace Rover;

public class RotateRightCommand : ICommand
{
    public void Execute(RoverVehicle rover)
    {
        rover.RotateRight();
    }
}