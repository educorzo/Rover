using Rover;
using Xunit;


namespace RoverTests;

public class RoverShould
{
    [Theory]
    [InlineData("L","0:0:W")]
    [InlineData("LL","0:0:S")]
    [InlineData("LLL","0:0:E")]
    [InlineData("LLLL","0:0:N")]
    public void RotateLeft(string command, string result)
    {
        var rover = new RoverVehicle();

        var status = rover.Execute(command);

        Assert.Equal(result, status);
    }

    [Theory]
    [InlineData("R","0:0:E")]
    [InlineData("RR","0:0:S")]
    [InlineData("RRR","0:0:W")]
    [InlineData("RRRR","0:0:N")]
    public void RotateRight(string command, string result)
    {
        var rover = new RoverVehicle();

        var status = rover.Execute(command);

        Assert.Equal(result, status);
    }

    [Theory]
    [InlineData("M","0:1:N")]
    [InlineData("LM","-1:0:W")]
    [InlineData("LLM","0:-1:S")]
    [InlineData("RM","1:0:E")]
    [InlineData("RMLMLMRMMLMR","-1:3:N")]
    public void Moves(string command, string result)
    {
        var rover = new RoverVehicle();

        var status = rover.Execute(command);

        Assert.Equal(result, status);
    }
}