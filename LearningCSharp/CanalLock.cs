namespace LearningCSharp;

/*
 *
 */

public enum WaterLevel
{
    Low,
    High,
}

public class CanalLock
{
    public WaterLevel WaterLevel { get; private set; } = WaterLevel.Low;
    public bool HighWaterGateOpen { get; private set; } = false;
    public bool LowWaterGateOpen { get; private set; } = false;

    public void SetHighGate(bool open)
    {
        HighWaterGateOpen = open;
    }

    public void SetLowGate(bool open)
    {
        LowWaterGateOpen = open;
    }

    public void SetWaterLevel(WaterLevel waterLevel)
    {
        WaterLevel = waterLevel;
    }

    public override string ToString() =>
        $"The lower gate is {(LowWaterGateOpen ? "Open" : "Closed")}. " +
        $"The upper gate is {(HighWaterGateOpen ? "Open" : "Closed")}. " +
        $"The water level is {WaterLevel}.";
}