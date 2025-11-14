namespace AssetTool
{
    [JsonAsset("GameSettingValueScalar")]
    public class UGameSettingValueScalar : UGameSettingValue
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}