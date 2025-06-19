namespace AssetTool
{
    [JsonAsset("NavigationGraphNode")]
    public class ANavigationGraphNode : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}