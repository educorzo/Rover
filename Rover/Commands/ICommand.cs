namespace Rover;

public interface ICommand
{
    void Execute(RoverVehicle rover);
}