namespace AssetTool
{
    [JsonAsset("PCGReplaceTagsSettings")]
    public class UPCGReplaceTagsSettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}