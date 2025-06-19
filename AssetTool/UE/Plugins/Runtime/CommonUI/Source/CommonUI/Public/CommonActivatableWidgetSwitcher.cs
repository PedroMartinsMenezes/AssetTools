namespace AssetTool
{
    [JsonAsset("CommonActivatableWidgetSwitcher")]
    public class UCommonActivatableWidgetSwitcher : UCommonAnimatedSwitcher
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}