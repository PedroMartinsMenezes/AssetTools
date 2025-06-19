namespace AssetTool
{
    [JsonAsset("NavigationGraph")]
    public class ANavigationGraph : ANavigationData
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}