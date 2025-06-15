namespace AssetTool
{
    [JsonAsset("NavigationData")]
    public class ANavigationData : AActor
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}