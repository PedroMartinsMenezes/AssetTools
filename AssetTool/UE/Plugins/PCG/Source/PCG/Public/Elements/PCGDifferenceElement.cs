namespace AssetTool
{
    [JsonAsset("PCGDifferenceSettings")]
    public class UPCGDifferenceSettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}