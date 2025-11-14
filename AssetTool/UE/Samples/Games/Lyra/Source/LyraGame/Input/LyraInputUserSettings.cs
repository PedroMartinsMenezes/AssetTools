namespace AssetTool
{
    [JsonAsset("LyraInputUserSettings")]
    public class ULyraInputUserSettings : UEnhancedInputUserSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("LyraPlayerMappableKeySettings")]
    public class ULyraPlayerMappableKeySettings : UPlayerMappableKeySettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}