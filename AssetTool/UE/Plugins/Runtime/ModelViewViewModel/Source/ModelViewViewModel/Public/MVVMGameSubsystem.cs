namespace AssetTool
{
    [JsonAsset("MVVMGameSubsystem")]
    public class UMVVMGameSubsystem : UGameInstanceSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}