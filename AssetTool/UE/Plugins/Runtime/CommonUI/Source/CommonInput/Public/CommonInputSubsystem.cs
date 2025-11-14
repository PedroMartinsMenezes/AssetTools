namespace AssetTool
{
    [JsonAsset("CommonInputSubsystem")]
    public class UCommonInputSubsystem : ULocalPlayerSubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}