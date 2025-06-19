namespace AssetTool
{
    [JsonAsset("NavigationTestingActor")]
    public class ANavigationTestingActor : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}