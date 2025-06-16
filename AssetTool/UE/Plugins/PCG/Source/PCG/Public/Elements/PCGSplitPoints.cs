namespace AssetTool
{
    [JsonAsset("PCGSplitPointsSettings")]
    public class UPCGSplitPointsSettings : UPCGSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}