namespace AssetTool
{
    [JsonAsset("PCGSortTagsSettings")]
    public class UPCGSortTagsSettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}