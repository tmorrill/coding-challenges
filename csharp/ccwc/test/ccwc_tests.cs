using ccwc;
using Xunit;

namespace test;

public class ccwc_tests
{
    [Fact]
    public void count_bytes_should_return_byte_length_of_file()
    {
        var expected = 342192;
        using var stream = File.OpenRead("./test.txt");
        var sut = new Counter();
        var actual = sut.CountBytes(stream);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void count_lines_should_return_total_lines_in_file()
    {
        var expected = 7146;
        using var stream = File.OpenRead("./test.txt");
        var sut = new Counter();
        var actual = sut.CountLines(stream);
        Assert.Equal(expected, actual);
    }
}