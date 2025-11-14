namespace AssetTool
{
    [JsonAsset("WaterBodyComponent")]
    public class UWaterBodyComponent : UPrimitiveComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}