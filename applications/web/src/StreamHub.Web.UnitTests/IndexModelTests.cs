using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using StreamHub.Web.Pages;

namespace StreamHub.Web.UnitTests;

public class IndexModelTests
{
    [Fact]
    public void OnPostAsync_ShouldReturnRedirctToPageResult()
    {
        // Arrange
        var mockLogger = new Mock<ILogger<IndexModel>>();
        var sut = new IndexModel(mockLogger.Object);

        // Act
        var result = sut.OnPostAsync();

        // Assert
        Assert.IsType<RedirectToPageResult>(result);
    }
}