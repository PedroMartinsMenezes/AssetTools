namespace AssetTool
{
    [JsonAsset("SmartObjectSubsystem")]
    public class USmartObjectSubsystem : UWorldSubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}