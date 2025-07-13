namespace AssetTool
{
    [JsonAsset("SmartObjectSubsystem")]
    public class USmartObjectSubsystem : UWorldSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}