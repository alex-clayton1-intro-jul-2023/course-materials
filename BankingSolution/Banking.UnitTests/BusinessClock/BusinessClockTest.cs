
using Banking.Domain;

namespace Banking.UnitTests.BusinessClock;

public class BusinessClockTest
{
    [Fact]
    public void WeAreClosedBeforeOpening()
    {

        // Given
        var stubbedClock = new Mock<ISystemTime>();
        stubbedClock.Setup(c => c.GetCurrent()).Returns(new DateTime(1969, 4, 20, 8, 59, 59));

        var clock = new RegularBusinessClock(stubbedClock.Object);

        // When / Then
        Assert.False(clock.IsDuringBusinessHours());
    
    }



    [Fact]
    public void WeAreOpenedAfterNine()
    {

        // Given
        var stubbedClock = new Mock<ISystemTime>();
        stubbedClock.Setup(c => c.GetCurrent()).Returns(new DateTime(1969, 4, 20, 9, 00, 00));

        var clock = new RegularBusinessClock(stubbedClock.Object);

        // When / Then
        Assert.True(clock.IsDuringBusinessHours());
    }

}
