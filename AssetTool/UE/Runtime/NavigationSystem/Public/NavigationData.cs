namespace AssetTool
{
    [JsonAsset("NavigationData")]
    public class ANavigationData : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}