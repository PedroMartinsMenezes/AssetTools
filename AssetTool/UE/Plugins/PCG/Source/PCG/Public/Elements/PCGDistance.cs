namespace AssetTool
{
    [JsonAsset("PCGDistanceSettings")]
    public class UPCGDistanceSettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}