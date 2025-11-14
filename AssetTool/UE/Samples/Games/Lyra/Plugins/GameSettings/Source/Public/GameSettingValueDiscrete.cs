namespace AssetTool
{
    [JsonAsset("GameSettingValueDiscrete")]
    public class UGameSettingValueDiscrete : UGameSettingValue
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}