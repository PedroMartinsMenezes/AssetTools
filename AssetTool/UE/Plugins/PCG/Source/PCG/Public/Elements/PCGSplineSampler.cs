namespace AssetTool
{
    [JsonAsset("PCGSplineSamplerSettings")]
    public class UPCGSplineSamplerSettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}