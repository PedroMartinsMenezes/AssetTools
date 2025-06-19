namespace AssetTool
{
    [JsonAsset("PCGSplitPointsSettings")]
    public class UPCGSplitPointsSettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}