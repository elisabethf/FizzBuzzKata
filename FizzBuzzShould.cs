using FluentAssertions;
using Xunit;

namespace FizzBuzzKata
{
    public class FizzBuzzShould
    {
        [Fact]
        public void ReturnNumber()
        {
            // Arrange
            FizzBuzzService service = new FizzBuzzService();

            // Act
            string result = service.Print(1);

            // Assert
            result.Should().Be("1");
        }
    }
}
