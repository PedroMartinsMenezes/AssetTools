namespace AssetTool
{
    [JsonAsset("NavigationTestingActor")]
    public class ANavigationTestingActor : AActor
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}