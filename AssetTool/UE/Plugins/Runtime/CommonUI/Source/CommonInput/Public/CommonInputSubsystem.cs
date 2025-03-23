namespace AssetTool
{
    [JsonAsset("CommonInputSubsystem")]
    public class UCommonInputSubsystem : ULocalPlayerSubsystem
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}