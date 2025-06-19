namespace AssetTool
{
    [JsonAsset("PCGMetadataRenameSettings")]
    public class UPCGMetadataRenameSettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}