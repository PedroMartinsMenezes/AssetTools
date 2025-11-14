namespace AssetTool
{
    [JsonAsset("HoldoutCompositeSubsystem")]
    public class UHoldoutCompositeSubsystem : UWorldSubsystem
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}