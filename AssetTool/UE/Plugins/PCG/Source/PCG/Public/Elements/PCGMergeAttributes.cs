namespace AssetTool
{
    [JsonAsset("PCGMergeAttributesSettings")]
    public class UPCGMergeAttributesSettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}