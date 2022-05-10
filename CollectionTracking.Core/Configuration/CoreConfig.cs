using System.Configuration;

namespace CollectionTracking.Core.Configuration
{
    public static class CoreConfig
    {
        public static string GetConnectionString(string key)
        {
            return ConfigurationManager.ConnectionStrings[key].ConnectionString;
        }

        public static string CollectionTracking => GetConnectionString("CollectionTracking");
    }
}
