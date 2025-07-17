namespace AssetTool
{
    [JsonAsset("GameSettingValueScalar")]
    public class UGameSettingValueScalar : UGameSettingValue
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}