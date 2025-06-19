namespace AssetTool
{
    [JsonAsset("PCGSplineSamplerSettings")]
    public class UPCGSplineSamplerSettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}