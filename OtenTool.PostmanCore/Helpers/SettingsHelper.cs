using Newtonsoft.Json;
using OtenTool.PostmanCore.Items;

namespace OtenTool.PostmanCore.Helpers
{
    public class SettingsHelper
    {
        private static SettingsItem settingsItem;

        // GetSettings - Settings Getirir
        public static SettingsItem GetSettings(bool isRefresh = false)
        {
            if (settingsItem == null || isRefresh)
            {
                var jsonSettings = File.ReadAllText("appsettings.json");
                settingsItem = JsonConvert.DeserializeObject<SettingsItem>(jsonSettings);
            }

            settingsItem = settingsItem ?? new SettingsItem();

            return settingsItem;
        }
    }
}
