namespace AssetTool
{
    [JsonAsset("WaterSplineMetadata")]
    public class UWaterSplineMetadata : USplineMetadata
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}