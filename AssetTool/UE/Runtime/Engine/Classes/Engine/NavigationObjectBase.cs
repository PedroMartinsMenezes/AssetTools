namespace AssetTool
{
    [JsonAsset("NavigationObjectBase")]
    public class ANavigationObjectBase : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}