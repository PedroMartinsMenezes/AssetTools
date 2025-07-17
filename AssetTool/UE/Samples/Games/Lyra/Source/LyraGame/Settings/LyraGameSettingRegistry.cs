namespace AssetTool
{
    [JsonAsset("LyraGameSettingRegistry")]
    public class ULyraGameSettingRegistry : UGameSettingRegistry
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}