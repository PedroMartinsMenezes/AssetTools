namespace AssetTool
{
    [JsonAsset("NavigationSystemBase")]
    public class UNavigationSystemBase : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}