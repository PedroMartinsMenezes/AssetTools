namespace AssetTool
{
    [JsonAsset("WaterZoneActorFactory")]
    public class UWaterZoneActorFactory : UActorFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}