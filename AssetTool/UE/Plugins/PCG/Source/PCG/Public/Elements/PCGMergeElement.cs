namespace AssetTool
{
    [JsonAsset("PCGMergeSettings")]
    public class UPCGMergeSettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}