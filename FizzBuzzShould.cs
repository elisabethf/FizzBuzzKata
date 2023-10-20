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

        [Fact]
        public void ReturnFizz_ForNumbersDivisibleBy_Three()
        {
            // Arrange
            FizzBuzzService service = new FizzBuzzService();

            // Act
            string result = service.Print(3);

            // Assert
            result.Should().Be("fizz");
        }

        [Fact]
        public void ReturnBuzz_ForNumbersDivisibleBy_Five()
        {
            // Arrange
            FizzBuzzService service = new FizzBuzzService();

            // Act
            string result = service.Print(5);

            // Assert
            result.Should().Be("buzz");
        }

        [Fact]
        public void ReturnFizzBuzz_ForNumbersDivisibleBy_Three_And_Five()
        {
            // Arrange
            FizzBuzzService service = new FizzBuzzService();

            // Act
            string result = service.Print(15);

            // Assert
            result.Should().Be("fizzbuzz");
        }
    }
}
