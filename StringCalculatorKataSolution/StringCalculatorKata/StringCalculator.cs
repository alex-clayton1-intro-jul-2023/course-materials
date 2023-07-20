
using Xunit.Sdk;

namespace StringCalculatorKata;

public class StringCalculator
{
    public int Add(string numbers)
    {
        if (numbers == "")
        {
            return 0;
        }
        return numbers.Split(',') // [ "1", "2", "3", "4"]
        .Select(int.Parse) // [ 1, 2, 3, 4]
        .Sum(); // Sum them up!

        //var whereTheCommaIs = numbers.IndexOf(',');
        // var lhs = int.Parse(numbers.Substring(0, whereTheCommaIs));
        //var rhs = int.Parse(numbers.Substring(whereTheCommaIs + 1));
        //return lhs+rhs; // new bs

        var stringDigits = numbers.Split(',');
            /*
            int sum = 0;
            for (var i = 0; i < stringDigits.Length; i++)
            {
                sum += int.Parse(stringDigits[i]);
            }

            */
            /*
            int sum = 0;
            foreach(var number in stringDigits)
            {
                sum += int.Parse(number);
            }
            */



           

        

    }
}
