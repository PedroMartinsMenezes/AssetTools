namespace AssetTool
{
    [JsonAsset("LyraSettingsLocal")]
    public class ULyraSettingsLocal : UGameUserSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}