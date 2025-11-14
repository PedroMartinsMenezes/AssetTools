namespace AssetTool
{
    [JsonAsset("PCGDeleteTagsSettings")]
    public class UPCGDeleteTagsSettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}