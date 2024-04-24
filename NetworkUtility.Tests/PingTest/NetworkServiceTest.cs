using FluentAssertions;
using NetworkUtility.Ping;

namespace NetworkUtility.Tests.PingTest
{

    public class NetworkServiceTest
    {
        [Fact]
        public void NetworkService_SendPing_ReturnString()
        {
            // Arrange
            var networkService = new NetworkService();

            // Act
            var result = networkService.SendPing();

            // Assert
            Assert.Equal("Success: Ping sent", result);
            result.Should().Be("Success: Ping sent");
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(2, 3, 5)]
        public void NetworkService_PingTimeout_ReturnSum(int a, int b, int expected)
        {
            // Arrange
            var networkService = new NetworkService();

            // Act
            var result = networkService.PingTimeout(a, b);

            // Assert
            Assert.Equal(expected, result);
            result.Should().Be(expected);
        }

    }
}
