namespace Rover;

public class RoverVehicle
{
    private string _direction;
    private int _x;
    private int _y;

    public RoverVehicle()
    {
        _direction = "N";
    }

    private void Move()
    {
        switch (_direction)
        {
            case "N":
                _y++;
                break;
            case "W":
                _x--;
                break;
            case "S":
                _y--;
                break;
            case "E":
                _x++;
                break;
        }
    }
    
    public string Execute(string command)
    {

        foreach (var c in command.ToCharArray())
        {
            switch (c)
            {
                case 'L':
                    _direction = RotateLeft();  
                    continue;
                case 'R':
                    _direction = RotateRight();
                    break;
                case 'M':
                    Move();
                    break;
            }
        }
        
        return _x + ":" + _y + ":" + _direction;
    }
    
    private string RotateLeft()
    {
        if (_direction == "N")
            return "W";
        if (_direction == "W")
            return "S";
        if (_direction == "S")
            return "E";
        return "N";
    }
    
    private string RotateRight()
    {
        if (_direction == "N")
            return "E";
        if (_direction == "W")
            return "N";
        if (_direction == "S")
            return "W";
        return "S";
    }
}