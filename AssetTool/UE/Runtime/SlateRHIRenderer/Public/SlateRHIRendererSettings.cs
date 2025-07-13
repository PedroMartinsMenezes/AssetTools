namespace AssetTool
{
    [JsonAsset("SlateRHIRendererSettings")]
    public class USlateRHIRendererSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}