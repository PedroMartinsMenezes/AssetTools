namespace AssetTool
{
    [JsonAsset("DirectLinkExtensionSettings")]
    public class UDirectLinkExtensionSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}