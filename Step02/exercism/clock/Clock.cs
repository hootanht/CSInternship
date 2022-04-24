using System;
public class Clock : IEquatable<Clock>
{
    private readonly int _hour;
    private readonly int _minute;
    public Clock(int hours, int minutes)
    {
        int totalMinutes = (hours * 60) + minutes;
        while (totalMinutes < 0)
            totalMinutes += 1440;
        int remainedHours = totalMinutes / 60;
        _minute = totalMinutes % 60;
        _hour = remainedHours % 24;
    }
    public override string ToString()
    {
        string MyClock = "";
        if (_hour < 10)
            MyClock = $"0{_hour}:";
        else
            MyClock = $"{_hour}:";
        if (_minute < 10)
            MyClock += $"0{_minute}";
        else
            MyClock += $"{_minute}";
        return MyClock;
    }
    public Clock Add(int minutesToAdd) => new Clock(_hour, _minute + minutesToAdd);
    public Clock Subtract(int minutesToSubtract) => new Clock(_hour, _minute - minutesToSubtract);
    public bool Equals(Clock other) => other._hour == _hour &&
            other._minute == _minute;
}