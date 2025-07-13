namespace AssetTool
{
    [JsonAsset("HoldoutCompositeSubsystem")]
    public class UHoldoutCompositeSubsystem : UWorldSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}