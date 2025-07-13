namespace AssetTool
{
    [JsonAsset("WaterBodyCustomComponent")]
    public class UWaterBodyCustomComponent : UWaterBodyComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}