using LearningCSharp.Tutorial1;
using LearningCSharp.Tutorial1.CommercialRegistration;
using LearningCSharp.Tutorial1.ConsumerVehicleRegistration;
using LearningCSharp.Tutorial1.LiveryRegistration;

var totalCalc = new TollCalculator();

Car c = new();
Taxi t = new();
DeliveryTrack dt = new();
Bus bus = new();

Console.WriteLine($"The toll for a car is {totalCalc.Calculate(c)}");
Console.WriteLine($"The toll for a taxi is {totalCalc.Calculate(t)}");
Console.WriteLine($"The toll for a bus is {totalCalc.Calculate(bus)}");
Console.WriteLine($"The toll for a truck is {totalCalc.Calculate(dt)}");

try
{
    totalCalc.Calculate("this will fail");
}
catch (ArgumentException e)
{
    Console.WriteLine("Caught an argument exception when using the wrong type");
}
try
{
    totalCalc.Calculate(null!);
}
catch (ArgumentNullException e)
{
    Console.WriteLine("Caught an argument exception when using null");
}