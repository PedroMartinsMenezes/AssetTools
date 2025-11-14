namespace AssetTool
{
    [JsonAsset("CommonMessagingSubsystem")]
    public class UCommonMessagingSubsystem : ULocalPlayerSubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}