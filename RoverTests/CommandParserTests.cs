using System.Collections.Generic;
using Rover;
using Xunit;

namespace RoverTests;

public class CommandParserTests
{
    private Dictionary<string, ICommand> _availableCommands;
    
    public  CommandParserTests()
    {
        _availableCommands = AvailableCommands.List;
    }
 
    [Fact]
    public void GetCorrectCommandToMove()
    {
        var commandParser = new CommandParser(_availableCommands);
        var command = commandParser.ParseCommand("M");
        Assert.IsType<MoveCommand>(command);
    }
    
    [Fact]
    public void GetCorrectCommandToTurnRight()
    {
        var commandParser = new CommandParser(_availableCommands);
        var command = commandParser.ParseCommand("R");
        Assert.IsType<RotateRightCommand>(command);
    }
    
    [Fact]
    public void GetCorrectCommandToTurnLeft()
    {
        var commandParser = new CommandParser(_availableCommands);
        var command = commandParser.ParseCommand("L");
        Assert.IsType<RotateLeftCommand>(command);
    }
    
    [Fact]
    public void GetNotFoundCommand()
    {
        var commandParser = new CommandParser(_availableCommands);
        var command = commandParser.ParseCommand("X");
        Assert.IsType<NotFoundCommand>(command);
    }
}