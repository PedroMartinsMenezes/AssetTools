namespace AssetTool
{
    [JsonAsset("GameSettingValueDiscrete")]
    public class UGameSettingValueDiscrete : UGameSettingValue
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}