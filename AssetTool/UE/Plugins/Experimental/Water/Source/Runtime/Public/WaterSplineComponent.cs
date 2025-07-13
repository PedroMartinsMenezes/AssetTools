namespace AssetTool
{
    [JsonAsset("WaterSplineComponent")]
    public class UWaterSplineComponent : USplineComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}