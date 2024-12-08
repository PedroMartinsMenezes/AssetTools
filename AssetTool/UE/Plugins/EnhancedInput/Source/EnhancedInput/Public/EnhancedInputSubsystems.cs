namespace AssetTool
{
    [JsonAsset("EnhancedInputLocalPlayerSubsystem")]
    public class UEnhancedInputLocalPlayerSubsystem : ULocalPlayerSubsystem
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("EnhancedInputWorldSubsystem")]
    public class UEnhancedInputWorldSubsystem : UWorldSubsystem
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}