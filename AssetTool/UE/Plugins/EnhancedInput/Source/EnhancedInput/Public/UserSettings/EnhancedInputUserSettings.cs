namespace AssetTool
{
    [JsonAsset("EnhancedPlayerMappableKeyProfile")]
    public class UEnhancedPlayerMappableKeyProfile : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("EnhancedInputUserSettings")]
    public class UEnhancedInputUserSettings : USaveGame
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}