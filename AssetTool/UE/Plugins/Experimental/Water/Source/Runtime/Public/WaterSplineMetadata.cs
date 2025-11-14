namespace AssetTool
{
    [JsonAsset("WaterSplineMetadata")]
    public class UWaterSplineMetadata : USplineMetadata
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}