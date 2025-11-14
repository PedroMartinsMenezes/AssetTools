namespace AssetTool
{
    [JsonAsset("PCGWaterSplineData")]
    public class UPCGWaterSplineData : UPCGSplineData
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}