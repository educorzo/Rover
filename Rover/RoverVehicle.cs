namespace Rover;

public class RoverVehicle
{
    private IDirectionState _direction;
    private Position _position;

    public RoverVehicle()
    {
        _direction = new NorthDirection();
        _position = new Position(0,0);
    }

    public void RotateLeft()
    {
        _direction = _direction.RotateLeft();
    }
    
    public void RotateRight()
    {
        _direction = _direction.RotateRight();
    }

    public void Move()
    {
        _position = _direction.Move(_position);
    }
    
    public string Execute(string command)
    {
        var commandParser = new CommandParser(AvailableCommands.List);
        
        foreach (var c in command.ToCharArray())
        {
            var commandToExecute = commandParser.ParseCommand(c.ToString());
            commandToExecute.Execute(this);
        }
        
        return _position + ":" + _direction;
    }
}