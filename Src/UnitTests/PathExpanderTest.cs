using FluentAssertions;
using Melville.HeatForWix;

namespace UnitTests;

public class PathExpanderTest
{

    [Theory]
    [InlineData("a.dat", "C:\\b", "C:\\b\\a.dat")]
    [InlineData(".\\a.dat", "C:\\b", "C:\\b\\a.dat")]
    [InlineData("..\\a.dat", "C:\\b", "C:\\a.dat")]
    [InlineData("c\\d\\..\\..\\..\\a.dat", "C:\\b", "C:\\a.dat")]
    public void ExpandTest(string file, string path, string result)
    {
        PathExpander.Expand(file, path).Should().Be(result);
    }
}