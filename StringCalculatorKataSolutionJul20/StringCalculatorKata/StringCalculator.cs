
using System.Numerics;

namespace StringCalculatorKata;

public class StringCalculator
{
    public int Add(string numbers)
    {
        if (numbers == "") { return 0; }
        var numbs = numbers.Split(',');
        int sum = 0;
        for ( var i = 0; i < numbs.Length; i++ )
        {
            sum += int.Parse(numbs[i]);
        }
        return sum;
       // return int.Parse(numbers); // sliming, (having it return something)
    }
}
