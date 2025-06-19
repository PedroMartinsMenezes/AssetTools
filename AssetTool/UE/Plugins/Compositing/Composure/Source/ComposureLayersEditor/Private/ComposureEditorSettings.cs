namespace AssetTool
{
    [JsonAsset("DefaultComposureEditorSettings")]
    public class UDefaultComposureEditorSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ComposureEditorSettings")]
    public class UComposureEditorSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}