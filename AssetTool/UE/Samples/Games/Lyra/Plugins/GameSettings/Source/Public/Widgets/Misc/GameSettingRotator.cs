namespace AssetTool
{
    [JsonAsset("GameSettingRotator")]
    public class UGameSettingRotator : UCommonRotator
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}