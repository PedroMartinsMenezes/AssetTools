namespace AssetTool
{
    [JsonAsset("RendererSettings")]
    public class URendererSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("RendererOverrideSettings")]
    public class URendererOverrideSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}