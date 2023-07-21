
using Castle.Core.Logging;

namespace StringCalculatorKata;

public class StringCalculator
{

    private readonly IWebService _webService;
    private readonly ILogger _logger;

    public StringCalculator(ILogger logger, IWebService webService)
    {
        _logger = logger;
        _webService = webService;
    }


    public int Add(string numbers)
    {
        int result = 0;
        if (numbers != "") 
        {
            result = numbers.Split(',')
                .Select(int.Parse).Sum();
        }
        try
        {
            _logger.Log(result.ToString()); // nothing about what the string calculator and what it does will matter when add happens
        } catch (CalculatorLoggerException)
        {
            // Call the web service
            _webService.NotifyOfLoggerFailure("oh no failure");
        }


        return result;
    }
}

public interface IWebService
{
    void NotifyOfLoggerFailure(string message);
}



public class Logger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine(message);
    }
}
