namespace AssetTool
{
    [JsonAsset("PCGReplaceTagsSettings")]
    public class UPCGReplaceTagsSettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}