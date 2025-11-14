namespace AssetTool
{
    [JsonAsset("TestEnhancedInputSubsystem")]
    public class UTestEnhancedInputSubsystem : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}