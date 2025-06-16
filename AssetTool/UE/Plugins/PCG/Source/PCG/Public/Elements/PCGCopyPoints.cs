namespace AssetTool
{
    [JsonAsset("PCGCopyPointsSettings")]
    public class UPCGCopyPointsSettings : UPCGSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}