namespace AssetTool
{
    [JsonAsset("LyraSettingValueDiscrete_Resolution")]
    public class ULyraSettingValueDiscrete_Resolution : UGameSettingValueDiscrete
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}