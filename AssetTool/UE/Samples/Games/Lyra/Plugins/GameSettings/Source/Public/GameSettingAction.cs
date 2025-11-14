namespace AssetTool
{
    [JsonAsset("GameSettingAction")]
    public class UGameSettingAction : UGameSetting
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}