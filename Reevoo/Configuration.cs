using System.Configuration;

namespace Reevoo
{
    public class Configuration
    {
        public readonly string Key;
        public readonly string Secret;
        public readonly string BaseUri;

        public Configuration()
        {
            Key = ConfigurationManager.AppSettings["Key"];
            Secret = ConfigurationManager.AppSettings["Secret"];
            BaseUri = ConfigurationManager.AppSettings["BaseAddress"];
        }
    }
}
