using System.Configuration;

namespace ReevooTests.Api
{
    public class TestConfiguration
    {
        public readonly string Trkref;
        public readonly string Key;
        public readonly string Secret;
        public readonly string BaseUri;

        public TestConfiguration()
        {
            Trkref = ConfigurationManager.AppSettings["Trkref"];
            Key = ConfigurationManager.AppSettings["Key"];
            Secret = ConfigurationManager.AppSettings["Secret"];
            BaseUri = ConfigurationManager.AppSettings["BaseAddress"];
        }
    }
}
