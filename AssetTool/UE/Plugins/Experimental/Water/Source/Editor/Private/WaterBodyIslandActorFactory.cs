namespace AssetTool
{
    [JsonAsset("WaterBodyIslandActorFactory")]
    public class UWaterBodyIslandActorFactory : UActorFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}