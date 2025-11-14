namespace AssetTool
{
    [JsonAsset("WaterTerrainComponent")]
    public class UWaterTerrainComponent : UActorComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}