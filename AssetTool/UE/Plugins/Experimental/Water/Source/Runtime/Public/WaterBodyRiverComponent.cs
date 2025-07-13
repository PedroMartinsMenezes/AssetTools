namespace AssetTool
{
    [JsonAsset("WaterBodyRiverComponent")]
    public class UWaterBodyRiverComponent : UWaterBodyComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}