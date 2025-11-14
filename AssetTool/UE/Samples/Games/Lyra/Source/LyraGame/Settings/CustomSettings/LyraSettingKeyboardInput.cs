namespace AssetTool
{
    [JsonAsset("LyraSettingKeyboardInput")]
    public class ULyraSettingKeyboardInput : UGameSettingValue
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}