namespace AssetTool
{
    [JsonAsset("GameSettingValueScalarDynamic")]
    public class UGameSettingValueScalarDynamic : UGameSettingValueScalar
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}