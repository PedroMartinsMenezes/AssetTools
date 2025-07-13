namespace AssetTool
{
    [JsonAsset("MVVMPanelWidgetViewExtension")]
    public class UMVVMPanelWidgetViewExtension : UMVVMViewExtension
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MVVMViewPanelWidgetClassExtension")]
    public class UMVVMViewPanelWidgetClassExtension : UMVVMViewClassExtension
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}