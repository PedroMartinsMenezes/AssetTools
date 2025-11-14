namespace AssetTool
{
    [JsonAsset("LocalPlayerSubsystem")]
    public class ULocalPlayerSubsystem : USubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}