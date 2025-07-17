namespace AssetTool
{
    [JsonAsset("LyraPlatformSpecificRenderingSettings")]
    public class ULyraPlatformSpecificRenderingSettings : UPlatformSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LyraPerformanceSettings")]
    public class ULyraPerformanceSettings : UDeveloperSettingsBackedByCVars
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}