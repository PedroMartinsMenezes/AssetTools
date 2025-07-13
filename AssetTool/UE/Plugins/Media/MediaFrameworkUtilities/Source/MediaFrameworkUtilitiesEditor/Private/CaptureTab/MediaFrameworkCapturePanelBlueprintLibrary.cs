namespace AssetTool
{
    [JsonAsset("MediaFrameworkCapturePanel")]
    public class UMediaFrameworkCapturePanel : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MediaFrameworkCapturePanelBlueprintLibrary")]
    public class UMediaFrameworkCapturePanelBlueprintLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}