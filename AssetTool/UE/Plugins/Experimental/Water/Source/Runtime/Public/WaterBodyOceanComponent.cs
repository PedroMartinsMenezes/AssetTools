namespace AssetTool
{
    [JsonAsset("WaterBodyOceanComponent")]
    public class UWaterBodyOceanComponent : UWaterBodyComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}