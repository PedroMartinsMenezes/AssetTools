namespace AssetTool
{
    [JsonAsset("NavigationInvokerComponent")]
    public class UNavigationInvokerComponent : UActorComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}