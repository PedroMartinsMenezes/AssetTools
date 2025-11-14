namespace AssetTool
{
    [JsonAsset("NavigationGraphNode")]
    public class ANavigationGraphNode : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}