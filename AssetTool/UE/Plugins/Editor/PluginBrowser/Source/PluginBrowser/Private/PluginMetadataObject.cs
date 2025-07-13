namespace AssetTool
{
    [JsonAsset("PluginMetadataObject")]
    public class UPluginMetadataObject : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}