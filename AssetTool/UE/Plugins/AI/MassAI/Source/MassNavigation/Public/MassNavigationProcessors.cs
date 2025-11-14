namespace AssetTool
{
    [JsonAsset("MassOffLODNavigationProcessor")]
    public class UMassOffLODNavigationProcessor : UMassProcessor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MassNavigationSmoothHeightProcessor")]
    public class UMassNavigationSmoothHeightProcessor : UMassProcessor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MassMoveTargetFragmentInitializer")]
    public class UMassMoveTargetFragmentInitializer : UMassObserverProcessor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MassNavigationObstacleGridProcessor")]
    public class UMassNavigationObstacleGridProcessor : UMassProcessor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MassNavigationObstacleRemoverProcessor")]
    public class UMassNavigationObstacleRemoverProcessor : UMassObserverProcessor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}