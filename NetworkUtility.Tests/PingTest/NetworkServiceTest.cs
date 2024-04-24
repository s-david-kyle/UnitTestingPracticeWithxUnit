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
    }
}
