
namespace HexCheckerTest;
using HexChecker;

public class UnitTest1
{
    private HexChecker checker = new HexChecker();
    [Fact]
    public void ValidateHex_ShouldReturnTrue_WhenInputIsValid()    
    {
        // Arrange
        string input = "#CD5C5C";

        // Act
        bool result = checker.ValidateHex(input);

        // Assert
        Assert.True(result);
    }


    [Fact]
    public void ValidateHex_ShouldReturnFalse_WhenInputIsNotValid()    
    {
        // Arrange
        string input = "ku)@";

        // Act
        bool result = checker.ValidateHex(input);

        // Assert
        Assert.False(result);

    }
}