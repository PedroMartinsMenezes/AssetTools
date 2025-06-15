namespace AssetTool
{
    [JsonAsset("NavigationInvokerComponent")]
    public class UNavigationInvokerComponent : UActorComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}