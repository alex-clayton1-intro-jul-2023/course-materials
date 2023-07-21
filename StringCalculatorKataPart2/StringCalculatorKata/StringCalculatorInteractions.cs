
using Castle.Core.Logging;

namespace StringCalculatorKata;

public class StringCalculatorInteractions
{

    [Theory]
    [InlineData("15", "15")]
    [InlineData("1, 5", "6")]
    public void ResultsAreLogged(string numbers, string expectedToBeLogged)
    {
        // Given
        var loggerMock = new Mock<ILogger>();
        var mockedWebServices = new Mock<IWebService>();
        var calculator = new StringCalculator(loggerMock.Object, mockedWebServices.Object);

        // When
        calculator.Add(numbers);

        // Then
        // hey logger, did you get called with "15"?

        // since it doesn't return anything, it says pls make sure 
        // that this("15") gets written down.
        loggerMock.Verify(logger => logger.Log(expectedToBeLogged));
        mockedWebServices.Verify(ws => ws.NotifyOfLoggerFailure(It.IsAny<string>()), Times.Never);
        
    }



    [Fact]
    public void WebServiceIsCalledOnLoggerFailure()
    {
        var loggerStub = new Mock<ILogger>();
        var mockedWebService = new Mock<IWebService>();

        var calculator = new StringCalculator(loggerStub.Object, mockedWebService.Object);

        loggerStub.Setup(m => m.Log(It.IsAny<string>()))
            .Throws<CalculatorLoggerException>();

        // When
        calculator.Add("1");

        // Then// Times.Once is optional
        mockedWebService.Verify(m => m.NotifyOfLoggerFailure("oh no failure"), Times.Once);




    }
}
