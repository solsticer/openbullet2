using RuriLib.Models.Settings;
using RuriLib.Services;

namespace RuriLib.Providers.Selenium
{
    public class DefaultSeleniumBrowserProvider : ISeleniumBrowserProvider
    {
        public string ChromeBinaryLocation { get; }
        public string EdgeBinaryLocation { get; }
        public string FirefoxBinaryLocation { get; }
        public SeleniumBrowserType BrowserType { get; }

        public DefaultSeleniumBrowserProvider(RuriLibSettingsService settings)
        {
            ChromeBinaryLocation = settings.RuriLibSettings.SeleniumSettings.ChromeBinaryLocation;
            EdgeBinaryLocation = settings.RuriLibSettings.SeleniumSettings.EdgeBinaryLocation;
            FirefoxBinaryLocation = settings.RuriLibSettings.SeleniumSettings.FirefoxBinaryLocation;
            BrowserType = settings.RuriLibSettings.SeleniumSettings.BrowserType;
        }
    }
}
