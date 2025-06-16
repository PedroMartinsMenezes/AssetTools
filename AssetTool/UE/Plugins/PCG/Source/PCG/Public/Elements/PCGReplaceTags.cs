namespace AssetTool
{
    [JsonAsset("PCGReplaceTagsSettings")]
    public class UPCGReplaceTagsSettings : UPCGSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}