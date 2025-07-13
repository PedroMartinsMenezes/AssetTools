namespace AssetTool
{
    [JsonAsset("TestEnhancedInputSubsystem")]
    public class UTestEnhancedInputSubsystem : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}