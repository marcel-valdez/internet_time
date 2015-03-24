using System;
using InternetTime;
using NUnit.Framework;

namespace InternetTimeTest
{
  [TestFixture]
  public class SNTPClientTest
  {
    [Test]
    public void TestConnect()
    {
      // Arrange
      SNTPClient client = new SNTPClient("time.nist.gov");
      // Act 
      client.Connect(false);
      // Assert
      DateTime now = DateTime.Now;
      DateTime serverTime = client.InternetTime;
      Assert.That(serverTime, Is.LessThan(now.AddSeconds(5)));
      Assert.That(serverTime, Is.GreaterThan(now.AddSeconds(-5)));
    }
  }
}
