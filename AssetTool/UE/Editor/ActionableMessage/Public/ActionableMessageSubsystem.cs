namespace AssetTool
{
    [JsonAsset("ActionableMessageSubsystem")]
    public class UActionableMessageSubsystem : UWorldSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}