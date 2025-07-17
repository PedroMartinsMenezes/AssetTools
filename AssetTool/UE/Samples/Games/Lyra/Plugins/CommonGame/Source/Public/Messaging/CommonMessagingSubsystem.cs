namespace AssetTool
{
    [JsonAsset("CommonMessagingSubsystem")]
    public class UCommonMessagingSubsystem : ULocalPlayerSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}