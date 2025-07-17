namespace AssetTool
{
    [JsonAsset("GameSettingAction")]
    public class UGameSettingAction : UGameSetting
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}