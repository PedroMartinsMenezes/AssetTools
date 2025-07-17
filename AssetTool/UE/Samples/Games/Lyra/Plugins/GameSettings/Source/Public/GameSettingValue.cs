namespace AssetTool
{
    [JsonAsset("GameSettingValue")]
    public class UGameSettingValue : UGameSetting
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}