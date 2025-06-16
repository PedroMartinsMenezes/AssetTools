namespace AssetTool
{
    [JsonAsset("PCGNativeSettingsClassTemplate")]
    public class UPCGNativeSettingsClassTemplate : UPluginClassTemplate
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGNativeNodeClassTemplate")]
    public class UPCGNativeNodeClassTemplate : UPluginClassTemplate
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}