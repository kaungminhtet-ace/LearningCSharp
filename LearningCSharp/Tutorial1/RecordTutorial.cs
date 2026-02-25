namespace LearningCSharp.Tutorial1;

public readonly record struct DailyTemperature(double HighTemperature, double LowTemperature)
{
    public double Mean => (HighTemperature + LowTemperature) / 2.0;
    public readonly double MMean = (HighTemperature + LowTemperature) / 2.0;
};

public abstract record DegreeDays(double BaseTemperature, IEnumerable<DailyTemperature> DailyTemperatures);

public sealed record HeatingDegreeDays(double BaseTemperature, IEnumerable<DailyTemperature> DailyTemperatures)
{
    public double DegreeDays =>
        DailyTemperatures.Where(s => s.Mean < BaseTemperature).Sum(s => BaseTemperature - s.Mean);
}

public sealed record CoolingDegreeDays(double BaseTemperature, IEnumerable<DailyTemperature> DailyTemperatures)
{
    public double DegreeDays =>
        DailyTemperatures.Where(s => s.Mean > BaseTemperature).Sum(s => s.Mean - BaseTemperature);
}

public class RecordTutorial
{
    private static DailyTemperature[] data = [
        new DailyTemperature(57, 30), 
        new DailyTemperature(60, 35),
        new DailyTemperature(63, 33),
        new DailyTemperature(68, 29),
        new DailyTemperature(72, 47),
        new DailyTemperature(75, 55),
        new DailyTemperature(77, 55),
        new DailyTemperature(72, 58),
        new DailyTemperature(70, 47),
        new DailyTemperature(77, 59),
        new DailyTemperature(85, 65),
        new DailyTemperature(87, 65),
        new DailyTemperature(85, 72),
        new DailyTemperature(83, 68),
        new DailyTemperature(77, 65),
        new DailyTemperature(72, 58),
        new DailyTemperature(77, 55),
        new DailyTemperature(76, 53),
        new DailyTemperature(80, 60),
        new DailyTemperature(85, 66) 
    ];
    public static void Test()
    {
        foreach (var dailyTemperature in data)
        {
            Console.WriteLine(dailyTemperature);
        }
    }
}