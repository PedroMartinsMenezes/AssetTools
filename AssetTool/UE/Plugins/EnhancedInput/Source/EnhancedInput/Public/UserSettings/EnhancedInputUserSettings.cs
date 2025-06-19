namespace AssetTool
{
    [JsonAsset("EnhancedPlayerMappableKeyProfile")]
    public class UEnhancedPlayerMappableKeyProfile : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("EnhancedInputUserSettings")]
    public class UEnhancedInputUserSettings : USaveGame
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}