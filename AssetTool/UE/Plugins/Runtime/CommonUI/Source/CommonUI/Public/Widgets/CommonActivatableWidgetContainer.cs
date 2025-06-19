namespace AssetTool
{
    [JsonAsset("CommonActivatableWidgetContainerBase")]
    public class UCommonActivatableWidgetContainerBase : UWidget
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CommonActivatableWidgetStack")]
    public class UCommonActivatableWidgetStack : UCommonActivatableWidgetContainerBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CommonActivatableWidgetQueue")]
    public class UCommonActivatableWidgetQueue : UCommonActivatableWidgetContainerBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}