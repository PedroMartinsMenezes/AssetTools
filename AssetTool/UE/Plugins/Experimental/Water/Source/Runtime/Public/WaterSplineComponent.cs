namespace AssetTool
{
    [JsonAsset("WaterSplineComponent")]
    public class UWaterSplineComponent : USplineComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}