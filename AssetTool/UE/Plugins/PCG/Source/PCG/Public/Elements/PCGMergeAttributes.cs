namespace AssetTool
{
    [JsonAsset("PCGMergeAttributesSettings")]
    public class UPCGMergeAttributesSettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}