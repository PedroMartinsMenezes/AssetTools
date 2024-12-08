namespace AssetTool
{
    [JsonAsset("NavigationObjectBase")]
    public class ANavigationObjectBase : AActor
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}