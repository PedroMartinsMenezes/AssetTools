namespace AssetTool
{
    [JsonAsset("NavigationData")]
    public class ANavigationData : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}