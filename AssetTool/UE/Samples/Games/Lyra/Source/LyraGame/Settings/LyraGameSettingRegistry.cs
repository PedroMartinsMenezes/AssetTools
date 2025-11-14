namespace AssetTool
{
    [JsonAsset("LyraGameSettingRegistry")]
    public class ULyraGameSettingRegistry : UGameSettingRegistry
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}