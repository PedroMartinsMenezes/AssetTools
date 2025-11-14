namespace AssetTool
{
    [JsonAsset("MassNavigationTestingComponent")]
    public class UMassNavigationTestingComponent : UDebugDrawComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MassNavigationTestingActor")]
    public class AMassNavigationTestingActor : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}