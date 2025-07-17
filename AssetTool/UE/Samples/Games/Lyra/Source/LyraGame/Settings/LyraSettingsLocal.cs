namespace AssetTool
{
    [JsonAsset("LyraSettingsLocal")]
    public class ULyraSettingsLocal : UGameUserSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}