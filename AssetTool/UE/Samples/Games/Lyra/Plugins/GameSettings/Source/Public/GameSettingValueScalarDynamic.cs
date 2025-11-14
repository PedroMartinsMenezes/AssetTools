namespace AssetTool
{
    [JsonAsset("GameSettingValueScalarDynamic")]
    public class UGameSettingValueScalarDynamic : UGameSettingValueScalar
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}