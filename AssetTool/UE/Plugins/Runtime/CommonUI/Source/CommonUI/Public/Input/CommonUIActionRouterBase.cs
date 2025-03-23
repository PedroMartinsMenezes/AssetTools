namespace AssetTool
{
    [JsonAsset("CommonUIActionRouterBase")]
    public class UCommonUIActionRouterBase : ULocalPlayerSubsystem
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}