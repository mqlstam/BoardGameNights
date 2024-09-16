using System.Net.Http;
using System.Threading.Tasks;
using BoardgameNight.Web;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace BoardgameNight.IntegrationTests
{
    public class BoardgameNightsControllerTests : IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly WebApplicationFactory<Startup> _factory;

        public BoardgameNightsControllerTests(WebApplicationFactory<Startup> factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task Get_EndpointsReturnSuccessAndCorrectContentType()
        {
            // Arrange
            var client = _factory.CreateClient();

            // Act
            var response = await client.GetAsync("/api/BoardgameNightsApi");

            // Assert
            response.EnsureSuccessStatusCode();
            Assert.Equal("application/json; charset=utf-8", 
                response.Content.Headers.ContentType.ToString());
        }
    }
}