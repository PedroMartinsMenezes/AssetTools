namespace AssetTool
{
    [JsonAsset("WaterBodyRiverComponent")]
    public class UWaterBodyRiverComponent : UWaterBodyComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}