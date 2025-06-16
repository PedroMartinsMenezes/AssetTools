namespace AssetTool
{
    [JsonAsset("PCGMergeSettings")]
    public class UPCGMergeSettings : UPCGSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}