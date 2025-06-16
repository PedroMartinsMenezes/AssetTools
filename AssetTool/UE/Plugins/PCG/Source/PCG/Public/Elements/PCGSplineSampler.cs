namespace AssetTool
{
    [JsonAsset("PCGSplineSamplerSettings")]
    public class UPCGSplineSamplerSettings : UPCGSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}