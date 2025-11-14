namespace AssetTool
{
    [JsonAsset("WaterBodyCustomComponent")]
    public class UWaterBodyCustomComponent : UWaterBodyComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}