namespace AssetTool
{
    [JsonAsset("CommonActivatableWidgetContainerBase")]
    public class UCommonActivatableWidgetContainerBase : UWidget
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CommonActivatableWidgetStack")]
    public class UCommonActivatableWidgetStack : UCommonActivatableWidgetContainerBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CommonActivatableWidgetQueue")]
    public class UCommonActivatableWidgetQueue : UCommonActivatableWidgetContainerBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}