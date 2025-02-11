namespace ccwc;

public class Counter : ICounter
{
    public double CountBytes(Stream input)
    {
        return input.Length;
    }
    
    public double CountLines(Stream input)
    {
        var count = 0;
        using var reader = new StreamReader(input);
        while (!reader.EndOfStream)
        {
            var line = reader.ReadLine();
            count++;
        }

        return count;
    }
}

public interface ICounter
{
    double CountBytes(Stream input);

    double CountLines(Stream input);
}