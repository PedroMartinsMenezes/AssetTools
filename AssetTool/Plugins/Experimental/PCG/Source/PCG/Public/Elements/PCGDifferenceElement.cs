namespace AssetTool
{
    [JsonAsset("PCGDifferenceSettings")]
    public class UPCGDifferenceSettings : UPCGSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}