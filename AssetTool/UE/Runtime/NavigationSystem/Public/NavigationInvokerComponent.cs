namespace AssetTool
{
    [JsonAsset("NavigationInvokerComponent")]
    public class UNavigationInvokerComponent : UActorComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}