using Aquality.Selenium.Core.Utilities;

namespace UserInterfaceMatskevichM.Utilities.FileUtilities
{
    public static class TestData
    {
        private static JsonSettingsFile testData = new("testData.json");
        public static string PageIndicator = testData.GetValue<string>("pageIndicator");
    }
}

