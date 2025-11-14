namespace AssetTool
{
    [JsonAsset("RenderDocPluginSettings")]
    public class URenderDocPluginSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}