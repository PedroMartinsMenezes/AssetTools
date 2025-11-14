namespace AssetTool
{
    [JsonAsset("GameSettingCollection")]
    public class UGameSettingCollection : UGameSetting
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("GameSettingCollectionPage")]
    public class UGameSettingCollectionPage : UGameSettingCollection
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}