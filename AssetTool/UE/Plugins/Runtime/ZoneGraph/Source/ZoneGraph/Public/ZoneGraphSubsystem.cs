namespace AssetTool
{
    [JsonAsset("ZoneGraphSubsystem")]
    public class UZoneGraphSubsystem : UTickableWorldSubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}