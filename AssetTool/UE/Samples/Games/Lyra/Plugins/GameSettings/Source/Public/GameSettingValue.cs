namespace AssetTool
{
    [JsonAsset("GameSettingValue")]
    public class UGameSettingValue : UGameSetting
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}