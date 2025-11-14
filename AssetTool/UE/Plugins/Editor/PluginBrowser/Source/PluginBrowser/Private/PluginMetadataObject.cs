namespace AssetTool
{
    [JsonAsset("PluginMetadataObject")]
    public class UPluginMetadataObject : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}