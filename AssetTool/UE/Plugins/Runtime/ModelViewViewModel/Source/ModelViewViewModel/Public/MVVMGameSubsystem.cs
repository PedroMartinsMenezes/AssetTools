namespace AssetTool
{
    [JsonAsset("MVVMGameSubsystem")]
    public class UMVVMGameSubsystem : UGameInstanceSubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}