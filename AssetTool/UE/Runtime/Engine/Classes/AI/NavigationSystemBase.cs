namespace AssetTool
{
    [JsonAsset("NavigationSystemBase")]
    public class UNavigationSystemBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}