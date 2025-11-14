namespace AssetTool
{
    [JsonAsset("LyraPlayerMappableKeyProfile")]
    public class ULyraPlayerMappableKeyProfile : UEnhancedPlayerMappableKeyProfile
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}