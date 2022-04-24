using Xunit;

public class ClockTests
{
    [Fact]
    public void On_the_hour()
    {
        Clock sut = new Clock(8, 0);
        Assert.Equal("08:00", sut.ToString());
    }

    [Fact]
    public void Past_the_hour()
    {
        Clock sut = new Clock(11, 9);
        Assert.Equal("11:09", sut.ToString());
    }

    [Fact]
    public void Midnight_is_zero_hours()
    {
        Clock sut = new Clock(24, 0);
        Assert.Equal("00:00", sut.ToString());
    }

    [Fact]
    public void Hour_rolls_over()
    {
        Clock sut = new Clock(25, 0);
        Assert.Equal("01:00", sut.ToString());
    }

    [Fact]
    public void Hour_rolls_over_continuously()
    {
        Clock sut = new Clock(100, 0);
        Assert.Equal("04:00", sut.ToString());
    }

    [Fact]
    public void Sixty_minutes_is_next_hour()
    {
        Clock sut = new Clock(1, 60);
        Assert.Equal("02:00", sut.ToString());
    }

    [Fact]
    public void Minutes_roll_over()
    {
        Clock sut = new Clock(0, 160);
        Assert.Equal("02:40", sut.ToString());
    }

    [Fact]
    public void Minutes_roll_over_continuously()
    {
        Clock sut = new Clock(0, 1723);
        Assert.Equal("04:43", sut.ToString());
    }

    [Fact]
    public void Hour_and_minutes_roll_over()
    {
        Clock sut = new Clock(25, 160);
        Assert.Equal("03:40", sut.ToString());
    }

    [Fact]
    public void Hour_and_minutes_roll_over_continuously()
    {
        Clock sut = new Clock(201, 3001);
        Assert.Equal("11:01", sut.ToString());
    }

    [Fact]
    public void Hour_and_minutes_roll_over_to_exactly_midnight()
    {
        Clock sut = new Clock(72, 8640);
        Assert.Equal("00:00", sut.ToString());
    }

    [Fact]
    public void Negative_hour()
    {
        Clock sut = new Clock(-1, 15);
        Assert.Equal("23:15", sut.ToString());
    }

    [Fact]
    public void Negative_hour_rolls_over()
    {
        Clock sut = new Clock(-25, 0);
        Assert.Equal("23:00", sut.ToString());
    }

    [Fact]
    public void Negative_hour_rolls_over_continuously()
    {
        Clock sut = new Clock(-91, 0);
        Assert.Equal("05:00", sut.ToString());
    }

    [Fact]
    public void Negative_minutes()
    {
        Clock sut = new Clock(1, -40);
        Assert.Equal("00:20", sut.ToString());
    }

    [Fact]
    public void Negative_minutes_roll_over()
    {
        Clock sut = new Clock(1, -160);
        Assert.Equal("22:20", sut.ToString());
    }

    [Fact]
    public void Negative_minutes_roll_over_continuously()
    {
        Clock sut = new Clock(1, -4820);
        Assert.Equal("16:40", sut.ToString());
    }

    [Fact]
    public void Negative_sixty_minutes_is_previous_hour()
    {
        Clock sut = new Clock(2, -60);
        Assert.Equal("01:00", sut.ToString());
    }

    [Fact]
    public void Negative_hour_and_minutes_both_roll_over()
    {
        Clock sut = new Clock(-25, -160);
        Assert.Equal("20:20", sut.ToString());
    }

    [Fact]
    public void Negative_hour_and_minutes_both_roll_over_continuously()
    {
        Clock sut = new Clock(-121, -5810);
        Assert.Equal("22:10", sut.ToString());
    }

    [Fact]
    public void Add_minutes()
    {
        Clock sut = new Clock(10, 0);
        Assert.Equal("10:03", sut.Add(3).ToString());
    }

    [Fact]
    public void Add_no_minutes()
    {
        Clock sut = new Clock(6, 41);
        Assert.Equal("06:41", sut.Add(0).ToString());
    }

    [Fact]
    public void Add_to_next_hour()
    {
        Clock sut = new Clock(0, 45);
        Assert.Equal("01:25", sut.Add(40).ToString());
    }

    [Fact]
    public void Add_more_than_one_hour()
    {
        Clock sut = new Clock(10, 0);
        Assert.Equal("11:01", sut.Add(61).ToString());
    }

    [Fact]
    public void Add_more_than_two_hours_with_carry()
    {
        Clock sut = new Clock(0, 45);
        Assert.Equal("03:25", sut.Add(160).ToString());
    }

    [Fact]
    public void Add_across_midnight()
    {
        Clock sut = new Clock(23, 59);
        Assert.Equal("00:01", sut.Add(2).ToString());
    }

    [Fact]
    public void Add_more_than_one_day_1500_min_25_hrs_()
    {
        Clock sut = new Clock(5, 32);
        Assert.Equal("06:32", sut.Add(1500).ToString());
    }

