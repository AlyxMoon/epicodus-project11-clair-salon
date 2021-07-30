using Microsoft.Extensions.Configuration;

namespace HairSalon.Tests
{
  public class Startup
  {
    public static IConfiguration InitConfiguration()
    {
      IConfigurationRoot config = new ConfigurationBuilder()
        .AddJsonFile("appsettings.json")
        .Build();
      return config;
    }
  }
}