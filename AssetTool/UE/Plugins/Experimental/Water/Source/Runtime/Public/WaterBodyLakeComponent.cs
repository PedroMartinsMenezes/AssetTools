namespace AssetTool
{
    [JsonAsset("WaterBodyLakeComponent")]
    public class UWaterBodyLakeComponent : UWaterBodyComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}