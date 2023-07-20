namespace CSharpSyntax
{
    public class UnitTest1
    {
        // When I run test, it looks for all public classes in thing and will run whatever has a [FACT] on it.
        [Fact] // Attribute in .NET. If it was Angular, it would be like @Component
        public void CanAddTwoNumbers()
        {
            // Given
            int a = 10; int b = 20; int ans = 30;

            // When
            int answer = a + b; // System Under Test
            
            // Then
            Assert.Equal(ans, answer); // First one is the expected answer
        }

        [Theory] // One test with multiple inputs
        [InlineData(10, 20, 30)]
        [InlineData(2, 8, 10)]
        [InlineData(2, 2, 4)]
        public void CanAddAnyTwoIntegers(int a, int b, int expected)
        {
            int answer = a + b;
            Assert.Equal(expected, answer);
        }


        [Theory]
        [InlineData("Jeff", "Gonzalez", "Gonzalez, Jeff")]
        [InlineData("Han", "Solo", "Solo, Han")]
        [InlineData("Luke", "Skywalker", "Skywalker, Luke")]
        [InlineData(" Leia", "   Organa", "Organa, Leia")]
        public void FormattingMyName(string first, string last, string expected)
        {
            string fullName = Utils.FormatName(first, last);
            Assert.Equal(expected, fullName);
        }

    }
}