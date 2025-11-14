namespace AssetTool
{
    [JsonAsset("MassCrowdLaneTrackingSignalProcessor")]
    public class UMassCrowdLaneTrackingSignalProcessor : UMassSignalProcessorBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MassCrowdLaneTrackingDestructor")]
    public class UMassCrowdLaneTrackingDestructor : UMassObserverProcessor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MassCrowdDynamicObstacleProcessor")]
    public class UMassCrowdDynamicObstacleProcessor : UMassProcessor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MassCrowdDynamicObstacleInitializer")]
    public class UMassCrowdDynamicObstacleInitializer : UMassObserverProcessor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MassCrowdDynamicObstacleDeinitializer")]
    public class UMassCrowdDynamicObstacleDeinitializer : UMassObserverProcessor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}