namespace AssetTool
{
    [JsonAsset("NavigationTestingActor")]
    public class ANavigationTestingActor : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}