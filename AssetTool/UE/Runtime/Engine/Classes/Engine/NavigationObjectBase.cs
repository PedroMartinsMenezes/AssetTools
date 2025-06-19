namespace AssetTool
{
    [JsonAsset("NavigationObjectBase")]
    public class ANavigationObjectBase : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}