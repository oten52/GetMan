namespace OtenTool.PostmanCore.Items
{
    public class SettingsItem
    {
        public ConnectionSettingsItem ConnectionStrings { get; set; } = new ConnectionSettingsItem();

    }

    public class ConnectionSettingsItem
    {
        public string? DefaultConStr { get; set; }
    }

}
