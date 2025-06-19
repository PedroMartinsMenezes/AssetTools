namespace AssetTool
{
    [JsonAsset("CommonInputSubsystem")]
    public class UCommonInputSubsystem : ULocalPlayerSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}