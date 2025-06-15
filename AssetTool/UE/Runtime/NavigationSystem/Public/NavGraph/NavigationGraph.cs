namespace AssetTool
{
    [JsonAsset("NavigationGraph")]
    public class ANavigationGraph : ANavigationData
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}