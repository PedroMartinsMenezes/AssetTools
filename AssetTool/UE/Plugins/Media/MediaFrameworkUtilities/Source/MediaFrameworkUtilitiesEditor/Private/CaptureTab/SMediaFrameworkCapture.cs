namespace AssetTool
{
    [JsonAsset("MediaFrameworkMediaCaptureSettings")]
    public class UMediaFrameworkMediaCaptureSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MediaFrameworkEditorCaptureSettings")]
    public class UMediaFrameworkEditorCaptureSettings : UMediaFrameworkWorldSettingsAssetUserData
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}