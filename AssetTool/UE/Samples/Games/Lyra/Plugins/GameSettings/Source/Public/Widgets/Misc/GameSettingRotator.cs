namespace AssetTool
{
    [JsonAsset("GameSettingRotator")]
    public class UGameSettingRotator : UCommonRotator
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}