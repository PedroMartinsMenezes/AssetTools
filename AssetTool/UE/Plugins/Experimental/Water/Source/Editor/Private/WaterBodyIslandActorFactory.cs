namespace AssetTool
{
    [JsonAsset("WaterBodyIslandActorFactory")]
    public class UWaterBodyIslandActorFactory : UActorFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}