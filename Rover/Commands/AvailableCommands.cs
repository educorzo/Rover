namespace Rover;

public static class AvailableCommands
{
    public static Dictionary<string, ICommand> List
    {
        get
        {
            var commands = new Dictionary<string, ICommand>
            {
                {"M", new MoveCommand()},
                {"L", new RotateLeftCommand()},
                {"R", new RotateRightCommand()}
            };
            return commands;
        }
    }
}