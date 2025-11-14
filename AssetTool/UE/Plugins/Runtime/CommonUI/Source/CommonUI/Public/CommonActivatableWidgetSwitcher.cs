namespace AssetTool
{
    [JsonAsset("CommonActivatableWidgetSwitcher")]
    public class UCommonActivatableWidgetSwitcher : UCommonAnimatedSwitcher
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}