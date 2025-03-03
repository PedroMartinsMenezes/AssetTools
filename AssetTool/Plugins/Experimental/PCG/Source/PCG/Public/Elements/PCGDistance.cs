namespace AssetTool
{
    [JsonAsset("PCGDistanceSettings")]
    public class UPCGDistanceSettings : UPCGSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}