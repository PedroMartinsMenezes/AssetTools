namespace AssetTool
{
    [JsonAsset("WaterBodyOceanComponent")]
    public class UWaterBodyOceanComponent : UWaterBodyComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}