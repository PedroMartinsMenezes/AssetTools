namespace AssetTool
{
    [JsonAsset("PCGMetadataRenameSettings")]
    public class UPCGMetadataRenameSettings : UPCGSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}