namespace AssetTool
{
    [JsonAsset("PCGWaterSplineData")]
    public class UPCGWaterSplineData : UPCGSplineData
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}