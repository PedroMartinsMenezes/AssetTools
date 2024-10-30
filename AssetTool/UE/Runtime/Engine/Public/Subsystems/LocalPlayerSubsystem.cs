namespace AssetTool
{
    [JsonAsset("LocalPlayerSubsystem")]
    public class ULocalPlayerSubsystem : USubsystem
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}