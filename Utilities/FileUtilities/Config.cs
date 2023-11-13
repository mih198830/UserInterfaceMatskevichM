using Aquality.Selenium.Core.Utilities;

namespace UserInterfaceMatskevichM.Utilities.FileUtilities
{
    internal class Config
    {
        private static JsonSettingsFile config = new("config.json");

        public static string startPageLink = config.GetValue<string>("startPageLink");
    }
}
