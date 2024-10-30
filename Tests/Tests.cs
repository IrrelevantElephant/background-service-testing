using Microsoft.AspNetCore.Mvc.Testing;
using System.Net;

namespace Tests;

public class Tests : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly WebApplicationFactory<Program> _factory;

    public Tests()
    {
        _factory = new WebApplicationFactory<Program>();
    }

    [Fact]
    public async Task Test1()
    {
        var client = _factory.CreateClient();

        var response = await client.GetAsync("/weatherforecast");

        Assert.NotNull(response);

        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
    }
}