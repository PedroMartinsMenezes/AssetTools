namespace AssetTool
{
    [JsonAsset("WaterBodyComponent")]
    public class UWaterBodyComponent : UPrimitiveComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}