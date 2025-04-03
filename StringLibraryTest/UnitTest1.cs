using Xunit;
using StringLibrary;

namespace StringLibraryTest;

public class UnitTest1
{
    [Theory]
    [InlineData("Abc")]
    [InlineData("Zebra")]
    [InlineData("XUnit")]
    public void StartsWithUpper_ValidUppercase_ReturnsTrue(string input)
    {
        bool result = Utilities.StartsWithUpper(input);
        Assert.True(result);
    }

    [Theory]
    [InlineData("abc")]
    [InlineData("zebra")]
    [InlineData("xunit")]
    public void StartsWithUpper_Lowercase_ReturnsFalse(string input)
    {
        bool result = Utilities.StartsWithUpper(input);
        Assert.False(result);
    }

    [Theory]
    [InlineData("")]
    [InlineData(null)]
    public void StartsWithUpper_EmptyOrNull_ReturnsFalse(string? input)
    {
        bool result = Utilities.StartsWithUpper(input);
        Assert.False(result);
    }
}
