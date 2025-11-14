namespace AssetTool
{
    [JsonAsset("PCGSortTagsSettings")]
    public class UPCGSortTagsSettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}