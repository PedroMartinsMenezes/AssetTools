namespace AssetTool
{
    [JsonAsset("MassZoneGraphLocationInitializer")]
    public class UMassZoneGraphLocationInitializer : UMassObserverProcessor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MassZoneGraphPathFollowProcessor")]
    public class UMassZoneGraphPathFollowProcessor : UMassProcessor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MassZoneGraphLaneCacheBoundaryProcessor")]
    public class UMassZoneGraphLaneCacheBoundaryProcessor : UMassProcessor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}