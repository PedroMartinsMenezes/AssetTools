namespace AssetTool
{
    [JsonAsset("PCGMetadataOperationSettings")]
    public class UPCGMetadataOperationSettings : UPCGSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}