namespace AssetTool
{
    [JsonAsset("PythonScriptPluginSettings")]
    public class UPythonScriptPluginSettings : UDeveloperSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PythonScriptPluginUserSettings")]
    public class UPythonScriptPluginUserSettings : UDeveloperSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}