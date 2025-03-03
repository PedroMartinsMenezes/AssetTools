namespace AssetTool
{
    [JsonAsset("PCGMetadata")]
    public class UPCGMetadata : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}