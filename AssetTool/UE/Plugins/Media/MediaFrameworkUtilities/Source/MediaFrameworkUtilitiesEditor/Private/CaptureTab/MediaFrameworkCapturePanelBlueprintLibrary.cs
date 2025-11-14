namespace AssetTool
{
    [JsonAsset("MediaFrameworkCapturePanel")]
    public class UMediaFrameworkCapturePanel : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MediaFrameworkCapturePanelBlueprintLibrary")]
    public class UMediaFrameworkCapturePanelBlueprintLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}