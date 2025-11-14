namespace AssetTool
{
    [JsonAsset("NavigationGraph")]
    public class ANavigationGraph : ANavigationData
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}