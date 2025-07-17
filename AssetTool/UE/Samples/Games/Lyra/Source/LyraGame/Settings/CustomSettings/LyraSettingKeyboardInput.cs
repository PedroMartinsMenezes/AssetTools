namespace AssetTool
{
    [JsonAsset("LyraSettingKeyboardInput")]
    public class ULyraSettingKeyboardInput : UGameSettingValue
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}