    [Fact]
    public void Add_more_than_two_days()
    {
        Clock sut = new Clock(1, 1);
        Assert.Equal("11:21", sut.Add(3500).ToString());
    }

    [Fact]
    public void Subtract_minutes()
    {
        Clock sut = new Clock(10, 3);
        Assert.Equal("10:00", sut.Subtract(3).ToString());
    }

    [Fact]
    public void Subtract_to_previous_hour()
    {
        Clock sut = new Clock(10, 3);
        Assert.Equal("09:33", sut.Subtract(30).ToString());
    }

    [Fact]
    public void Subtract_more_than_an_hour()
    {
        Clock sut = new Clock(10, 3);
        Assert.Equal("08:53", sut.Subtract(70).ToString());
    }

    [Fact]
    public void Subtract_across_midnight()
    {
        Clock sut = new Clock(0, 3);
        Assert.Equal("23:59", sut.Subtract(4).ToString());
    }

    [Fact]
    public void Subtract_more_than_two_hours()
    {
        Clock sut = new Clock(0, 0);
        Assert.Equal("21:20", sut.Subtract(160).ToString());
    }

    [Fact]
    public void Subtract_more_than_two_hours_with_borrow()
    {
        Clock sut = new Clock(6, 15);
        Assert.Equal("03:35", sut.Subtract(160).ToString());
    }

    [Fact]
    public void Subtract_more_than_one_day_1500_min_25_hrs_()
    {
        Clock sut = new Clock(5, 32);
        Assert.Equal("04:32", sut.Subtract(1500).ToString());
    }

    [Fact]
    public void Subtract_more_than_two_days()
    {
        Clock sut = new Clock(2, 20);
        Assert.Equal("00:20", sut.Subtract(3000).ToString());
    }

    [Fact]
    public void Clocks_with_same_time()
    {
        Clock sut = new Clock(15, 37);
        Assert.Equal(new Clock(15, 37), sut);
    }

    [Fact]
    public void Clocks_a_minute_apart()
    {
        Clock sut = new Clock(15, 37);
        Assert.NotEqual(new Clock(15, 36), sut);
    }

    [Fact]
    public void Clocks_an_hour_apart()
    {
        Clock sut = new Clock(15, 37);
        Assert.NotEqual(new Clock(14, 37), sut);
    }

    [Fact]
    public void Clocks_with_hour_overflow()
    {
        Clock sut = new Clock(34, 37);
        Assert.Equal(new Clock(10, 37), sut);
    }

    [Fact]
    public void Clocks_with_hour_overflow_by_several_days()
    {
        Clock sut = new Clock(99, 11);
        Assert.Equal(new Clock(3, 11), sut);
    }

    [Fact]
    public void Clocks_with_negative_hour()
    {
        Clock sut = new Clock(-2, 40);
        Assert.Equal(new Clock(22, 40), sut);
    }

    [Fact]
    public void Clocks_with_negative_hour_that_wraps()
    {
        Clock sut = new Clock(-31, 3);
        Assert.Equal(new Clock(17, 3), sut);
    }

    [Fact]
    public void Clocks_with_negative_hour_that_wraps_multiple_times()
    {
        Clock sut = new Clock(-83, 49);
        Assert.Equal(new Clock(13, 49), sut);
    }

    [Fact]
    public void Clocks_with_minute_overflow()
    {
        Clock sut = new Clock(0, 1441);
        Assert.Equal(new Clock(0, 1), sut);
    }

    [Fact]
    public void Clocks_with_minute_overflow_by_several_days()
    {
        Clock sut = new Clock(2, 4322);
        Assert.Equal(new Clock(2, 2), sut);
    }

    [Fact]
    public void Clocks_with_negative_minute()
    {
        Clock sut = new Clock(3, -20);
        Assert.Equal(new Clock(2, 40), sut);
    }

    [Fact]
    public void Clocks_with_negative_minute_that_wraps()
    {
        Clock sut = new Clock(5, -1490);
        Assert.Equal(new Clock(4, 10), sut);
    }

    [Fact]
    public void Clocks_with_negative_minute_that_wraps_multiple_times()
    {
        Clock sut = new Clock(6, -4305);
        Assert.Equal(new Clock(6, 15), sut);
    }

    [Fact]
    public void Clocks_with_negative_hours_and_minutes()
    {
        Clock sut = new Clock(-12, -268);
        Assert.Equal(new Clock(7, 32), sut);
    }

    [Fact]
    public void Clocks_with_negative_hours_and_minutes_that_wrap()
    {
        Clock sut = new Clock(-54, -11513);
        Assert.Equal(new Clock(18, 7), sut);
    }

    [Fact]
    public void Full_clock_and_zeroed_clock()
    {
        Clock sut = new Clock(0, 0);
        Assert.Equal(new Clock(24, 0), sut);
    }

    [Fact]
    public void Clocks_are_immutable()
    {
        Clock sut = new Clock(0, 0);
        Clock sutPlus1 = sut.Add(1);
        Assert.NotEqual(sutPlus1, sut);
    }
}