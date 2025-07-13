namespace AssetTool
{
    [JsonAsset("WaterTerrainComponent")]
    public class UWaterTerrainComponent : UActorComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}