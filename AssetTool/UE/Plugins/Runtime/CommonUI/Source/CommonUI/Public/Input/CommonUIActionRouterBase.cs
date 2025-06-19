namespace AssetTool
{
    [JsonAsset("CommonUIActionRouterBase")]
    public class UCommonUIActionRouterBase : ULocalPlayerSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}