namespace AssetTool
{
    [JsonAsset("WaterBrushManagerFactory")]
    public class UWaterBrushManagerFactory : UActorFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}