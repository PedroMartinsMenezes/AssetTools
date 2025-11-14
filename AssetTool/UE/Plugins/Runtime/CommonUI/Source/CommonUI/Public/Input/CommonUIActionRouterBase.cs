namespace AssetTool
{
    [JsonAsset("CommonUIActionRouterBase")]
    public class UCommonUIActionRouterBase : ULocalPlayerSubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}