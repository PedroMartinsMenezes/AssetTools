namespace AssetTool
{
    [JsonAsset("SlateRHIRendererSettings")]
    public class USlateRHIRendererSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}