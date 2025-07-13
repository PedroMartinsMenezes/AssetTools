namespace AssetTool
{
    [JsonAsset("ZoneGraphSubsystem")]
    public class UZoneGraphSubsystem : UTickableWorldSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}