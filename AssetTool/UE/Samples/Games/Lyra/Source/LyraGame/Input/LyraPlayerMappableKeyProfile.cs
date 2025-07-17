namespace AssetTool
{
    [JsonAsset("LyraPlayerMappableKeyProfile")]
    public class ULyraPlayerMappableKeyProfile : UEnhancedPlayerMappableKeyProfile
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}