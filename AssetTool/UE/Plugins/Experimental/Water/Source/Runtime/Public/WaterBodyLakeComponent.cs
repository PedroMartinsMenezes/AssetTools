namespace AssetTool
{
    [JsonAsset("WaterBodyLakeComponent")]
    public class UWaterBodyLakeComponent : UWaterBodyComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}