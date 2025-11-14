namespace AssetTool
{
    [JsonAsset("MediaFrameworkMediaCaptureSettings")]
    public class UMediaFrameworkMediaCaptureSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MediaFrameworkEditorCaptureSettings")]
    public class UMediaFrameworkEditorCaptureSettings : UMediaFrameworkWorldSettingsAssetUserData
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}